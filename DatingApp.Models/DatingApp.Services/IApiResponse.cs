using System;
using System.Net;

namespace DatingApp.Services
{
    public interface IApiResponse
    {
        HttpWebResponse WebResponse { get; set; }
        bool Success { get; set; }
        Exception Exception { get; set; }
    }
}