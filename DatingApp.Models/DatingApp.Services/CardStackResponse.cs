using System.IO;

using DatingApp.Core;
using DatingApp.Models;

namespace DatingApp.Services
{
    public class CardStackResponse : ApiResponse
    {
        public CardContiner Cards => RetrieveResponse();

        private CardContiner RetrieveResponse()
        {
            using (var reader = new StreamReader(WebResponse.GetResponseStream()))
                return ObjectSerializer.Deserialize<CardContiner>(reader.ReadToEnd());
        }
    }
}