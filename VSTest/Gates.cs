using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTest
{
    class IntGate
    {
        public static int Land(int a, int b)
        {
            if (a == 1 && b == 1)
            {
                return 1;
            }
            else if (a == 1 && b == 0)
            {
                return 0;
            }
            else if (a == 0 && b == 1)
            {
                return 0;
            }
            else if (a == 0 && b == 0)
            {
                return 0;
            }
            else
            {
                throw new Exception("IntGate.Land(): Only 1s and 0s are allowed.");
            }
        }

        public static int Lor(int a, int b)
        {
            if (a == 1 && b == 1)
            {
                return 1;
            }
            else if (a == 1 && b == 0)
            {
                return 1;
            }
            else if (a == 0 && b == 1)
            {
                return 1;
            }
            else if (a == 0 && b == 0)
            {
                return 0;
            }
            else
            {
                throw new Exception("IntGate.Lor(): Only 1s and 0s are allowed.");
            }
        }

        public static int Lnot(int a)
        {
            if (a == 1)
            {
                return 0;
            }
            else if (a == 0)
            {
                return 1;
            }
            else
            {
                throw new Exception("IntGate.Lnot(): Only 1s or 0s are allowed.");
            }
        }
    }

    class BoolGate
    {
        public static bool Land(bool a, bool b)
        {
            if (a == true && b == true)
            {
                return true;
            }
            else if (a == true && b == false)
            {
                return false;
            }
            else if (a == false && b == true)
            {
                return false;
            }
            else if (a == false && b == false)
            {
                return false;
            }
            else
            {
                throw new Exception("BoolGate.Land(): Only true and false are allowed.");
            }
        }

        public static bool Lor(bool a, bool b)
        {
            if (a == true && b == true)
            {
                return true;
            }
            else if (a == true && b == false)
            {
                return true;
            }
            else if (a == false && b == true)
            {
                return true;
            }
            else if (a == false && b == false)
            {
                return false;
            }
            else
            {
                throw new Exception("BoolGate.Lor(): Only true and false are allowed.");
            }
        }

        public static bool Lnot(bool a)
        {
            if (a == true)
            {
                return false;
            }
            else if (a == false)
            {
                return true;
            }
            else
            {
                throw new Exception("IntGate.Lnot(): Either true OR false are allowed.");
            }
        }
    }
}
