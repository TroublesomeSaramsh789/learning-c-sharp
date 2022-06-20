using System;

namespace LearnCSharp
{
    class ProgramV
    {
        static void ArrayI()
        {
            //take array size from user
            Console.WriteLine("Enter the Size of the Array:");
            int size = Convert.ToInt32(Console.ReadLine());

            //to create array
            int[] userArray = new int[size];

            //write array
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the Value of the Array at {0}:", i + 1);
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // read array
            Console.WriteLine("\n Array:");
            foreach (int a in userArray)
                Console.WriteLine(a);
        }
    }
}
