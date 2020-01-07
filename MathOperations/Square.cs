using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    ////Square
    public class Square
    {


        public static double Sqr(double a,double b)
        {

            return Math.Pow(a,b);

        }

        public static int Sqr(int b)
        {
            int c = 0;

            c = Sqr(b);


            return c;
        }
    }
}
