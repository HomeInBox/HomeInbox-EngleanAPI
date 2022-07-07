using HomeInbox_EngleanAPI.Handle.AuthenticationHandel;
using HomeInbox_EngleanAPI.model;
using Microsoft.AspNetCore.Mvc;

namespace HomeInbox_EngleanAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : MvcController
    {
        [HttpPost]
        public async Task<ResponseResaultModel<LoginResponse>> Login(LoginRequest request)
        {
            var resqult = await Mediator.Send(request);
            return resqult;
        }
    }
}
