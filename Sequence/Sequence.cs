using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Elves
{
    public class Sequences
    {
        public string Step(int[] number)
        {
            string result = "";

            for (int i = 0; i <= number.Length - 1; i++)
            {
                int count = 1;
                if (i == number.Length - 1)
                {
                    result += new StringBuilder().Append(count).Append(number[i]).ToString();
                    return result;
                }

                while (number[i] == number[i + 1])
                {
                    count++;
                    i++;
                    if (i == number.Length - 1)
                    {
                        result += new StringBuilder().Append(count).Append(number[i]).ToString();
                        return result;
                    }
                }

                result += new StringBuilder().Append(count).Append(number[i]).ToString();
            }

            return result;
        }
    }
}