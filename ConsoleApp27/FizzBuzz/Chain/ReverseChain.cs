using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class ReverseChain : Chain
    {
        protected override List<string> Done(int n, List<string> former)
        {
            former.Reverse();
            return former;
        }

        protected override bool Solvable(int n)
        {
            return n % 2 == 0;
        }
    }
}
