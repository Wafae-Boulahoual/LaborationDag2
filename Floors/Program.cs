using Floors;

var path = Path.Combine(AppContext.BaseDirectory, "input2.txt");
var text = File.ReadAllText(path);
var floors = text.Trim();

var rightFloor = new RightFloor();
var floorNumber = rightFloor.GetFloorNumber(floors);
Console.WriteLine("Tomten står på våning : " + floorNumber);

var basementPosition = rightFloor.GetBasementPosition(floors);
Console.WriteLine("Tomten kommer till källaren på position : " + basementPosition);