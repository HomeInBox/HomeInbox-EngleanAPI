using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HomeInbox_EngleanAPI.Controllers
{
    public abstract class MvcController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
    }
}
