using System;

namespace LearnCSharp
{
    class ProgramVI
    {
        static void TwoDArray()
        {
            //take array size from user
            Console.WriteLine("Enter the Size of the Array Row and Column:");
            int sizeI = Convert.ToInt32(Console.ReadLine()); //row
            int sizeII = Convert.ToInt32(Console.ReadLine()); //column

            //to create array
            int[,] userArray = new int[sizeI,sizeII];

            //write array
            for (int i = 0; i < sizeI; i++)
            {
                for(int j=0; j<sizeII; j++){
                    Console.WriteLine("Enter the Value of the Array at {0}, {1}:", i + 1,j + 1);
                    userArray[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // read array
            Console.WriteLine("\n Array:");
            for (int i =0; i< userArray.GetLength(0); i++)
            {
                for (int j = 0; j < userArray.GetLength(1); j++)
                {
                    Console.Write("{0} \t", userArray[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
