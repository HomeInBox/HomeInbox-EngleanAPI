using HomeInbox_EngleanAPI.model;
using MediatR;

namespace HomeInbox_EngleanAPI.Handle.ManageUserHandle
{
    public class ManageUserRequest : IRequest<ResponseResaultModel<ManageUserResponse>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public string Name { get; set; }
    }

    public class ManageUserResponse
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
