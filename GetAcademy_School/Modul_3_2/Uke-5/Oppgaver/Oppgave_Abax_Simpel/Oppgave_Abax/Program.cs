using Oppgave_Abax;

// formålet med oppgaven er at vi skal bruke abstract og protected.
//bil 1 med reg.nr NF123456, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy. 

// bil 2 med reg. nr NF654321, 150kw effekt, maksfart 195km/t, blå farge og av typen lett kjøretøy 

// kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly 

//båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.




// hva er felles ? alle har : kjennetegn, effekt
// lage da en base klasse med de 2 verdiene


// unikt : fly har ikke maksfart.

//bilene har farge

var bil1 = new Car("NF123456", 147, 200, "green", true);
var bil2 = new Car("NF654321", 150, 195, "blå", true);
var fly = new Plane("LN1234", 1000, 30, 2, 10, "Jetfly", "Tonn");
var båt = new Boat("ABC123", 100, 30, "Knop", 500);

Console.WriteLine("-");
//bil2.PrintInformation();
båt.PrintInformation();
bil2.Run();
fly.Run();
båt.Run();




Console.ReadLine();
//var bil2 = new Bil("NF654321", 150, 195, "blå");

//var fly1 = new Fly("LN1234", 1000, 30,2, 1000);



