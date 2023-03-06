using System.Reflection.Metadata;

namespace WebshopOOP
{
    internal class Menu
    {
        Data data = new();

        public void MainMenu()
        {
            Console.CursorVisible= false;
            List<string> list = new() { "Show products", "Show Customers"};
            switch (ShowMenu("\n*** Main Menu*** \n", list))
            {
                case 0: ShowProducts();
                    break;
                case 1: ShowCustomers();
                    break;
                default:
                    break;
            }
        }

        private void ShowCustomers()
        {
            throw new NotImplementedException();
        }

        private void ShowProducts()
        {
            List<string> prod = new();
            foreach (var item in data.Products)
                prod.Add(item.ToString());
            ShowMenu("SHOW PRODUCTS", prod);
        }

        public int ShowMenu(string Headline, List<string> menuItems)
        {
            //Shows list of menu items, and highlights selected item
            int selected = 0;
            while(true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine(Headline);

                foreach (var item in menuItems)
                {
                    if (menuItems.IndexOf(item) == selected)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.WriteLine(item);
                }

                ConsoleKey ck = Console.ReadKey().Key;

                if (ck == ConsoleKey.UpArrow)
                {
                    selected--;
                    if (selected < 0) selected = menuItems.Count-1;
                }
                else if (ck == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected >= menuItems.Count) selected = 0;
                }
                else if (ck == ConsoleKey.Enter || ck == ConsoleKey.Spacebar) return selected;

            }

        }

    }
}
