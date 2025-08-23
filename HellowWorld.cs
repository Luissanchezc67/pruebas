// See https://aka.ms/new-console-template for more information
using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Hola mundo
            Console.WriteLine("Hello, World!");

            string myString = "Esto es una cadena de texto";
            Console.WriteLine(myString);

            int myInt = 42;
            myInt = myInt + 8;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine(myInt + myDouble + myFloat);

            dynamic myDynamic = 6;
            myDynamic = "Ahora soy una cadena de texto";
            Console.WriteLine(myDynamic);
        }
    }
}


