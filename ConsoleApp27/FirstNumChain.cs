using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class FirstNumChain : Chain
    {
        protected override List<string> Done(int n, List<string> former)
        {
            former.Add($"{n.ToString()}:");
            return former;
        }

        protected override bool Solvable(int n)
        {
            return true;
        }
    }
}
