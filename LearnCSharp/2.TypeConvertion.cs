using System;

namespace LearnCSharp
{
    class ProgramI
    {
        static void TypeConvertion()
        {
            float? a, b, c;
            int result;
            Console.WriteLine("Enter The Value of A and B For Addition:");
            // Explict Type Convertion 
            // 1.
            a = Convert.ToInt32(Console.ReadLine()); // string to int32 "555" -> 555
            Console.WriteLine("A: {0}", a.GetType());
            b = Convert.ToInt32(Console.ReadLine());
            // 2. type define
            c = a + b;
            result = (int) c;
            Console.WriteLine("A + B: {0}", result);
            Console.WriteLine("Result Type: {0}", result.GetType());
            }
    }
}