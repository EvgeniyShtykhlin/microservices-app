using MediatR;

namespace user_service.Application.Features.Users.Commands;

public class CreateUserCommand : IRequest<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}