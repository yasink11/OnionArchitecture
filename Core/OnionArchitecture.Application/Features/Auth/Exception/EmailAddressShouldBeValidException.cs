using OnionArchitecture.Application.Bases;

namespace OnionArchitecture.Application.Features.Auth.Exceptions
{
    public class EmailAddressShouldBeValidException : BaseException
    {
        public EmailAddressShouldBeValidException() : base("E-mail adresi bulunamadı.") { }
    }
}

