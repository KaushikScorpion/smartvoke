using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evoke.Smartvoke.DataObjects.User;
using Evoke.Smartvoke.DataProvider;

namespace Evoke.Smartvoke.Business.Signup
{
    public class Signup : BusinessBase
    {
        public User RegisterUser(User user)
        {
            try
            {
                _Log.Debug(user);
                var MySQLUser = new MySQLUser();
                user = MySQLUser.RegisterUser(user);
                return user;
            }
            catch(Exception ex)
            {
                _Log.Error(ex);
                throw;
            }
        }
    }
}
