using KatharsisDreamProjectAPI.Models;
using Newtonsoft.Json;
using System.Net;

namespace KatharsisDreamProjectAPI.Middlewares
{
    public class ErrorHandlingMiddlware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Response response = null;

            try
            {
                await next.Invoke(context);
            }
            catch(Exception ex)
            {
                response = new Response()
                {
                    Code = HttpStatusCode.InternalServerError,
                    Message = "Internal Server Error",
                };
            }
            finally
            {
                context.Response.StatusCode = (int)response.Code;
                await context.Response.WriteAsJsonAsync(response);
            }
        }
    }
}
