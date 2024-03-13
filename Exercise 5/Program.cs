using Exercise_3;

bool tryAgain = true;

// Bonusøvelse 3.3 --- udvid med undermenuer --- While-løkken (L15) kan flyttes til Menu.Cs med hvert metodekald der ender i en console clear og break; ud til ydre løkke
// These could be added as options in the switch.
// OBS: YOu can't show the menu or get items before the menu has been created --- Best to force user through menu name, number of items and adding items in order
Console.Write("What is the name of the menu? ");
string menuTitle = Console.ReadLine();
Console.Write("How menu items are on the \"{0}\" menu? ", menuTitle);
int.TryParse(Console.ReadLine(), out var numOfMenuItems);

Menu newMenu = new Menu(numOfMenuItems, menuTitle);
newMenu.AddMenuItem();

// Keeping user in the loop
while (tryAgain)
{
    Console.Clear();    
    Console.Write("\nWhat do you want to do? \n1) Show the menu \n2) Get an existing menu item \n3) Exit \n\nPlease select a number: ");
    int menuChoice = int.Parse(Console.ReadLine());

    switch (menuChoice)
    {
        // Show the menu
        case 1:
            Console.Clear();
            newMenu.Show();
            continue;
        // Get & Show an item name
        case 2:
            Console.Clear();
            Console.WriteLine(newMenu.SelectMenuItem());
            continue;
        // Close the program
        case 3:
            Console.Clear();
            Console.WriteLine("Thank you for using the service. You may close the program now.");
            tryAgain = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Please select a valid option.");
            continue;
    }
}
