using HomeInbox_EngleanAPI.model;
using MediatR;
namespace HomeInbox_EngleanAPI.Handle.VocabularyHandle
{
    public class SearchVocabularyHandler : IRequestHandler<SearchVocabularyRequest, ResponseResaultModel<List<SearchVocabularyResponse>>>
    {
        public async Task<ResponseResaultModel<List<SearchVocabularyResponse>>> Handle(SearchVocabularyRequest request,CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
