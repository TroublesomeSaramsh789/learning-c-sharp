using System;

namespace LearnCSharp
{
    class Program
    {
        static public void DataTypes()
        {
            // Data types and their Literals

            //Numbers 

            //Signed Number -ve to +ve

            short a = 5645; // 16bit  1 bit = 8 byte 10,000  -10,000 to 10,000 -> 20,000
            int b = 1654625656; // 32 bit
            long c = -565465656565565L; // l or L for long 64bit

            // Unsigned Numbers only +ve numbers

            ushort d = 5645; // 16bit  1 bit = 8 byte
            uint e = 1654625656; // 32 bit
            ulong f = 565465656565565L; // l or L for long

            //float numbers

            float g = 155565.564654F; // F or f 32 bit;
            double h = -5656.65656D; // d or D 64 bit;
                                     // For Precision
            decimal i = 56456456456456.464646564654M; // M for Decimal Value use it for precision

            // boolean
            bool j = true; // true or false

            // char
            char k = 't'; // char literal is ''. use single quote

            // string - array of char is call string.
            string name = "Hello World";

            Console.WriteLine("DATA TYPES:");
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(name);





        }
    }
}