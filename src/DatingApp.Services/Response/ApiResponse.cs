using System;
using System.Net;

using DatingApp.Services.Contracts;

namespace DatingApp.Services.Response
{
    public class ApiResponse : IApiResponse
    {
        public HttpWebResponse WebResponse { get; set; }
        public bool Success { get; set; }
        public Exception Exception { get; set; }
    }
}