using System;
using VSTest;

namespace VSTest {

    public class Program {
        public void TruthTable()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            int[] a = { 1, 1, 0, 0 };
            int[] b = { 1, 0, 1, 0 };

            Console.WriteLine("a      b     a^b    avb");

            for (int i = 0; i < a.Count(); i++)
            {
                Console.WriteLine("{0}      {1}      {2}      {3}", a[i], b[i], IntGate.Land(a[i], b[i]), IntGate.Lor(a[i], b[i]));
            }
            Console.ResetColor();
        }

        public static void Main(string[] args) {
            string name = Input.GetString("What is your name? ");

            int age = Input.GetI32("How old are you? ");

            Console.WriteLine($"Your name is {name}, you are {age} years old.");

            Console.ReadKey();
        }
    }
}

