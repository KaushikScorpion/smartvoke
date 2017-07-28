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
using Evoke.Smartvoke.Business.Signin;

namespace Evoke.Smartvoke.Api.Controllers
{
    public class SignInController : ControllerBase
    {
        public ApiResponse SignIn(User user)
        {
            try
            {
                _Log.Debug(user);
                var Signin = new Signin();
                user = Signin.SigninUser(user);
                return new ApiResponse(user);
            }
            catch (Exception ex)
            {
                _Log.Error(ex);
                return new ApiResponse(ex);
            }
        }
    }
}
