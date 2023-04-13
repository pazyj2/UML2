using System;
using System.Collections.Generic;

namespace UML2
{
    public static class PizzaCatalog
    {
        static List<Pizza> Pizzas = new List<Pizza>();
        static Pizza CreateNewPizza()
        {
            Pizza PizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("| Create A New Pizza Item |");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.Write("Enter name: ");
            PizzaItem.Name = Console.ReadLine();

            string input = "";
            Console.Write("Enter price: ");

            Random rnd = new Random();

            PizzaItem.Id = rnd.Next(1000);

            try
            {
                input = Console.ReadLine();
                PizzaItem.Price = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            Pizzas.Add(PizzaItem);
            return PizzaItem;
        }
        static void DeletePizza()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| DELETE MENU ITEM |");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            if (Pizzas.Count == 0)
            {
                Console.WriteLine("There is no Pizzas in the menu!");
            }
            else
            {
                var i = 0;

                foreach (var item in Pizzas)
                {
                    Console.WriteLine($"{i++}. Name: {item.Name} - Price: {item.Price}");
                }


                string input = "";
                int index;

                Console.WriteLine();
                Console.Write("Enter the number of the item you wish to remove: ");

                try
                {
                    input = Console.ReadLine();
                    index = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                    throw;
                }

                Pizzas.RemoveAt(index);
            }
        }
        static void UpdatePizza()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("| Update A Pizza Item |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            var i = 0;

            if (Pizzas.Count == 0)
            {
                Console.WriteLine("There is no Pizzas in the menu!");
            }
            else
            {
                foreach (var item in Pizzas)
                {
                    Console.WriteLine($"{i++}. Name: {item.Name} - Price: {item.Price}");
                }

                string input = "";
                int index;

                Console.WriteLine();
                Console.Write("Enter the number of the item you wish to update: ");

                try
                {
                    input = Console.ReadLine();
                    index = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                    throw;
                }

                var selectedPizza = Pizzas[index];

                Console.Write("Enter name: ");
                selectedPizza.Name = Console.ReadLine();

                Console.Write("Enter price: ");
                var price = Int32.Parse(Console.ReadLine());
                selectedPizza.Price = price;

                Console.WriteLine();
                Console.WriteLine($"The chosen pizza has been update to Name: {selectedPizza.Name} - Price: {selectedPizza.Price}");
            }
        }
        static void SearchPizza()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("| SEARCH FOR MENU ITEM |");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            if (Pizzas.Count == 0)
            {
                Console.WriteLine("There is no Pizzas in the menu!");
            }
            else
            {
                string input = "";

                Console.Write("Enter the name: ");
                try
                {
                    input = Console.ReadLine().ToLower();
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                    throw;
                }


                foreach (var item in Pizzas)
                {
                    if (item.Name.ToLower().Contains(input))
                    {
                        Console.WriteLine();
                        Console.WriteLine(item);
                    }
                }
            }
        }
        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("| PIZZA MENU |");
            Console.WriteLine("--------------");
            Console.WriteLine();

            var i = 0;

            if(Pizzas.Count == 0)
            {
                Console.WriteLine("There is no Pizzas in the menu");
            } else
            {
                foreach (var item in Pizzas)
                {
                    Console.WriteLine($"{i++}. Name: {item.Name} - Price: {item.Price} kr.");
                }
            }

        }
        static int menuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("| PIZZA MENU APP |");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine();
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.WriteLine();
            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
        static public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "0. Create A Pizza",
                "1. Delete A Pizza",
                "2. Update A Pizza",
                "3. Search For A Pizza",
                "4. Display The Pizza Menu",
            };

            while (proceed)
            {
                int MenuChoice = menuChoice(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 0:
                        try
                        {
                            Pizza pizza = CreateNewPizza();
                            Console.WriteLine($"You created: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza created");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 1:
                        DeletePizza();
                        Console.WriteLine();
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        UpdatePizza();
                        Console.WriteLine();
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        SearchPizza();
                        Console.WriteLine();
                        Console.Write("Hit any key to continue");
                        Console.ReadKey(); ;
                        break;
                    case 4:                       
                        PrintMenu();
                        Console.WriteLine();
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}