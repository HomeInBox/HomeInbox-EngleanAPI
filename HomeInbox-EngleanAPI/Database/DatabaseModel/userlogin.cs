using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeInbox_EngleanAPI.Database.DatabaseModel
{
    public class userlogin
    {
        public userlogin() {

            AGGREGATEID = Guid.NewGuid();
        }
        [Key]
        public Guid AGGREGATEID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public virtual UserProfile UserProfile { get; set; }

    public static userlogin createa(string username, string password)
        {
            return new userlogin {
                USERNAME = username,
                PASSWORD = password,
                CREATE_DATE = DateTime.Now,
                UPDATE_DATE = DateTime.Now
            };
        }

        public void update (string username,string password)
        {
            PASSWORD = password;
            CREATE_DATE = DateTime.Now;
            UPDATE_DATE = DateTime.Now;
        }
    }
}
