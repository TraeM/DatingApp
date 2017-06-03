using DatingApp.Api.Contracts;
using DatingApp.Services;
using DatingApp.Services.Contracts;

using static DatingApp.Services.RequestHandler;

namespace DatingApp.Api
{
    public class MockWebApi : IApi<IApiRequest, IApiResponse>
    {
        /// <inheritdoc />
        public IApiResponse Send(IApiRequest request)
        {
            return SendRequest(request);
        }

        /// <inheritdoc />
        public IApiResponse SendAsync(IApiRequest request)
        {
            return SendRequest(request);
        }

        public IApiResponse FetchNextCardStack(IAuthenticationRequest request)
        {
            return SendCardStackRequest(request);
        }
    }
}