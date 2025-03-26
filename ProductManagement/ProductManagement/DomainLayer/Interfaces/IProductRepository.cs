using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DomainLayer.Interfaces
{
    public interface IProductRepository<T> where T : class
    {
        List<T> GetAll();
    }
}
