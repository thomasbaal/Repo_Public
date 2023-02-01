using Serialize_Deserialize_with_sytem_text_json;
using static System.Console;
using System.Text.Json;

// the string used are beeing reffered to as "Company"(name of json file data)

// Optional: create a string of json data,within class JsonComplexObject.
//WriteLine(JsonComplexObject.Json); // Works
                                   ///////////////////

//1. copy json string to use, do a paste special inside a class. (JsonComplexObject_Paste-Special) 
                // to see the buildup and structure.

//2. get the json string.
var jsonString = GetJsonString();
static string GetJsonString()
{
    return JsonComplexObject.Json;
}

//3. Deserialize using builtin System.Text.Json.
MicrosoftDeserializer microsoftDeserializer = new MicrosoftDeserializer();
var company = microsoftDeserializer.DeserializeUsingSystemTextJson(jsonString);

WriteLine(company.name); // Microsoft

foreach (var coFounders in company.cofounders)
{
    WriteLine($"Id :" +coFounders.id + "\nCo-Founders :" +coFounders.name);
    WriteLine();
}

var count = 0;
foreach (var employees in company.employees)
{
    WriteLine("Employee Id :{0}\nFullName : {1}\nAnual Salary : {2}", 
        employees.id, employees.fullName, employees.anualSalary);
    WriteLine("------------------------------------------------------------------------------------");
    count++;
}

ReadLine();