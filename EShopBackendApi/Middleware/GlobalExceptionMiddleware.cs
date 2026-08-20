using System.Text.Json;
using EShopBackendApi.Middleware;
using Microsoft.AspNetCore.Mvc;

namespace EShopBackendApi.Middleware;

public class GlobalExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<GlobalExceptionMiddleware> _logger;

    public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        _logger.LogError(ex, "An unhandled exception happened.");

        int statusCode;
        string message;

        if (ex is ArgumentException)
        {
            statusCode = 400;
            message = ex.Message;
        }
        else if (ex is InvalidOperationException)
        {
            statusCode = 400;
            message = ex.Message;
        }
        else if (ex is UnauthorizedAccessException)
        {
            statusCode = 401;
            message = ex.Message;
        }
        else
        {
            statusCode = 500;
            message = "An unexpected error occurred.";
        }

        context.Response.StatusCode = statusCode;
        context.Response.ContentType = "application/json";

        await context.Response.WriteAsync(JsonSerializer.Serialize(new { message }));
    }
}