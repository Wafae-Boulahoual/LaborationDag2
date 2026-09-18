using System.Text;

namespace Elves
{
    public class Sequences
    {
        public string CountSameChifres(int[] number)
        {
            var result = new StringBuilder();
            // string result = "";

            for (int i = 0; i <= number.Length - 1; i++)
            {
                int count = 1;

                //while (i < number.Length - 1 && number[i] == number[i + 1])
                //{
                //    count++;
                //    i++;
                //}
                result.Append(count).Append(number[i]);
                //  result += new StringBuilder().Append(count).Append(number[i]).ToString();
            }
            return result.ToString();
        }
    }
}