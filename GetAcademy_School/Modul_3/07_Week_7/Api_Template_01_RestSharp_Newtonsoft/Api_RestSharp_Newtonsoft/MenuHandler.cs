using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Api_RestSharp_Newtonsoft
{
    internal class MenuHandler
    {

        private string _welcomeText = "Welcome to chuck-land - Demonstrating < RestSharp > and < Newtonsoft Serializer / Deserializer> ";

        private string _mainMenu = "1: for random chuck.\n2: for category pick. \n3: for for search.";
                                   

        public void Run(int menuNumber)
        {
           
            if (menuNumber == 0)
            {
                Clear();
                WriteLine(_welcomeText);
                WriteLine(_mainMenu); 
            }
           
            if (menuNumber == 1)
            {
                GetRestRequest getRandom = new GetRestRequest();
                getRandom.RunRequest(1);

            }
            if (menuNumber == 2)
            {
                GetRestRequest getCategories = new GetRestRequest();

                
            }
            if (menuNumber == 3) WriteLine(_mainMenu);
         
        }
    }
}

/*
 
 using System.Text.Json;

static string fileName = $"C:\\code\\C-Sharp\\LeagueOfLegends\\lol-champions.json";
        static string jsonString = File.ReadAllText(fileName);

public Methods()
        {
            championList = JsonSerializer.Deserialize<List<Champion>>(jsonString);
        }
 */