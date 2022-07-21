using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeInbox_EngleanAPI.Database.DatabaseModel
{
    public class VOCABULARY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AGGREGATEID { get; set; }
        public string VOCABULARYs { get; set; }
        public string MEANING { get; set; }
        public string VOCABULARYTYPE { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public DateTime? CREATE_DATE { get; set; }

        public static VOCABULARY create(string vocabulary, string meaning, string vocabularytype)
        {
            return new VOCABULARY
            {
                VOCABULARYs = vocabulary,
                MEANING = meaning,
                VOCABULARYTYPE = vocabularytype,
                CREATE_DATE = DateTime.Now,
                UPDATE_DATE = DateTime.Now
            };
        }

        public void update(string vocabulary, string meaning, string vocabularytype)
        {
            VOCABULARYs = vocabulary;
            MEANING = meaning;
            VOCABULARYTYPE = vocabularytype;
            CREATE_DATE = DateTime.Now;
            UPDATE_DATE = DateTime.Now;
        }
    }
}
