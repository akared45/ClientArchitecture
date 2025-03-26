using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.DomainLayer.Entities;

namespace ProductManagement.ApplicationLayer.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
