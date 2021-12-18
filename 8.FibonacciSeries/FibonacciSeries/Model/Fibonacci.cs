using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciSeries.Model
{
    public class Fibonacci
    {
        private readonly int[] memo;

        public Fibonacci() 
        {
            this.memo = new int[1001];
            this.memo[0] = 0;
            this.memo[1] = 1;
        }

        public int NormalFib(int level) 
        {
            if (level == 0) return 0;

            if (level == 1) return 1;

            return NormalFib(level - 1) + NormalFib(level - 2);
        }

        public int MemoFib(int level)
        {
            if (level == 0 || this.memo[level] != 0) return this.memo[level];

            this.memo[level] = MemoFib(level - 1) + MemoFib(level - 2);

            return this.memo[level];
        }
    }
}
