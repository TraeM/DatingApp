using System;
using System.Net;

namespace DatingApp.Services
{
    public class ApiResponse : IApiResponse
    {
        public HttpWebResponse WebResponse { get; set; }
        public bool Success { get; set; }
        public Exception Exception { get; set; }
    }
}