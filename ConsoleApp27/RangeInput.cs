using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class RangeInput : IInput
    {
        public List<int> InputNums { get; }
        public RangeInput(int first, int length)
        {
            InputNums = new List<int>();
            for (int i = first; i <= first + length; i++)
            {
                InputNums.Add(i);
            }
        }
    }
}
