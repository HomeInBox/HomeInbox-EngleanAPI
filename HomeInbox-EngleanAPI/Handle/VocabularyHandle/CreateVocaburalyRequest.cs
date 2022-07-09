using HomeInbox_EngleanAPI.model;
using MediatR;
namespace HomeInbox_EngleanAPI.Handle.VocabularyHandle
{
    public class CreateVocaburalyRequest : IRequest<ResponseResaultModel<CreateVocaburalyResponse>> 
    {
        public string vocabulary { get; set; }
        public string meaning { get; set; }
        public string Vocabularytype { get; set; }
    }

    public class CreateVocaburalyResponse
    {
        public string vocabulary { get; set; }
        public string meaning { get; set; }
        public string Vocabularytype { get; set; }
    }
}
