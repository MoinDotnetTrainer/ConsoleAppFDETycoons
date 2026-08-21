using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFDETycoons
{
    internal class Demo
    {
        public void Test() {
            Console.WriteLine("test fun");

            ClassExample obj = new ClassExample();  // memory allocation
            obj.Task();
        }
    }
}
