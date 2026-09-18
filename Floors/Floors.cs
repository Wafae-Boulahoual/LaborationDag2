using System;
using System.Collections.Generic;
using System.Text;

namespace Floors
{
    public class FloorsFinder
    {
        public int FindFloor(string input)
        {
            int floor = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    floor++;
                }
                else
                {
                    floor--;
                }
            }

            return floor;
        }

        public int FindBasementPosition(string input)
        {
            int floor = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    floor++;
                }
                else
                {
                    floor--;
                }

                if (floor == -1)
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}
