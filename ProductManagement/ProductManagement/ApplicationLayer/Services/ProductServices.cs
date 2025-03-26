using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.ApplicationLayer.DTOs;
using ProductManagement.ApplicationLayer.Interfaces;
using ProductManagement.DomainLayer.Entities;
using ProductManagement.DomainLayer.Interfaces;
using ProductManagement.InfrastructureLayer.Repositories;

namespace ProductManagement.ApplicationLayer.Services
{
    public class ProductServices : IProductService
    {
        private readonly IProductRepository<Product> _productRepository;
        public ProductServices(IProductRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
