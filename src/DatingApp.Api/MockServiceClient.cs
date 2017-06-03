using DatingApp.Api.Contracts;

namespace DatingApp.Api
{
    public class MockServiceClient : IServiceClient
    {
        public MockWebApi ServiceApi { get; set; } = new MockWebApi();
    }
}