using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Evoke.Smartvoke.Logger
{
    public class Logger
    {
        private ILog _Log { get; set; }

        public Logger(Type caller)
        {
            _Log = LogManager.GetLogger(caller.GetType());
        }

        public void Info(object message)
        {
            _Log.Info(message);
        }

        public void Debug(object data)
        {
            _Log.Debug(new { Inputs = data });
        }

        public void Error(Exception ex)
        {
            _Log.Error(new { Error = ex.Message }, ex);
        }
    }
}
