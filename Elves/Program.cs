using Elves;
Console.WriteLine("Hello, World!");

int[] number = { 1, 3, 2, 1, 1, 3, 1, 1, 1, 2 };

var sequences = new Sequences();

//foreach (var num in theNumber)
//{
//    Console.Write(num);
//}


for (int i = 0; i < 40; i++)
{
    var result = sequences.CountSameChifres(number);
    number = result.Select(x => x - '0').ToArray();
}
Console.WriteLine(number.Length);