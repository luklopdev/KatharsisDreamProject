using System.Net;

namespace KatharsisDreamProjectAPI.Models
{
    public class Response
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
    }

    public class Response<T> : Response
    {
        public T Data { get; set; }
    }
}
