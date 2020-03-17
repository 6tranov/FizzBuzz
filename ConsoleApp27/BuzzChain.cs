using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class BuzzChain : Chain
    {
        protected override List<string> Done(int n, List<string> former)
        {
            former.Add("Buzz");
            return former;
        }

        protected override bool Solvable(int n)
        {
            return n % 5 == 0;
        }
    }
}
