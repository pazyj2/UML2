using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    public class Store
    {
        public void Start()
        {
            Test();
        }

        public void Test()
        {
            //MenuCatalog menuCatalog = new MenuCatalog();

            //Pizza p1 = new Pizza(70, "Margherita", 72);
            //Pizza p2 = new Pizza(65, "peperori", 78);
            //Pizza p3 = new Pizza(80, "Calzone", 83);
            

            ////Adding Pizzas To Menu

            //menuCatalog.CreatePizza(p1);
            //menuCatalog.CreatePizza(p2);
            //menuCatalog.CreatePizza(p3);

            ////Reading Pizzas in menu

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("| Pizza Menu Before Crud Operations |");
            //Console.WriteLine("---------------------------------\n");

            //Console.WriteLine(menuCatalog.ReadPizza(70));
            //Console.WriteLine(menuCatalog.ReadPizza(65));
            //Console.WriteLine(menuCatalog.ReadPizza(80));

            ////Updating Pizzas in menu

            //menuCatalog.UpdatePizza(65, p2);

            ////Deleting pizzas in menu

            //menuCatalog.DeletePizza(p2);

            //Console.WriteLine("\n------------------------------------");
            //Console.WriteLine("| Pizza Menu After Crud Operations |");
            //Console.WriteLine("------------------------------------\n");

            //menuCatalog.PrintMenu();

            //Console.WriteLine(menuCatalog.SearchPizza("Magherita"));

            PizzaCatalog.Run();
        }
    }
}
