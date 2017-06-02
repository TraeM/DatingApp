using DatingApp.Services;

namespace DatingApp.Api
{
    public interface IApi<in TRequest, out TResponse>
        where TRequest : IApiRequest
        where TResponse : IApiResponse
    {
        TResponse Send(TRequest request);
        TResponse SendAsync(TRequest request);
    }
}