using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class SingleInput : IInput
    {
        public List<int> InputNums { get; }

        public SingleInput(int n)
        {
            InputNums = new List<int>() { n };
        }
    }
}
