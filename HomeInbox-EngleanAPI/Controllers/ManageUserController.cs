using HomeInbox_EngleanAPI.Handle.ManageUserHandle;
using HomeInbox_EngleanAPI.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeInbox_EngleanAPI.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManageUserController : MvcController
    {
        [HttpPost]
      public async Task<ResponseResaultModel<ManageUserResponse>> createUser(ManageUserRequest request)
      {
           var resault = await Mediator.Send(request);
            return resault;
      }
    }
}
