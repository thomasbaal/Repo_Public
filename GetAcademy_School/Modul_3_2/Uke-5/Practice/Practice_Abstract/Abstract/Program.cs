// egen practice oppgave.
// Todo bruke abstract virtual, override, 


using Abstract;
List<Animal> animals = new List<Animal>
{
new Dog("Waaaoooff !!","Labbetuss", "red", 22.34m, true),
new Cat("Meoooww !!","Pinky", "blue", 3.44m, false),
new Bird("Chiirps !!","Polly", "yellow", 1.12m, false),
};


foreach (var animal in animals)
{
    animal.MakeSound();
    Console.WriteLine($"{animal.Eat()}");
    animal.Something();
}


Console.ReadLine();