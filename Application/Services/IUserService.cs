using Application.Models;

namespace Application.Services;

public interface IUserService
{
    Task<UserResponse> RegisterAsync(CredentialsRequest request);
    Task<UserResponse> LoginAsync(CredentialsRequest request);
    Task<UserResponse?> GetByIdAsync(Guid id);
}
