using HomeInbox_EngleanAPI.model;
using MediatR;
namespace HomeInbox_EngleanAPI.Handle.AuthenticationHandel
{
    public class LoginRequest : IRequest<ResponseResaultModel<LoginResponse>>
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class LoginResponse
    {
        public string token { get; set; }
        public string Name { get; set; }
    }
}