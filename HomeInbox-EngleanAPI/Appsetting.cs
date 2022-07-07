namespace HomeInbox_EngleanAPI
{
    public class Appsetting
    {
        private IConfiguration _configuration;
        public Appsetting(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConfigJwt(string key)
        {
            var resault = _configuration["Jwt:" + key];
            return resault;
        }
    }
}
