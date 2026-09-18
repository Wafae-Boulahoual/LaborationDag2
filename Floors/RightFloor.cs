using System;
using System.Collections.Generic;
using System.Text;


namespace Floors
{
    public class RightFloor
    {
        public int GetFloorNumber(string floorNumberSimbol)
        {
            //string floorNumberSimbol = "(()(";
            char[] floorNumberChars = floorNumberSimbol.ToCharArray();
            int count = 0;

            foreach (char c in floorNumberChars)
            {
                if (c == '(')
                {
                    count++;
                }
                else if (c == ')')
                {
                    count--;

                }
            }
            return count;
        }
        public int GetBasementPosition(string floorNumberSimbol)
        {
            int count = 0;
            for (int i = 0; i < floorNumberSimbol.Length; i++)
            {
                if (floorNumberSimbol[i] == '(')
                {
                    count++;
                }
                else if (floorNumberSimbol[i] == ')')
                {
                    count--;
                }

                if (count == -1)
                { 
                return i + 1;
                }
            }
            return -1; 
        }
    }
}
