using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTSecurityDemo.Models
{
   public interface IJWTAuth
    {
        string Authentication(string username, string password);
    }
}
