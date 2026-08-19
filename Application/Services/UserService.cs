using Application.Interfaces;
using Application.Models;
using Domain.Models;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<UserResponse> RegisterAsync(CredentialsRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Email) || !request.Email.Contains('@'))
            throw new ArgumentException("A valid email is required.");

        if (string.IsNullOrWhiteSpace(request.Password) || request.Password.Length < 6)
            throw new ArgumentException("Password must be at least 6 characters.");

        var existing = await _repository.GetByEmailAsync(request.Email);
        if (existing is not null)
            throw new InvalidOperationException("Email is already registered.");

        var passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
        var user = new User(Guid.NewGuid(), request.Email, passwordHash);
        await _repository.AddAsync(user);

        return new UserResponse { Id = user.Id, Email = user.Email };
    }
    public async Task<UserResponse> LoginAsync(CredentialsRequest request)
    {
        var user = await _repository.GetByEmailAsync(request.Email);
        if (user is null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            throw new UnauthorizedAccessException("Invalid email or password.");

        return new UserResponse { Id = user.Id, Email = user.Email };
    }

    public async Task<UserResponse?> GetByIdAsync(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);
        if (user is null)
            return null;

        return new UserResponse { Id = user.Id, Email = user.Email };
    }
}
