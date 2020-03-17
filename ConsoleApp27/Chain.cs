using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    abstract class Chain
    {
        private Chain NextChain { get; set; }
        public Chain SetNext(Chain nextChain)
        {
            this.NextChain = nextChain;
            return this.NextChain;
        }
        public List<string> Support(int n, List<string> former)
        {
            if (Solvable(n))
            {
                former = Done(n, former);
            }

            if (NextChain != null)
            {
                former = NextChain.Support(n, former);
            }
            else if (!Solvable(n))
            {
                throw new NullReferenceException("Next chain is null");
            }
            return former;
        }
        protected abstract bool Solvable(int n);
        protected abstract List<string> Done(int n, List<string> former);
    }
}
