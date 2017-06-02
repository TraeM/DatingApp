using Newtonsoft.Json;

namespace DatingApp.Core
{
    public class ObjectSerializer
    {
        public static string Serialize<T>(T payload)
        {
            return JsonConvert.SerializeObject(payload);
        }

        public static T Deserialize<T>(string payload)
        {
            return (T) JsonConvert.DeserializeObject(payload);
        }
    }
}