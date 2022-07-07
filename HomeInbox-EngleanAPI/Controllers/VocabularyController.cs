using HomeInbox_EngleanAPI.Handle.VocabularyHandle;
using HomeInbox_EngleanAPI.model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeInbox_EngleanAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VocabularyController : ControllerBase
    {
        [HttpPost]
        public async Task<ResponseResaultModel<SearchVocabularyResponse>> SearchVocabulary(SearchVocabularyRequest request)
        {
            return null;
        }
    }
}
