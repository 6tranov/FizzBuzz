using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class NumChain : Chain
    {
        protected override List<string> Done(int n, List<string> former)
        {
            if (former.Count == 0)
            {
                former.Add(n.ToString());
            }
            return former;
        }

        protected override bool Solvable(int n)
        {
            return true;
        }
    }
}
