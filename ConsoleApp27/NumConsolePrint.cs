using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class NumConsolePrint : IPrint
    {
        private List<int> NumList { get; }
        public NumConsolePrint(List<int> numList)
        {
            this.NumList = numList;
        }
        public void Print(List<string> result)
        {
            if (NumList.Count != result.Count)
            {
                throw new ArgumentException("numListとfizzBuzzListの数が異なります。");
            }
            for (int i = 0; i < NumList.Count; i++)
            {
                Console.WriteLine($"{NumList[i]}:{result[i]}");
            }
        }
    }
}
