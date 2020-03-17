using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class FizzBuzz
    {
        IInput Input { get; set; }
        Chain Chain { get; set; }
        IPrint Printer { get; set; }
        public FizzBuzz(IInput input, Chain chain, IPrint printer)
        {
            this.Input = input;
            this.Chain = chain;
            this.Printer = printer;
        }
        public void Do()
        {
            var result = new List<string>();
            foreach (var item in Input.InputNums)
            {
                var fizzBuzz = new List<string>();
                result.Add(string.Join("", Chain.Support(item, fizzBuzz)));
            }
            Printer.Print(result);
        }
    }
}
