using MediatR;
using user_service.Application.Features.Users.Commands;
using user_service.Application.Features.Users.Responces;
using user_service.Application.Interfaces;
using user_service.Domain.Entities;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserResponse>
{
    private readonly IUserRepository _userRepository;

    public CreateUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // Создаем новую сущность пользователя
        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        };

        // Сохраняем пользователя в репозитории (базе данных)
        await _userRepository.AddAsync(user);

        // Возвращаем UserResponse с данными созданного пользователя
        return new UserResponse(user.Id, user.FirstName, user.LastName, user.Email);
    }
}