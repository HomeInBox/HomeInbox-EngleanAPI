using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeInbox_EngleanAPI.Database.DatabaseModel
{
    public class USER_LOGIN
    {
        public USER_LOGIN() {

            AGGREGATEID = Guid.NewGuid();
        }
        [Key]
        public Guid AGGREGATEID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public virtual USER_PROFILE UserProfile { get; set; }

    public static USER_LOGIN create(string username, string password)
        {
            return new USER_LOGIN
            {
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
