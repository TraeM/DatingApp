namespace DatingApp.Services
{
    public enum RequestType
    {
        Get = 1,
        Post = 2,
        Put = 4,
        Head = 8,
        Connect = 16,
        Options = 32,
        Trace = 64,
        Patch = 128
    }
}