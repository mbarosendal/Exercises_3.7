using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Menu
    {
        public string Title { get; set; }
        private int itemCount = 0;
        private MenuItems[] menuItemsArray;

        // The constructor
        public Menu(int itemCount, string menuTitle)
        {
            this.itemCount = itemCount;
            Title = menuTitle;
            menuItemsArray = new MenuItems[this.itemCount];
        }

        public void SetItems()
        {
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(i <= 0 ? "Type name of menu item: " : "Type name of next menu item: ");
                string menuItemName = Console.ReadLine();
                menuItemsArray[i] = new MenuItems();
                this.menuItemsArray[i].Title = menuItemName;
            }
        }

        public void Show()
        {
            Console.Clear();
            
            Console.WriteLine(this.Title + "\n");
            for (int i = 0; i < menuItemsArray.Length; i++)
            {
                Console.WriteLine($"{i + 1} " + this.menuItemsArray[i].Title);
            }

            Console.WriteLine("\n(Tryk menupunkt eller 0 for at afslutte)");
        }
    }
}
