using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.DomainLayer.Interfaces;

namespace ProductManagement.InfrastructureLayer.Repositories
{
    public class GenericRepository<T> : IProductRepository<T> where T : class
    {
        private readonly List<T> _items = new List<T>();
        public List<T> GetAll()
        {
            return _items;
        }
    }
}
