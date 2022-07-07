using HomeInbox_EngleanAPI.model;
using MediatR;
namespace HomeInbox_EngleanAPI.Handle.VocabularyHandle
{
    public class SearchVocabularyRequest : IRequest<ResponseResaultModel<List<SearchVocabularyResponse>>>
    {
        public string vocabulary { get; set; }
        public string meaning { get; set; }
        public string Vocabularytype { get; set; }
        public int pagesize { get; set; }
        public int page { get; set; }
    }

    public class SearchVocabularyResponse
    {
        public string vocabulary { get; set; }
        public string meaning { get; set; }
        public string Vocabularytype { get; set; }
    }
}
