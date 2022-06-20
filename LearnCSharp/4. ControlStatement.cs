using System;

namespace LearnCSharp
{    class ProgramIII
    {        static void Control()
        {
            int a = 1, b = 1;
            // Conditional Statement
            if(a > b)
            {
                Console.WriteLine("{0} is More than {1}",a,b);
            }
            else if(a < b)
            {
                Console.WriteLine("{1} is More than {0}", a, b);
            }
            else
                Console.WriteLine("{0} is equal {1}", b, a);


            switch(b > a)
            {
                case true:
                    Console.WriteLine("{1} is More than {0}", a, b);
                    break;

                case false:
                    Console.WriteLine("{0} is More than {1}", a, b);
                    break;

                default:
                    Console.WriteLine("{0} is equal {1}", b, a);

            }
        }
    }
}