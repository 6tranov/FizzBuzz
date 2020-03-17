using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class FizzChain : Chain
    {
        protected override List<string> Done(int n, List<string> former)
        {
            former.Add("Fizz");
            return former;
        }

        protected override bool Solvable(int n)
        {
            return n % 3 == 0;
        }
    }
}
