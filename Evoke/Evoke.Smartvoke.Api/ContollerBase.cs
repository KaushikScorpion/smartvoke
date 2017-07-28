using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Evoke.Smartvoke.Logger;

namespace Evoke.Smartvoke.Api
{
    public class ControllerBase : ApiController
    {
        protected Logger.Logger _Log { get; set; }

        public ControllerBase()
        {
            _Log = new Logger.Logger(this.GetType());
        }
    }
}