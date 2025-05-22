using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            MyClass classInstance = new MyClass();
            classInstance.change = "не изменено";

            MyStruct structInstance = new MyStruct();
            structInstance.change = "не изменено";

            Notebook myNotebook = new Notebook("Aspire 7", "Acer", 55000.99m);

            Console.WriteLine("До вызова методов:");
            Console.WriteLine("MyClass: " + classInstance.change);
            Console.WriteLine("MyStruct: " + structInstance.change);

            ClassTaker(classInstance);
            StruktTaker(structInstance);

            Console.WriteLine("\nПосле вызова методов:");
            Console.WriteLine("MyClass: " + classInstance.change);
            Console.WriteLine("MyStruct: " + structInstance.change);

            Console.WriteLine("\nИнформация о ноутбуке:");
            myNotebook.DisplayInfo();

            Console.ReadLine();
        }
    }
}