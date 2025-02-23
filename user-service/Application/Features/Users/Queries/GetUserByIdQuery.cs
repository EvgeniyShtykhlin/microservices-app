using MediatR;
using user_service.Application.Features.Users.Responces;

namespace user_service.Application.Features.Users.Queries
{
    public class GetUserByIdQuery(Guid id) : IRequest<UserResponse>
    {
        public Guid Id { get; set; } = id;
    }
}
