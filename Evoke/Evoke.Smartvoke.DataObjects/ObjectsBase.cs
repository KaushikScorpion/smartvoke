using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Evoke.Smartvoke.Logger;

namespace Evoke.Smartvoke.DataObjects
{
    public class ObjectsBase
    {
        protected Logger.Logger _Log { get; set; }

        public ObjectsBase()
        {
            try
            {
                _Log = new Logger.Logger(this.GetType());
            }
            catch (Exception ex)
            {
                _Log.Error(ex);
                throw;
            }
        }
    }
}
