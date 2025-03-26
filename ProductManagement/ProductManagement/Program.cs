using ProductManagement.ApplicationLayer.DTOs;
using ProductManagement.ApplicationLayer.Services;
using ProductManagement.DomainLayer.Entities;
using ProductManagement.DomainLayer.Interfaces;
using ProductManagement.InfrastructureLayer.Repositories;
using ProductManagement.PresentationLayer;

namespace ProductManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new GenericRepository<Product>();
            var service = new ProductServices(repository);
            var menu = new MenuConsole(service);
            menu.ShowMenu();
        }
    }
}
