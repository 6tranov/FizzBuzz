using System;
using System.Collections.Generic;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            IInput input = new RangeInput(1, 210);

            Chain fizzChain = new FizzChain();
            Chain buzzChain = new BuzzChain();
            Chain numChain = new NumChain();
            Chain fooChain = new FooChain();
            Chain barChain = new BarChain();
            Chain reverseChain = new ReverseChain();
            fizzChain.SetNext(buzzChain).SetNext(fooChain).SetNext(reverseChain).SetNext(barChain).SetNext(numChain);

            IPrint print = new NumConsolePrint(input.InputNums);

            var fizzBuzz = new FizzBuzz(input, fizzChain, print);
            fizzBuzz.Do();
        }
    }
}
