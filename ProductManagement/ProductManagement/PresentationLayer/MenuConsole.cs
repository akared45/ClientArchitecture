using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.ApplicationLayer.Interfaces;
using ProductManagement.ApplicationLayer.Services;
using ProductManagement.DomainLayer.Entities;

namespace ProductManagement.PresentationLayer
{
    public class MenuConsole
    {
        private readonly ProductServices _productServices;
        public MenuConsole(ProductServices productServices)
        {
            _productServices = productServices;
        }
        public void ShowMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n=== Product Management ===");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();
                HandleChoice(choice, ref running);
            }
        }
        private void HandleChoice(string choice, ref bool running)
        {
            switch (choice)
            {
                case "1":
                    //AddProduct();
                    break;

                case "2":
                    ViewProducts();
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
        private void ViewProducts()
        {
            var products = _productServices.GetAll();
            Console.WriteLine("\nProducts:");
            foreach (var p in products)
            {
                Console.WriteLine($"Name: {p.Name}, Price: {p.Price}, Desc: {p.Description}");
            }
            Console.WriteLine();
        }
    }
}
