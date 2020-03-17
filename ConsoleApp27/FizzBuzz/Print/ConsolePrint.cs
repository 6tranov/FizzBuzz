using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class ConsolePrint : IPrint
    {
        public void Print(List<string> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
