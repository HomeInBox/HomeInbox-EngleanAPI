using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeInbox_EngleanAPI.Database.DatabaseMdoel
{
    public class Vocabulary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AGGREGATEID { get; set; }
        public string VOCABULARY { get; set; }
        public string MEANING { get; set; }
        public string VOCABULARYTYPE { get; set; }
    }
}
