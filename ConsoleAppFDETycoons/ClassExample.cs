using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFDETycoons
{
    class ClassExample
    {
        // Methods();

        public void Add()
        {
            Console.WriteLine("Enter a number 1:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 2:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine($"Add is :{z}");
        }

        public void Sub()
        {
            Console.WriteLine("Enter a number 1:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 2:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x - y;
            Console.WriteLine($"Sub is :{z}");
        }

        public void Mul(int x, int y)
        {
            int z = x * y;
            Console.WriteLine($"Mul is :{z}");
        }

        public void Div(int x = 12, int y = 2)  // default value
        {
            int z = x / y;
            Console.WriteLine($"Div is :{z}");  // printing

        }

        public int fact()  // default value
        {
            int fact = 100;
            Console.WriteLine($"fact is :{fact}");  // print
            return fact; // returning
        }

        public float fact(float x, float y)  // default value
        {
            float fact = x / y;
            Console.WriteLine($"fact is :{fact}");  // print
            return fact; // returning
        }

        public string Name()
        {
            return "FDE Tycoons";
        }

        public byte GetByteValue()
        {
            return 255;
        }


        public void M1(int x)
        {

        }

        public void M2()
        { // var dynamic & object --> Arrays , Nullable as a method argument 

        }

        public void M3(int x, params int[] y)
        {
            Console.WriteLine("X:" + x);
            foreach (var item in y)
            {
                Console.WriteLine("Y:" + item);
            }
        }


        // Method Overloading   
        // hands Multi tasking --> Typing ,Eating, cutting, batting , bowling

        public void Task()
        {
            Console.WriteLine("Task 1");
        }
        public void Task(int x)
        {
            Console.WriteLine("Task 2");
        }
        public int Task(double x)
        {
            Console.WriteLine("Task 2");
            return 34;
        }
        public void Task(string x)
        {
            Console.WriteLine("Task 3");
        }

        public void Task(string x, string y)
        {
            Console.WriteLine("Task 4");
        }

        public void Task(int x, int y)
        {
            Console.WriteLine("Task 5");
        }
        public void Task(int x, string y)
        {
            Console.WriteLine("Task 6");
        }
        public void Task(string x, int y)  // obejct
        {
            Console.WriteLine("Task 7");
        }
        public static void MyTask()  // class name, single copy of memory
        {
            Console.WriteLine("My static method");
        }
    }

    static class Testing  // static class wont allow us to create an object
    {
        //Methods();
        public static void M1()
        {   // classname

        }
        public static void M2()
        {   // Access , object

        }
    }
    class Orders { }
    class prpducts { }
}
