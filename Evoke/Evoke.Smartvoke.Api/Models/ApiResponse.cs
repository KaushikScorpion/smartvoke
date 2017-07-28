using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evoke.Smartvoke.Api.Models
{
    public class ApiResponse
    {        
        public string Status { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public ApiResponse(object data)
        {
            Status = "Success";
            Data = data;
        }

        public ApiResponse(Exception ex)
        {
            Status = "Error";
            Message = "An Error occurred while processing the request.";
            Data = new { ExceptionMessage = ex.Message, ExceptionDetails = ex.StackTrace };
        }
    }
}