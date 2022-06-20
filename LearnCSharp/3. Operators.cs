using System;

namespace LearnCSharp
{
    class ProgramII
    {
        static void Operators()
        {
            int a = 45454, b = 7587557, result;
            result = a + b;
            Console.WriteLine(result);
            result = a - b;
            Console.WriteLine(result);
            result = a * b;
            Console.WriteLine(result);
            result = a / b;
            Console.WriteLine(result);
            result = a % b;
            result = a++;
            Console.WriteLine(result);
            result = ++a;
            Console.WriteLine(result);

            //Logical Operations  >> << ^
            result = a | b; // | OR result =a;
            Console.WriteLine(result);
            result = a & b; // & AND result = b;
            Console.WriteLine(result);

            // Null Handling
            //1.
            int? c = null; // c = null
            Console.WriteLine("C = " + c);
            //2.
            int d = c ?? 10; // if c== null then d = 55; else d = c;
            Console.WriteLine("D = " + d);


        }
    }
}