using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Evoke.Smartvoke.DataObjects;
using Evoke.Smartvoke.Api;
using Evoke.Smartvoke.Api.Models;
using Evoke.Smartvoke.DataObjects.User;
using Evoke.Smartvoke.Business.Signup;

namespace Evoke.Smartvoke.Api.Controllers
{
    public class SignupController : ControllerBase
    {
        public ApiResponse Index(User user)
        {
            try
            {
                _Log.Debug(user);
                var Signup = new Signup();
                user = Signup.RegisterUser(user);
                return new ApiResponse(user);
            }
            catch(Exception ex)
            {
                _Log.Error(ex);
                return new ApiResponse(ex);
            }
        }
    }
}
