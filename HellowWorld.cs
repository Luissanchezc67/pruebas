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

            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine(myInt + myDouble + myFloat);

            dynamic myDynamic = 6;
            myDynamic = "Ahora soy dinamico ";
            Console.WriteLine(myDynamic);

            var myVar = "Hola, soy una variable var";
            Console.WriteLine(myVar);

            Console.WriteLine($"Presiona cualquier {myInt} tecla para continuar... {myBool}");
        }
    }
}


