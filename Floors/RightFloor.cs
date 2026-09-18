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
    }
}
