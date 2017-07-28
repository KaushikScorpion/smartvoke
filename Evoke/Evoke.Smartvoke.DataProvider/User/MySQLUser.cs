using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evoke.Smartvoke.DataObjects.User;
using System.Data;
using MySql.Data.MySqlClient;

namespace Evoke.Smartvoke.DataProvider
{
    public class MySQLUser : MySQLBase
    {
        public User RegisterUser(User user)
        {
            try
            {
                _Log.Debug(user);
                _MysqlConnection.Open();
                using (MySqlCommand Command = new MySqlCommand("udsp_RegisterUser", _MysqlConnection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("var_FirstName", user.FirstName);
                    Command.Parameters.AddWithValue("var_LastName", user.LastName);
                    Command.Parameters.AddWithValue("var_Email", user.Email);
                    Command.Parameters.AddWithValue("var_Password", user.Password);
                    Command.Parameters.AddWithValue("var_Phone", user.Phone);
                    user.Id = Convert.ToString(Command.ExecuteScalar());
                    user.Password = null;
                }
                return user;                
            }
            catch(Exception ex)
            {
                _Log.Error(ex);
                throw;
            }
            finally
            {
                _MysqlConnection.Close();
            }
        }

        public User SignInUser(User user)
        {
            try
            {
                _Log.Debug(user);
                _MysqlConnection.Open();
                using (MySqlCommand Command = new MySqlCommand("udsp_VerifyUser", _MysqlConnection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("var_Email", user.Email);
                    Command.Parameters.AddWithValue("var_Password", user.Password);

                    DataTable User_Base = new DataTable();
                    MySqlDataAdapter Adapter = new MySqlDataAdapter(Command);
                    Adapter.Fill(User_Base);
                    user = new User(User_Base);

                }
                return user;
            }
            catch (Exception ex)
            {
                _Log.Error(ex);
                throw;
            }
            finally
            {
                _MysqlConnection.Close();
            }
        }

    }
}
