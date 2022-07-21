using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeInbox_EngleanAPI.Database.DatabaseModel
{
    public class TESTSCORE
    {
        [Key]
        public Guid AGGREGATEID { get; set; }
        public int SCORE { get; set; }
        public string STATUS { get; set; }
        public int NO { get; set; }
        [ForeignKey("UserProfile")]
        public Guid AGGREGATEIDUSERPROFILE { get; set; }
        public virtual USER_PROFILE UserProfile { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
    }
}
