using GameLogic.Interfaces;
using GameLogic.Models;
using GameLogic.Models.Cards;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.DataConverter
{
    public class PackRepository
    {
        private const string JsonPath = @"./Data/cah-cards-full.json";
        private readonly Dictionary<string, Pack> Collection = LoadCardCollection();

        public static Dictionary<string, Pack> LoadCardCollection()
        {
            return (LoadDecksFromStream(File.OpenRead(JsonPath))).Result;
           
        }

        private async static Task<Dictionary<string, Pack>> LoadDecksFromStream(Stream source)
        {
            StreamReader reader = new StreamReader(source);
            string json = await reader.ReadToEndAsync();

            JObject Jobj = JObject.Parse(json);

            Dictionary<string, Pack> result = new Dictionary<string, Pack>();

            foreach(KeyValuePair<string, JToken> cardCollection in Jobj)
            {
                JObject obj = (JObject)cardCollection.Value;

                string packName = obj["name"].ToString();
                Pack newCardCollection = new Pack()
                {
                    Name = packName,
                    BlackCards = LoadCards<BlackCard>((JArray)obj["black"], packName).ToList(),
                    WhiteCards = LoadCards<WhiteCard>((JArray)obj["white"], packName).ToList(),
                };

                result.Add(packName, newCardCollection);
            }
            return result;
        }

        private static IEnumerable<T> LoadCards<T>(JArray obj, string packName) where T : Card
        {
            foreach(JToken i in obj)
            {
                T card = i.ToObject<T>();
                card.PackName = packName;
                yield return card;
            }
        }
    }
}
