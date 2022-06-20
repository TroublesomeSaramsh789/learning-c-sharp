using System;
namespace LearnCSharp
{
    class ProgramVIII
    {
        // function that exist inside a class is called a method.
        public int Add(int a, int b) 
        {return a + b ;}
        public int Subtract(int a, int b) 
        {return a - b;}
        public int Multiply(int a, int b)
        { return a * b;}
        public int Divide(int a, int b)
        {
            return a / b;
        }
        static public int Power(int a,int b) 
        {
            int value = a;
            if (b == 0) return 1;
            else
            {   for (int i = 1; i < b; i++)
                    value = value * a;
                return value;
            }
        }
        static void Main ()
        {
            ProgramVIII calculator = new ProgramVIII();
            Console.WriteLine("Add: {0}", calculator.Add(10,15));
            Console.WriteLine("Sub: {0}", calculator.Subtract(100, 15));
            Console.WriteLine("Mul: {0}", calculator.Multiply(10, 15));
            Console.WriteLine("Divide: {0}", calculator.Divide(15, 5));
            Console.WriteLine("Power: {0}", Power(2, 16));
        }
    }
}
