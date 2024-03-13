using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Menu
    {
        public string Title { get; set; }
        private int itemCount = 0;
        private MenuItems[] menuItemsArray;

        // The Constructor
        public Menu(int itemCount, string title)
        {
            this.itemCount = itemCount;
            this.Title = title;
            menuItemsArray = new MenuItems[this.itemCount];
        }

        public void AddMenuItem()
        {
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(i <= 0 ? "Type name of menu item: " : "Type name of next menu item: ");
                string menuItemName = Console.ReadLine();
                menuItemsArray[i] = new MenuItems(menuItemName);                    // som parameter via constructor i MenuItems
                //menuItemsArray[i] = new MenuItems() { Title = menuItemName };     // som værdi-tildeling direkte til felt i MenuItems (OBS: Public)
                //this.menuItemsArray[i].Title = menuItemName;                      // samme som ovenstående med anden syntaks
            }
            Console.WriteLine("\n You have succesfully created your menu: \nName: {0} \nItems: {1}", Title, itemCount);
        }

        public string SelectMenuItem()
        {
            Console.Write("Please select an item number: ");
            int.TryParse(Console.ReadLine(), out var menuItemNum);
            return menuItemNum <= itemCount ? "You selected: " + menuItemsArray[menuItemNum - 1].Title : "No such item number.";
        }

        public void Show()
        {           
            Console.WriteLine(this.Title + "\n");
            for (int i = 0; i < menuItemsArray.Length; i++)
            {
                Console.WriteLine($"{i + 1} " + menuItemsArray[i].Title);
            }
            // Ikke nødvendig, fordi menuen er ude i Program.Cs --- det kan flyttes her til Menu.cs med Show() som undermenu?
            //Console.WriteLine("\n(Tryk menupunkt eller 0 for at afslutte)");
        }
    }
}
