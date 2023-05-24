using System;
using System.Collections.Generic;
using System.Text;

namespace MassiveParallel
{
    public class Caluclator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        public void Verfiynumber(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine("Given number is Even");
            else
                Console.WriteLine("Given number is Odd");
        }
        public void Verfiyhighestnumber(int a, int b, int c)
        {
            if (a > b && a > c)
                Console.WriteLine("A value is bigger than B,C");
            if (b > a && b > c)
                Console.WriteLine("B value is bigger than A,C");
            if (c > a && c > b)
                Console.WriteLine("C value is bigger than A,B");
        }
        
        public void UncoveredTest(int a, int b)
        {
        if(a>b)
             Console.WriteLine("A value is bigger than B");
         else
             Console.WriteLine("A value is smaller than B");
        }
         public int coveredTest(int a, int b)
        {
             return a + b;
        }

    }
}
