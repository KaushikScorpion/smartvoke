using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evoke.Smartvoke.Logger;

namespace Evoke.Smartvoke.Business
{
    public class BusinessBase
    {
        protected Logger.Logger _Log { get; set; }
    
        public BusinessBase()
        {
            _Log = new Logger.Logger(this.GetType());
        }
    }
}
