using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVM;

namespace AquaBL
{
    public interface IUserLogin
    {
        UserLoginVM ValidateUser(string userName, string password);
    }
}
