using Floors;

string path = Path.Combine(AppContext.BaseDirectory, "input.txt");
string input = File.ReadAllText(path).Trim();

var result = new FloorsFinder();

int finalFloor = result.FindFloor(input);
//int basementPosition = result.FindBasementPosition(input);

Console.WriteLine(finalFloor);
