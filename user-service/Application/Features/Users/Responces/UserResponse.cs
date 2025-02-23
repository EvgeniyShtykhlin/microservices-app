namespace user_service.Application.Features.Users.Responces
{
    public record UserResponse(Guid Id, string FirstName, string LastName, string Email);
}