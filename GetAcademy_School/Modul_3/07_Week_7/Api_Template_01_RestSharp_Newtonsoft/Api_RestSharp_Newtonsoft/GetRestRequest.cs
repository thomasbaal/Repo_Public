using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Api_RestSharp_Newtonsoft
{
    internal class GetRestRequest
    {
        private string _jsonString;
        private string[] _endpoint { get; set; }
        private Deserializer _deserializer { get; set; }


        public GetRestRequest()
        {
            _endpoint = new string[] {"random", "categories"};
            _deserializer= new Deserializer();
        }
        public string RunRequest(int endpoint)
        {
            if (endpoint == 1)
            {
                CreateJsonStringFromClient(1);
                _deserializer.RunDeserializer(_jsonString);
                ReadLine();

            }

            if (endpoint == 2)
            {
                CreateJsonStringFromClient(2);

            }
            return _jsonString;

        }

        public void CreateJsonStringFromClient(int endpoint)
        {
            var client = new RestClient("https://api.chucknorris.io/");
            var request = new RestRequest($"jokes/{_endpoint[endpoint]}", Method.Get);
            var content = client.Execute(request).Content; // stores Json string in "Content" variable.
            
            _jsonString = "{\"categories\": "+content+"}";
        }



    /*
     *
     {"categories":["animal","career","celebrity","dev","explicit","fashion","food","history","money",
    "movie","music","political","religion","science","sport","travel"]}
     */


    //////////////////////////////////////////////////////////////////////////////////////////////////
    // !! Do not change: Used for demo only. !!
    public string UsedForDemo()
        {
            var client = new RestClient("https://api.chucknorris.io/");
            var request = new RestRequest($"jokes/random", Method.Get);
            var content = client.Execute(request).Content; // stores Json string in "Content" variable.
            return content;

        }


    }
}
