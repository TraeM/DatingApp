using System.IO;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace DatingApp.Core
{
    public class ObjectSerializer
    {
        public static string SerializeJson<T>(T payload)
        {
            return JsonConvert.SerializeObject(payload);
        }

        public static T DeserializeJson<T>(string payload)
        {
            return (T) JsonConvert.DeserializeObject(payload);
        }

        public static string SerializeXml<T>(T obj)
        {
            using (var stringwriter = new StringWriter())
            {
                new XmlSerializer(typeof(T)).Serialize(stringwriter, obj);
                return stringwriter.ToString();
            }
        }

        public static T DeserializeXml<T>(string xml)
        {
            using (var stringReader = new StringReader(xml))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T) serializer.Deserialize(stringReader);
            }
        }
    }
}