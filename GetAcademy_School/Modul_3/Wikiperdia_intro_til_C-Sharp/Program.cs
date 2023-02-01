

using System.Security.Cryptography.X509Certificates;

namespace Giraffe
{
    class program
    {
        static void Main(string[] args)
        {

            /*
             int: the int data type can store whole numbers from -2147483648 to 2147483647, int is the preferred datatype when we create variables with a numeric value.
            long: the long data type can store whole numbers from -9223372036854775808 to 9223372036854775807. used when "int" is not big enough to store the value.-- end value with L
            float: use floating point values whenever you need a number with a decimal, such as 9.99 or 3.14515. -- end value withF
            decimal: use this when calculation needs to be highly accurate -- end value with M.
            double:  double has the precisicion of about 15 digits -- most used when involving decimals -- end value with D.
            string: must be srurrounded by double quotes -- "Hello Wworld" etc.
            char: used to store a single character -- surround character with quotes -- 'A', 'B' etc.
            bool: only takes the values true or false.

            Arrays: int[] tallarray = {1, 2, 3};
             */
            
            
            int a = 5434534;
            long b = 1543243423422342342L;
            float c = 10F;
            decimal e = 2.34M;
            double d = 2.34D;
            string text = "Hello World";
            char charTest = 'G';
            bool trueOrFalse = true;
            // Arrays.
            int[] arrNums = { 1, 2, 3, 4, 5, 6, };
            string[] arrStrings = { "apple", "orange" };
            decimal[] arrDecimals = { 2.3m, 4, 5m, 7, 3m };
            double[] arrDoubles = { 2, 653d, 5, 321d };

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(text);
            Console.WriteLine(charTest);
            Console.WriteLine(trueOrFalse);

            Console.WriteLine(arrNums[0]);
            Console.WriteLine(arrStrings[0]);
            Console.WriteLine(arrDecimals[0]);
            Console.WriteLine(arrDoubles[0]);


            // enkle funksjoner

            int storeValue = DenneFunksjonenReturnererEtHelTall();
            Console.WriteLine(storeValue);

            Console.WriteLine(DenneFunksjonenReturnererEtHelTall());

            int a1 = 5;
            decimal b1 = 3.0m;

            decimal sum = a1 + b1;
            decimal sum2 = a1 * b1;
            Console.WriteLine("sum: " +sum);
            Console.WriteLine("sum2: " +sum2);





            Console.ReadLine();
        }

            static  void DenneFunksjonenReturnererIngenting()
            {
                return;
            }

            static int DenneFunksjonenReturnererEtHelTall()
            {
                Console.WriteLine("returnerer ett tall");
                int someNumber = 26;
                return someNumber;
            }

            static int DenneFunksjonenTarInnToTall(int input1, int input2)
            {
                return input1 + input2; 
            }
            
          
            
    }
}
