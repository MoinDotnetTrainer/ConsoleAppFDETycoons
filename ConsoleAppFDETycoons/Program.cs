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

            Datatypes dt = new Datatypes();
            dt.Parse();

        }


    }
}
