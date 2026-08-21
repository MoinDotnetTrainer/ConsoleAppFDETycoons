using System.Threading.Channels;

namespace ConsoleAppFDETycoons
{
    internal class Program
    {
        static void Main(string[] args)// Entry point of an app
        {
            System.Console.WriteLine("Hello, World!");


            //Demo d = new Demo();  // creating an instance(object)
            //d.Test();
            //Sample s = new Sample();
            //s.Getdatetime();

            //Datatypes dt = new Datatypes();
            //dt.Parse();
            ClassExample obj = new ClassExample();
            //obj.Add();
            //obj.Sub();
            // obj.Mul(13,2);
            //obj.Mul(34,2); // x = 34, y = 2
            //obj.Mul(y:2,x:100);  // x = 100, y = 2    // Named Argument


            //obj.Div();
            //obj.Div(100,2);  // 50


            //obj.fact(); //100
            //int res = obj.fact();//100
            //if (res == 100)
            //{
            //    Console.WriteLine("DO this task");
            //}
            //else
            //{
            //    Console.WriteLine("DO that task");
            //}


            //int[] arr = { 34};
            //obj.M3(12,arr);
            //obj.M3(100,arr);
            //obj.M3(123);


            obj.Task();
            obj.Task(12);
            obj.Task("HI");

            ClassExample.MyTask();

        }


    }
}
