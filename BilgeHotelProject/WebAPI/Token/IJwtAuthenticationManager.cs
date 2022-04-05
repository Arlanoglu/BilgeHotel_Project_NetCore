using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Token
{
    public interface IJwtAuthenticationManager
    {
        public Task<string> Authenticate(string username, string password);
    }
}
