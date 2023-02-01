using Api_RestSharp_Newtonsoft;
using Newtonsoft.Json;
using static System.Console;
while (true)
{


    MenuHandler menuhandler = new MenuHandler();
    Start();
    void Start()
    {
        menuhandler.Run(0);

    }
    try
    {
        int userChoice = Convert.ToInt32(Console.ReadLine());
        menuhandler.Run(userChoice);

    }
    catch (Exception e)
    {
        WriteLine("Please use numbers only");
        Task.Delay(2000).Wait();    
        menuhandler.Run(0);
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
void DoNotTouch()
{

// using a simple api as example.
// using Restsharp for serialization.
// using newtonsoft for deserialization.
// Data to work with are at the bottom of the page.

GetRestRequest getRestRequest = new GetRestRequest();
Serializer serializer = new Serializer();
//Deserializer deserializer = new Deserializer();

var content = getRestRequest.UsedForDemo(); 
WriteLine(content);
// We no have our Json String.
/*
 Result of GetRequest:
{"categories":[],"created_at":"2020-01-05 13:42:25.628594","icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png",
"id":"wMPtbstoRZ60gPdGwlrZ8g","updated_at":"2020-01-05 13:42:25.628594","url":"https://api.chucknorris.io/jokes/wMPtbstoRZ60gPdGwlrZ8g",
"value":"Chuck Norris can create a Black Hole."}
 */

// Now we Deserialize it to a c# object.
Deserializer deserializer = JsonConvert.DeserializeObject<Deserializer>(content);

WriteLine();
WriteLine(deserializer.id);
WriteLine();
WriteLine(deserializer.url);
WriteLine();
WriteLine(deserializer.value);
WriteLine();
WriteLine(deserializer.icon_url);
WriteLine();
WriteLine(deserializer.updated_at);
WriteLine();
WriteLine(deserializer.created_at);
/*
 Result of Deserializing.

rMbAoHNvRXqkGDGHsPFGAg

https://api.chucknorris.io/jokes/rMbAoHNvRXqkGDGHsPFGAg

Chuck Norris once watched a girl give him a blow job. she died the next second...

https://assets.chucknorris.host/img/avatar/chuck-norris.png

2020-01-05 13:42:22.089095
 */




ReadLine();



}































/*
 This is what we have to work with:

// https://api.chucknorris.io/jokes/random // final endepoint for a random joke.


{
  "categories": [],
  "created_at": "2020-01-05 13:42:20.568859",
  "icon_url": "https://assets.chucknorris.host/img/avatar/chuck-norris.png",
  "id": "Wk35z4oZTkekZeCTGfMsnQ",
  "updated_at": "2020-01-05 13:42:20.568859",
  "url": "https://api.chucknorris.io/jokes/Wk35z4oZTkekZeCTGfMsnQ",
  "value": "Some people think that because the Mayan calendar ends in 2012, that means the world will end. That's not true -- the Mayan calendar ends with 2012 because they pissed off Chuck Norris. They were destroyed before they could start working on the years following."
}
 */