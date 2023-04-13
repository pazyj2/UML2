using System;
using System.Collections.Generic;

namespace UML2
{

    class MenuCatalog
    {
        List<Pizza> pizzas;

        public MenuCatalog()
        {
            pizzas = new List<Pizza>();
        }

        public void CreatePizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }

        public Pizza ReadPizza(int id)
        {
            var indexOfPizza = pizzas.FindIndex(pizza => pizza.Id.Equals(id));

            return pizzas[indexOfPizza];
        }

        public void UpdatePizza(int id, Pizza pizza)
        {
            var selectedPizza = ReadPizza(id);


            selectedPizza.Name = pizza.Name;
            selectedPizza.Price = pizza.Price;
        }

        public void DeletePizza(Pizza pizza)
        {
            pizzas.Remove(pizza);
        }

        public void PrintMenu()
        {
            foreach (var p in pizzas)
            {
                Console.WriteLine($"ID: {p.Id} - Name: {p.Name} - Price: {p.Price}");
            }
        }

        public Pizza SearchPizza(string name)
        {

          foreach (var pizza in pizzas)
            {
                if (pizza.Name == name)
                {
                    return pizza;
                }
            }
            return null;
        }
    }
}
