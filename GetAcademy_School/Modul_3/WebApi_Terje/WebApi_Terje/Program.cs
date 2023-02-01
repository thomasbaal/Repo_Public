// 1. legg til app.UsestatcFiles(); under app.MapGet Metoden under.
// 2. Launchsettings -> launchurl settes til index.html
// 3. legg til mappe "wwwroot" i roten av c# prosjekt.
// 4. herunder legger man til new item "html page" med navngis med navnet man satt i punkt 2.
// 5. lag instancer av Todo i metoden app.MapGet under, se under
/////////////////////////////////////////////////////////////////////////////////////////////////
using System.Numerics;
using WebApi_Terje.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var inMemoryDb = new List<Todo>
{
    // 5. 
    new Todo("Handle til middag"),
    new Todo("Lage middag"),
    new Todo("Spise middag"){Done = new DateTime(2020,10,10)},

 };

app.MapGet("/todo", () =>
{
    return inMemoryDb;
   
});
app.UseStaticFiles(); // 1.Dette må tas med for å hoste html filene.
                       // må også endre launchUrl under "Launchsettings"
app.Run();

/*
 
  currentPage: 'choose',
            creatureSelected: '',
            enemyCreature: '',
            playerCurrency: 100,
            currentWins: 0,
            store: [{itemName: 'healthPotion',
            itemValue: 5,
            itemAmount: 10},
            {itemName: 'GreaterHealthPotion',
            itemValue: 10,
            itemAmount: 5},
            ],
 
 */
