using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFDETycoons
{
    internal class Datatypes
    {
        public void ExonDataTypes()
        {
            Console.WriteLine("Datatypes ex here");

            // Datatypes in c# 
            // Java , C ,C++


            // Interger 
            // byte short int long
            // sbyte byte short ushort int uint long ulong
            // 1 2 4 8
            // 1 byte = 255


            // signed , Unsigned
            byte b = 255;  // unsiged +ve
            sbyte sb = 127; // signed -+ve

            // floating 
            // float double decimal
            float f = 34.43f;
            double d = 435.4;
            decimal dm = 34.54m;

            // char 
            char c = 'A';

            string str = "hello world";

            bool status = false;




        }


        public void ReadLine()
        {
            Console.WriteLine("Enter Ur name");
            string Uname = Console.ReadLine();// run time like scanf
            Console.WriteLine($"U have Entered : {Uname}");

            Console.WriteLine("Age");
            byte Age = Convert.ToByte(Console.ReadLine());
            //123 ="123"
            // convertion tech
            Console.WriteLine($"My Age is {Age}");

            sbyte sb = Convert.ToSByte(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());


            int x1 = Convert.ToByte(Console.ReadLine());
            // 123 
            //23434 -255 -- runtime

        }

        public void Parse()
        {
            string str = null;
            int res = Convert.ToInt32(str);  // convertion
            int res1 = int.Parse(str); // parse tech
            Console.WriteLine(res);  // 0 
            Console.WriteLine(res1); // error

            // how to handle raised error in parsing 
        }

        public void OtherDatatypes()
        {
            // boxing & Unboxing

            // value type 
            // reference type

            // other categiroes --> var dynamic & object


            // compile time
            // type dedcides at compile time
            var v = 32; // int
            v = 345;
            v = 5;
            v = 46;
            // v = 234.46; // error here
            var v1 = "hello";
            var v2 = true;
            var v3 = 34.456;
            var v4 = 34;


            //runtime
            // value type
            dynamic d1 = 234;  // d1 as int
            d1 = "test"; // d1 as string
            d1 = true; // d1 as bool    
            dynamic d2 = "hello";
            dynamic d3 = true;
            dynamic d4 = 34;
            dynamic d5 = 234.35;
            dynamic result = d1 + d4;


            //ref type
            object o1 = 34;
            o1 = "test";
            o1 = 34.45;
            o1 = true;
            object o2 = "hello";
            object o3 = 3;
            object o4 = true;
            object o5 = 34.45;
            object res = (int)o1 + (int)o3;
            // +-*
        }

        public void Boxing()
        {
            // boxing value to ref
            // unbox ref to value
            int x = 34;
            object o = x;  // boxing , implict(auto)
            int x1 = (int)o;// unboxing ,explict(manual)
            int x2 = Convert.ToInt32(o);
        }

        public void Nullable()
        {
            string str = null;  // ref 
            // ref type datypes
            // string array , object  -- dynamic
            int? x = null; // value type
            bool? status = null;
            Nullable<float> f = null;
            // int float double decimal bool char   --> fixed

        }

        public void Arrays()
        {
            int[] arr = { 2345, 345, 45, 6 };
            int?[] arr1 = { 345, 456, null };

            // arr index will be zero
        }
    }
}
