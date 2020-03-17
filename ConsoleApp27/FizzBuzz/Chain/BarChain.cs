using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class BarChain : Chain
    {
        protected override List<string> Done(int n, List<string> former)
        {
            return new List<string>() { "Bar" };
        }

        protected override bool Solvable(int n)
        {
            return n % 13 == 0;
        }
    }
}
