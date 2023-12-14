using OnionArchitecture.Application.Features.Auth.Exceptions;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Features.Auth.Rules
{
    public class AuthRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user != null) throw new UserAlreadyExistException();
            return Task.CompletedTask;
        }
    }
}
