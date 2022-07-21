using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HomeInbox_EngleanAPI.Database.DatabaseModel
{
    public class USER_PROFILE
    {
        public USER_PROFILE()
        {
            AGGREGATEID = Guid.NewGuid();
        }
        [Key]
        public Guid AGGREGATEID { get; set; }
        public string NAME { get; set; }
        public string MAIL { get; set; }
        public string PHONE { get; set; }

        [ForeignKey("userlogin")]
        public Guid AGGREGATEIDUSERLOGIN { get; set; }
        public virtual USER_LOGIN userlogin { get; set; }
        public virtual List<TESTSCORE> TESTSCOREs { get; set; } 
        public DateTime? UPDATE_DATE { get; set; }
        public DateTime? CREATE_DATE { get; set; }

        public static USER_PROFILE create(Guid aggid,string name,string mail,string phonenumber)
        {
            return new USER_PROFILE
            {
                NAME = name,
                MAIL = mail,
                PHONE = phonenumber,
                AGGREGATEIDUSERLOGIN = aggid,
                UPDATE_DATE = DateTime.Now,
                CREATE_DATE = DateTime.Now
            };
        }
    }
}
