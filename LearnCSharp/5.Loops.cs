using System;

namespace LearnCSharp
{
    class ProgramIV
    {
        static void Loops()
        {
            long a = Convert.ToInt64(Console.ReadLine());
            // for loop
            for(int i = 1; i<= a; i++)
            {
                Console.WriteLine("{0}. Hello Sameep", i);
            }

            // while
            int j = 1;
            while (j<=a)
            {
                Console.WriteLine("{0}. Hello Sameep", j);
                j+=1; // j = j + 1;
            }
        }
    }
}