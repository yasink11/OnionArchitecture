using MediatR;
using System.ComponentModel;

namespace OnionArchitecture.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest :IRequest<LoginCommandResponse>
    {
        [DefaultValue("string12@gmail.com")]
        public string Email { get; set; }
        [DefaultValue("123456")]
        public string Password { get; set; }
    }
}
