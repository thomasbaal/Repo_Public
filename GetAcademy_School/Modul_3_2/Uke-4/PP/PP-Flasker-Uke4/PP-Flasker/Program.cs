using PP_Flasker;

var bottle1 = new Bottle(5);
var bottle2 = new Bottle(3);
int[] operations = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

//bottle1.Content = 0;
bottle2.Content = 5;



//bottle1.Empty();
//bottle2.Empty();
//bottle1.FillToTopFromTap();
//bottle2.FillToTopFromTap();
//bottle2.Fill(bottle1.Empty());
//bottle1.Fill(bottle2.Empty()); // kjørrer .Empty først..

// Tanken er at Empty() returnerer hvor mye det var i flasken før den ble tømt
// Tanken er at FillToTop tar en annen Bottle som parameter. Hvis det er nok, fyller den 
// bottle2 og reduserer bottle1 tilsvarende. Hvis ikke gjør den ingenting.


var wantedVolume = 5;

for (int operationNo = 0; operationNo < 8; operationNo++)
{
    bottle1.Empty();
    bottle2.Empty();
    if (operationNo == 0) bottle1.FillToTopFromTap();
    else if (operationNo == 1) bottle2.FillToTopFromTap();
    else if (operationNo == 2) bottle2.Fill(bottle1.Empty());
    else if (operationNo == 3) bottle1.Fill(bottle2.Empty());
    else if (operationNo == 4) bottle2.FillToTop(bottle1);
    else if (operationNo == 5) bottle1.FillToTop(bottle2);
    else if (operationNo == 6) bottle1.Empty();
    else if (operationNo == 7) bottle2.Empty();

    if (bottle1.Content == wantedVolume || bottle2.Content == wantedVolume)
    {
        Console.WriteLine("Fant ønsket volum ved operasjon " + operationNo);
    }
}

//Todo Lag metode for alle 8 mulige kombinasjoner.
//Fylle flaske 1 fra springen
//Fylle flaske 2 fra springen
//Tømme flaske 1 i flaske 2
//Tømme flaske 2 i flaske 1
//Fylle opp flaske 2 med flaske 1
//Fylle opp flaske 1 med flaske 2
//Tømme flaske 1 (kaste vannet)
//Tømme flaske 2 (kaste vannet)

//Run();



Console.ReadLine();