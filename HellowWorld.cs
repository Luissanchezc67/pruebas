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

            const string MyConst = "Soy una constante";
            Console.WriteLine(MyConst);

            var myArray = new string[] { "Hola", "que", "tal" };
            Console.WriteLine(myArray[0]);

            myArray[2] = "24";
            Console.WriteLine(myArray[2]);

            var myDictionary = new Dictionary<string, int>
            {
                {"uno", 1},
                {"dos", 2},
                {"tres", 3}
            };
            Console.WriteLine(myDictionary["dos"]);

            var myset = new HashSet<string> { "Hola", "que", "tal", "ole" };

            var myTuple = ("Hola", "que", "tal", "ole");
            Console.WriteLine(myTuple.Item1);


            //Bucles
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }
            foreach (var myItem in myset)
            {
                Console.WriteLine(myItem);
            }
            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }

            //flujos

            if (myInt == 10 && myBool == true)
            {
                Console.WriteLine("myInt es  10");
            }
            else if (myInt == 11 || myBool == false)
            {
                Console.WriteLine("myInt es 11");
            }
            else
            {
                Console.WriteLine("myInt no es 10 ni 11");
            }
            //fUnciones
            MyFunction();
            Console.WriteLine(MyFunctionWithReturn(5));

            //clases
            MyClass myClass = new MyClass("devolver");
            Console.WriteLine(myClass.MyProperty);
        }

        static void MyFunction()
        {
            Console.WriteLine("Hola desde mi funcion");
        }

        static int MyFunctionWithReturn(int param)
        {
            return 11 + param;
        }

        class MyClass
        {
            public string MyProperty { get; set; }

            public MyClass(string myProperty)
            {
                MyProperty = myProperty;
            }

           /* public void MyMethod()
            {
                Console.WriteLine("Hola desde mi metodo");
            }
              */
        }
    }

}


