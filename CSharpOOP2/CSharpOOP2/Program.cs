using CSharpOOP2;

var tableWhite = new Table();
tableWhite.Color = "White";
tableWhite.Height = 70;
tableWhite.Material = "Wood";
tableWhite.IsForKitchen = false;
//tableWhite.Length = 150; //Error Line
tableWhite.Width = 50;

var tableBraun = new Table {Color = "Braun", Height = 50, Material = "Wood", IsForKitchen = true};

var tableBlack = new Table("Black", 40, "Iron", false);

var tableIron = new Table {Height = 50, Material ="Iron", IsForKitchen = false};

Table.TaskForYou();

tableBlack.RoomForTable();

//tableIron.RoomForTable(); //Error Line because Color = null

tableWhite.AddShelves = 3;
//var numberShelves = tableWhite.AddShelves; //Error Line

var priceForShelves = tableBraun.PriceForShelves;
//tableBraun.PriceForShelves = 135; //Error line

Console.WriteLine(tableWhite.State);

var type = Table.Type; //вызов статического поля







