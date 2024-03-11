using Exercise_5;

Console.WriteLine("What is the name of the menu?");
string menuTitle = Console.ReadLine();
Console.WriteLine("How menu items are on the menu?");
int.TryParse(Console.ReadLine(), out var numMenuItems);

Menu newMenu = new Menu(numMenuItems, menuTitle);

newMenu.SetItems();
newMenu.Show();
