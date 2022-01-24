using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JWTSecurityDemo.Models
{
    public class Auth : IJWTAuth
    {
        private readonly string username = "Geetha";
        private readonly string password = "Pass@123";
        private readonly string key;
        public Auth(string key)
        {
            this.key = key;
        } 
        public string Authentication(string username, string password)
        {
            if(!(username.Equals(username) || password.Equals(password)))
            {
                return null;
             }

            var tokenHandler = new JwtSecurityTokenHandler();
            
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var tokeneDescriptor = new SecurityTokenDescriptor()
            
            { Subject=new ClaimsIdentity(
                new Claim[]
                {new Claim(ClaimTypes.Name,username)
                }),
                Expires=DateTime.Now.AddHours(1),
                SigningCredentials=new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),SecurityAlgorithms.HmacSha256Signature)
             };
            var token = tokenHandler.CreateToken(tokeneDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
