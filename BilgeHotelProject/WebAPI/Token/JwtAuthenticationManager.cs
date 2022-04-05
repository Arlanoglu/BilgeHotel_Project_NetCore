using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Token
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        private readonly UserManager<AppUser> userManager;

        public JwtAuthenticationManager(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<string> Authenticate(string username, string password)
        {
            var user = await userManager.FindByEmailAsync(username);
            var roles = await userManager.GetRolesAsync(user);
            if (user == null && roles.Contains("valilik")==false)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes("Guest info token security key");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.Now.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
