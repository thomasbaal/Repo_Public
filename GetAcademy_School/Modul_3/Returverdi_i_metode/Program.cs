



using Returverdi_i_metode;

class program
    {
        
        static int customerNumber = 5435;
        static string customerInfo = "Kundenavn: Kåre Berntsen";
        static bool isCustomer = true;
        
        

        static void Main(string[] args)
        {
        Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);

        // "void" : signaliserer at den skal kjøre kommandoene inne i  parantesene, så skal den returnere.
        Console.WriteLine(customerInfo);

            int count = GetCounter();

            Console.WriteLine("count: " +count);

            var book1 = new Book("joakim");
            var book2 = new Book("labbetuss");

            //program.Main(["tekstinnihernå"]);

            //book1.Name = "Cindy";
            Console.WriteLine(book1.Name);   
            Console.WriteLine(book1.getName2());   
            


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

            



            Console.ReadLine();
        }
        // Vi ønsker å returner en int, da må vi bytte ut det void order..

        static int GetCustomerNumber()
        {
            return customerNumber;  
        }

        static int GetCounter()
        {
            int counter = 0;
            counter = counter + 5;
            return counter;
        }

        static bool getCustomerStatus()
        {
            return isCustomer;
        }

        


    }
