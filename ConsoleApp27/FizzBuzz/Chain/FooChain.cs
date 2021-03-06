﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class FooChain : Chain
    {
        protected override List<string> Done(int n, List<string> former)
        {
            former.Add("Foo");
            return former;
        }

        protected override bool Solvable(int n)
        {
            return n % 7 == 0;
        }
    }
}
