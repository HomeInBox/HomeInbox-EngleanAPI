using Extention;
using HomeInbox_EngleanAPI.Database;
using HomeInbox_EngleanAPI.model;
using MediatR;
namespace HomeInbox_EngleanAPI.Handle.VocabularyHandle
{
    public class SearchVocabularyHandler : IRequestHandler<SearchVocabularyRequest, ResponseResaultModel<List<SearchVocabularyResponse>>>
    {
        private readonly DbDatacontext _db;
        public SearchVocabularyHandler(DbDatacontext db)
        {
            _db = db;
        }
        public async Task<ResponseResaultModel<List<SearchVocabularyResponse>>> Handle(SearchVocabularyRequest request,CancellationToken cancellationToken)
        {
            ResponseResaultModel<List<SearchVocabularyResponse>> resault = new ResponseResaultModel<List<SearchVocabularyResponse>>();
            if (request.vocabulary.IsNotNullOrEmpty())
            {
                resault.ErrorMessage.Add("invalid vocabulary!");
            }
            else if (request.Vocabularytype.IsNotNullOrEmpty())
            {
                resault.ErrorMessage.Add("invalid Vocabulary Type!");
            }
            else if (request.meaning.IsNotNullOrEmpty())
            {
                resault.ErrorMessage.Add("invalid meaning!");
            }

            return resault;
        }
    }
}
