using Extention;
using HomeInbox_EngleanAPI.Database;
using HomeInbox_EngleanAPI.model;
using MediatR;
namespace HomeInbox_EngleanAPI.Handle.VocabularyHandle
{
    public class CreateVocaburalyHandler : IRequestHandler<CreateVocaburalyRequest, ResponseResaultModel<CreateVocaburalyResponse>>
    {
        private readonly DbDatacontext _db;
        public CreateVocaburalyHandler(DbDatacontext db)
        {
            _db = db;
        }
        public async Task<ResponseResaultModel<CreateVocaburalyResponse>> Handle(CreateVocaburalyRequest request,CancellationToken cancellationToken)
        {
            ResponseResaultModel<CreateVocaburalyResponse> resault = new ResponseResaultModel<CreateVocaburalyResponse>();
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
