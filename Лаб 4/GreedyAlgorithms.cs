using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_4
{
    internal class GreedyAlgorithms
    {
        public List<int> getPossiblePowers(int number)
        {
            List <int> result = new List<int>();
            for (int i = 0; i <= number; i+=2)
            {
                int power = Convert.ToInt32(Math.Pow(2, i));
                if (number >= power)
                {
                    result.Add(power);
                }
                else
                {
                    result.Sort();
                    result.Reverse();
                    return result;
                }
            }
            return result;
        }

        public List<int> DecomposeIntoPowersOfTwo(int number)
        {
            List<int> powers = getPossiblePowers(number);
            List<int> result = new List<int>();

            while (number != 0) 
            {
                for (int i = 0; i < powers.Count; i++)
                {
                    if (number - powers[i] >= 0) 
                    {
                        result.Add(powers[i]);
                        number -= powers[i];
                        break;
                    }
                }
            }

            return result;
        }
    }
}
