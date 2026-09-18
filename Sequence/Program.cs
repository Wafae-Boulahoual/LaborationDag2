using Elves;

int[] number = { 1, 1, 1, 3, 2, 2, 2, 1, 1, 3 };

var result = new Sequences();

for (int i = 0; i < 40; i++)
{
    var theNumber = result.Step(number).ToCharArray();
    number = theNumber.Select(x => int.Parse(x.ToString())).ToArray();
}

Console.WriteLine(number.Length);