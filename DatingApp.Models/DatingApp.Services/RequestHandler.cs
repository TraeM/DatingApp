using System;
using System.Net;

namespace DatingApp.Services
{
    public class RequestHandler
    {
        public static IApiResponse SendRequest(IApiRequest request)
        {
            throw new NotImplementedException();
        }

        public static IApiResponse SendRequestAsync(IApiRequest request)
        {
            throw new NotImplementedException();
        }

        public static CardStackResponse SendCardStackRequest(IAuthenticationRequest request)
        {
            throw new NotImplementedException();
        }

        internal static WebRequest CreateRequest(IAuthenticationRequest request, RequestType requestType)
        {
            var netRequest = WebRequest.Create(requestUriString: "url");
            netRequest.Credentials = request.AuthenticationCredentials;
            netRequest.ContentType = "application/json";
            netRequest.Method = Enum.GetName(typeof(RequestType), requestType).ToUpper();
            return netRequest;
        }

        public static void EncryptRequest(WebRequest request) { }
    }
}