namespace DatingApp.Api
{
    public class MockServiceClient : IServiceClient
    {
        public MockWebApi ServiceApi { get; set; } = new MockWebApi();
    }
}