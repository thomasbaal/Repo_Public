using pp;
using static System.Console;


var car = new List<Car>
{
    new Car(
        "Subaru",
        "Outback",
        new DateTime(2020, 4, 5)),
     new Car(
        "Citroen",
        "Berlingo",
        new DateTime(1979, 3, 2)),
      new Car(
        "Toyota",
        "Avensis",
        new DateTime(2009, 1, 5)),
      new Car(
        "Kia",
        "Soul",
        new DateTime(2021, 7, 8)),
       new Car(
        "Mercedes",
        "Bens",
        new DateTime(2011, 1, 3)),
       new Car(
        "Dodge",
        "Challanger",
        new DateTime(2016, 4, 5)),
      new Car(
      "Mercedes",
      "E190",
      new DateTime(2005, 4, 5)),

};

//Select: With Linq !!!!!
var Brand = car.Select(c => c.Brand).ToList();


//Without Linq
var allBrandsx = new List<string>();
foreach (var cars in car)
{
    allBrandsx.Add(cars.Brand);
    WriteLine($"{cars.Brand}");


}

var BrandsWithLetterK = car.Where(c => c.Brand.ToLower().StartsWith("m")).ToList();
foreach (var cars in BrandsWithLetterK)
{
    WriteLine($"Brand: {cars.Brand}  Model: {cars.Model} ");
}

//var CarsProducedBefore2010 = car.FirstOrDefault(c => car.DateTime =< 2010);
var CarsProducedBefore2010 = car.Where(c => c.ProductionDate.Year <2010).ToList();

foreach (var c in CarsProducedBefore2010)
{
    WriteLine($"{c.Model} var produsert i {c.ProductionDate.Year}");
}
WriteLine();
ReadLine();