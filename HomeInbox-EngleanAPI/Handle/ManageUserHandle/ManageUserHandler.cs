using Extention;
using HomeInbox_EngleanAPI.Database;
using HomeInbox_EngleanAPI.Database.DatabaseModel;
using HomeInbox_EngleanAPI.model;
using MediatR;
namespace HomeInbox_EngleanAPI.Handle.ManageUserHandle
{
    public class ManageUserHandler : IRequestHandler<ManageUserRequest, ResponseResaultModel<ManageUserResponse>>
    {
        private readonly DbDatacontext _db;
        public ManageUserHandler(DbDatacontext db)
        {
            _db = db;
        }
        public async Task<ResponseResaultModel<ManageUserResponse>> Handle(ManageUserRequest request,CancellationToken cancellationToken)
        {
            ResponseResaultModel<ManageUserResponse> resault = new ResponseResaultModel<ManageUserResponse>();
            resault.ErrorMessage = new List<string>();
            var createUserlogin = USER_LOGIN.create(request.Username, request.Password);
            if (request.Username.IsNullOrEmpty())
            {
                resault.ErrorMessage.Add("invalid Username");
            }
            else if (request.Password.IsNullOrEmpty())
            {
                resault.ErrorMessage.Add("invalid Password");
            }
            else if (request.Username.IsNullOrEmpty())
            {
                resault.ErrorMessage.Add("invalid Username");
            }
            else if (request.Password.IsNullOrEmpty())
            {
                resault.ErrorMessage.Add("invalid Password");
            }
            else
            {
                _db.Add(createUserlogin);
                var createuserprofile = USER_PROFILE.create(createUserlogin.AGGREGATEID, request.Name, request.Email, request.phoneNumber);
                _db.Add(createuserprofile);
            }
            
            _db.SaveChanges();

            return resault;
        }
    }
}
