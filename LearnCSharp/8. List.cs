using System;

namespace LearnCSharp
{
    class ProgramVII
    {
        static void List ()
        {
            // List and arrays are almost same things.
            // string [] names = { "ram", "shyam","gopal" }; 
            List<string> names = new List<string> {"gopal" };
            List<int> number = new List<int> { 1,2,3,4,5,6,7,8,9 };

            Console.WriteLine("\nBefore:");
            foreach (string a in names)
                Console.WriteLine("Hello {0}", a);

            names.Add("grishma"); // to add element from list
            names.Remove("gopal"); // to remove element from list
            names.RemoveAt(1); // to remove element at certain position in list
            number.Reverse(); // to reverse a list
            number.RemoveRange(2, 5); // to remove a range of list
            names.Count(); //to return the size of list

            foreach (string a in names)
                Console.WriteLine("Hello {0}", a);
            foreach (int a in number)
                Console.Write("{0} \t", a);
        }
    }
}
