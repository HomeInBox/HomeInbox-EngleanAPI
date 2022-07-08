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
             var data = userlogin.createa(request.Username,request.Password);

            _db.Add(data);
            _db.SaveChanges();

            return resault;
        }
    }
}
