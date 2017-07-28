using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Evoke.Smartvoke.DataObjects.User 
{
    public class User : ObjectsBase
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }
    
        public User()
        {

        }

        public User(DataTable user_base)
        {
            try
            {
                Id = Convert.ToString(user_base.Rows[0]["UserId"]);
                FirstName = Convert.ToString(user_base.Rows[0]["FirstName"]);
                LastName = Convert.ToString(user_base.Rows[0]["LastName"]);
                Email = Convert.ToString(user_base.Rows[0]["Email"]);
                Phone = Convert.ToString(user_base.Rows[0]["Phone"]);
            }
            catch(Exception ex)
            {
                _Log.Error(ex);
                throw;
            }
        }
    }
}
