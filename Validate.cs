using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernGUI_V3
{
    public class Validate
    {
        UserDao userDao = new UserDao();
        public bool Loginuser(string user, string pass)
        {
            return userDao.Login2(user, pass);
        } 
    }
}
