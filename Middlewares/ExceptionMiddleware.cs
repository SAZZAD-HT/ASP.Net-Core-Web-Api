using ispat.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ispat.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IHostEnvironment _env;
        public ExceptionMiddleware(RequestDelegate next, IHostEnvironment env)
        {
            _next = next;
            _env = env;
           
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                ApiError response;
                HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;

                string message;
                var exceptiopnType = ex.GetType();

                if(exceptiopnType == typeof(UnauthorizedAccessException))
                {
                    httpStatusCode = HttpStatusCode.Forbidden;
                    message = "You are not authorize.";
                }else 
                {
                    message = "Something went wrong.";
                }

                if (_env.IsDevelopment())
                {
                    response = new ApiError((long)httpStatusCode, ex.Message, ex.StackTrace);
                }
                else
                {
                    response = new ApiError((long)httpStatusCode, message);
                }

                httpContext.Response.StatusCode = (int)httpStatusCode;
                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsync(response.ToJson());
            }
        }


    }
}
