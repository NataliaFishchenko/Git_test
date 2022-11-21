using CSharpOOP2;

var tableWhite = new Table();
tableWhite.Color = "White";
tableWhite.Height = 70;
tableWhite.Material = "Wood";
tableWhite.IsForKitchen = false;
//tableWhite.Length = 150; //error Line, no access to a private field
tableWhite.Width = 50;

var tableBraun = new Table {Color = "Braun", Height = 50, Material = "Wood", IsForKitchen = true};

var tableBlack = new Table("Black", 40, "Iron", false);

var tableIron = new Table {Height = 50, Material ="Iron", IsForKitchen = false};

Table.TaskForYou(); //call a static method

tableBlack.RoomForTable();

//tableIron.RoomForTable(); //error Line because Color = null

tableWhite.AddShelves = 3;
//var numberShelves = tableWhite.AddShelves; //error line, no read access

var priceForShelves = tableBraun.PriceForShelves;
//tableBraun.PriceForShelves = 135; //error line, no write access

Console.WriteLine(tableWhite.State); //call a field with default setting
Console.ReadLine();

var type = Table.Type; //call a static field







