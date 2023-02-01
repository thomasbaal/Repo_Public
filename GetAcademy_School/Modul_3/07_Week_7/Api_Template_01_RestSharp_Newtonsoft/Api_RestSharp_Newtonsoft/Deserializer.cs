using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static System.Console;


namespace Api_RestSharp_Newtonsoft
{
    internal class Deserializer
    {
        // below: edit -> paste special.

        public object[] categories { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }

        public void RunDeserializer(string jsonString)
        {
            Deserializer deserializer1 = JsonConvert.DeserializeObject<Deserializer>(jsonString);
            var test = deserializer1;
            WriteLine(deserializer1.categories);
            WriteLine("Enter to continue");
            ReadLine();
        }



    }
}

/*
  Result of GetRequest:
{"categories":[],"created_at":"2020-01-05 13:42:25.628594","icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png",
"id":"wMPtbstoRZ60gPdGwlrZ8g","updated_at":"2020-01-05 13:42:25.628594","url":"https://api.chucknorris.io/jokes/wMPtbstoRZ60gPdGwlrZ8g",
"value":"Chuck Norris can create a Black Hole."}


 */
