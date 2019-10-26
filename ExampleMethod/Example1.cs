using System;

namespace ExampleMethod
{
    public class Example1
    {
        public static bool Calcolo1()
        {
            double n = 1.0 / 10.0;
            double somma = n + n + n + n + n + n + n + n + n + n;
            if (somma == 1)
                return true;
            else
            return false;
        }
    }
}
