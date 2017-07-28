using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evoke.Smartvoke.DataObjects.User;
using Evoke.Smartvoke.DataProvider;

namespace Evoke.Smartvoke.Business.Signin
{
    public class Signin : BusinessBase
    {
        public User SigninUser(User user)
        {
            try
            {
                _Log.Debug(user);
                var MySQLUser = new MySQLUser();
                user = MySQLUser.SignInUser(user);
                return user;
            }
            catch (Exception ex)
            {
                _Log.Error(ex);
                throw;
            }
        }
    }
}
