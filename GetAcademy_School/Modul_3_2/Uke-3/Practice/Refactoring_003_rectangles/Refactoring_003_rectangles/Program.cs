using static System.Console;
namespace Refactoring_003_rectangles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var rectangles = new List<Rectangle>();
            double sideA, sideB;
            sideA = sizes("Size of side - A ? ");
            sideB = sizes("Size of side - B ?");

            var rect = new Rectangle(sideA, sideB);

            var hypotenus = rect.CalcHypotenus(sideA, sideB);
            var newRect = new Rectangle(sideA, sideB);
            rectangles.Add(rect);

        }

        private static double sizes(string question)
        {
            WriteLine(question);
            var strSize = ReadLine();
            var newSize = Convert.ToDouble(strSize);
            return newSize;
        }

       
    }
}