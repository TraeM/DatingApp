using System.IO;

using DatingApp.Core;
using DatingApp.Data.Dto;

namespace DatingApp.Services.Response
{
    public class CardStackResponse : ApiResponse
    {
        public CardContiner Cards => RetrieveResponse();

        private CardContiner RetrieveResponse()
        {
            using (var reader = new StreamReader(WebResponse.GetResponseStream()))
                return ObjectSerializer.DeserializeXml<CardContiner>(reader.ReadToEnd());
        }
    }
}