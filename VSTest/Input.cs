using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTest
{
    class Input
    {
        public static string GetString(string prompt)
        {
            Console.Write(prompt);
            string? v = Console.ReadLine();
            if (v == null)
            {
                throw new Exception("Input.GetString(): You cannot have null strings here.");
            }
            else
            {
                string str_res = v;
                return str_res;
            }
        }

        public static int GetI32(string prompt)
        {
            Console.Write(prompt);
            int int_res = Convert.ToInt32(Console.ReadLine());

            return int_res;
        }

        public static long GetI64(string prompt)
        {
            Console.Write(prompt);
            long int_res = Convert.ToInt64(Console.ReadLine());
            return int_res;
        }

        public static float GetFloat(string prompt)
        {
            Console.Write(prompt);
            float fl_res = float.Parse(Console.ReadLine());
            return fl_res;
        }
    }
}
