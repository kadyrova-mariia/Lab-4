using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_4
{
    internal class DynamicProgramming
    {
        public long CountWaysToGiveChange(int n, int[] coins)
        {
            long[] dp = new long[n + 1];
            dp[0] = 1;

            for (int i = 0; i <= n; i++)
            {
                foreach (int coin in coins)
                {
                    if (i >= coin)
                    {
                        dp[i] += dp[i - coin];
                    }
                }
            }

            return dp[n];
        }
    }
}


