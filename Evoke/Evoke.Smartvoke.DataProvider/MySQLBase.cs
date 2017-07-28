using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using Evoke.Smartvoke.Logger;

namespace Evoke.Smartvoke.DataProvider
{
    public class MySQLBase 
    {
        protected Logger.Logger _Log { get; set; }
        protected MySqlConnection _MysqlConnection { get; set; }

        public MySQLBase()
        {
            try
            {
                _Log = new Logger.Logger(this.GetType());
                _MysqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["Smartvoke"].ConnectionString);
            }
            catch (Exception ex)
            {
                _Log.Error(ex);
                throw;
            }
        }
     }
}
