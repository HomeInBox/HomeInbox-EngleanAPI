using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HomeInbox_EngleanAPI.Database.DatabaseModel
{
    public class UserProfile
    {
        public UserProfile()
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
        public virtual userlogin userlogin { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public DateTime? CREATE_DATE { get; set; }

        public static UserProfile create(Guid aggid,string name,string mail,string phonenumber)
        {
            return new UserProfile
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
