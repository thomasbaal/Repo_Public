using System.Collections;
using static System.Console;

namespace IEnumarable_IEnumerator_Tutorials_Eu
{
    // 1. IEnumerable <T> for generic collections.
    // 2. IEnumerable for non generic collections.

    /// IEnumerable<T> contains a single method that you must implement when implementing this interface;
    /// GetEnumerator(), which returns an IEnumerator<T> object.
    /// The returned IEnumerator<T> provides the ability to iterate through the collection
    /// by exposing a current property that points at the object we are currently at in the collection.
    class Program
    {
         static void Main(string[] args)
         {  // Demo 1
             DogShelter dogShelter = new DogShelter();
             UseForEach(dogShelter);

            // Demo 2

         }

         public static void UseForEach(DogShelter dogShelter)
         {
             // foreach with a IEnumerator
             foreach (Dog dog in dogShelter) // will error on GetEnumerator if not using IEnumerator on class DogShelter.
             {
                 if (!dog.IsNaughtyDog)
                 {
                     dog.GiveTreat(2);
                 }
                 else
                 {
                     dog.GiveTreat(1);
                 }
             }


             WriteLine();
             foreach (var dog in dogShelter.LiDogs)
             {
                 if (!dog.IsNaughtyDog)
                 {
                     dog.GiveTreat(2);
                 }
                 else
                 {
                     dog.GiveTreat(1);
                 }
             }
         }

         static IEnumerable<int> GetCollection(int option)
         {
            // create a list of numbers an initialize it
            List<int> numbersList = new List<int>(){1,2,3,4,5};
            Queue<int> numbersQueue = new Queue<int>();
            // add values to the queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);
            return null;
         }


    }
   



}











////////////////////////////////////////////////////////////////////////////////////////
// Example of a generic collection.
// List with restrictions on what type of data-types that is allowed (string)

//List<string> animals = new List<string>();
//string animal1 = "cat";
//string animal2 = "dog";
//string animal3 = "horse";

//animals.Add(animal1); 
//animals.Add(animal2);
//animals.Add(animal3);
////////////////////////////////////////////////////////////////////////////////////////



////////////////////////////////////////////////////////////////////////////////////////
// Example of a non-generic collection -> 
//var arlist1 = new ArrayList();

//var arlist2 = new ArrayList()
//{
//    1, "Bill", " ", true, 4.5, null
//};

//int[] arr = { 100, 200, 300, 400 };

//Queue myQ = new Queue();
//myQ.Enqueue("Hello");
//myQ.Enqueue("World!");

//arlist1.AddRange(arlist2); //adding arraylist in arraylist 
//arlist1.AddRange(arr); //adding array in arraylist 
//arlist1.AddRange(myQ); //adding Queue in arraylist 
////////////////////////////////////////////////////////////////////////////////////////



////////////////////////////////////////////////////////////////////////////////////////
//listing the values -> we can use var here to determine data type on each iteration.
//foreach (var item in arlist1)
//{
//    Write(item.GetType() + " :");
//    Write(item + " ");
//    WriteLine("|");
//}
//// iterate with "object"
//foreach (object item in arlist1)
//{
//    Write(item.GetType() + " :");
//    Write(item + " ");
//    WriteLine("|");
//}
////////////////////////////////////////////////////////////////////////////////////////

//ReadLine();