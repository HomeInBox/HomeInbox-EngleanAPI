using HomeInbox_EngleanAPI.Database;
using HomeInbox_EngleanAPI.model;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HomeInbox_EngleanAPI.Handle.AuthenticationHandel
{
    public class LoginHandler : IRequestHandler<LoginRequest, ResponseResaultModel<LoginResponse>>
    {
        public Appsetting _appsetting;
        private readonly DbDatacontext _db;
        public LoginHandler(Appsetting appsetting, DbDatacontext db)
        {
            _appsetting = appsetting;
            _db = db;
        }
        public async Task<ResponseResaultModel<LoginResponse>> Handle(LoginRequest Request, CancellationToken cancellationToken)
        {

            var logindata = _db.USER_LOGINs.Where(p => p.USERNAME == Request.username && p.PASSWORD == Request.password).FirstOrDefault();

            ResponseResaultModel<LoginResponse> resault = new ResponseResaultModel<LoginResponse>();
            resault.ErrorMessage = new List<string>();
            if (logindata != null)
            {
                var key = _appsetting.GetConfigJwt("key");
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                var tokenkey = Encoding.ASCII.GetBytes(key);
                SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name,Request.username)
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                LoginResponse data = new LoginResponse()
                {
                    Name = Request.username,
                    token = tokenHandler.WriteToken(token)
                };
                resault.data = data;
            }
            else
            {
                resault.Issuccess = false;
                resault.ErrorMessage.Add("Login Fail");
            }
          
            return resault;

        }
    }
}
