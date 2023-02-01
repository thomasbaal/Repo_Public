using System.Diagnostics.Metrics;

class Program
{

    static int customerNumber = 543535;
    static string customerInfo = "Kundenavn: Kåre Berntsen";
    static bool isCustomer = true;


    static void Main(string[] args) // void signaliserer at den skal kjøre kommandoene inne i klammene men ikke returnere noe.
    {
        Console.WriteLine(customerInfo);
        var count = GetCounter();
        Console.WriteLine(count);
        var something = 0;
        var something2 = "";
        var something3 = 'a';
        var something4 = false;

        Console.WriteLine(GetCustomerStatus());

    }

    //definere data type
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

    static bool GetCustomerStatus()
    {
        return isCustomer;
    }



}