using System;
using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {   
        Guid myGuid = new Guid();

        for (int i = 1; i <= 10; i++) 
        {
            myGuid = Guid.NewGuid();

            Console.WriteLine(myGuid.ToString());

        }


        Console.ReadKey();
    }
}

