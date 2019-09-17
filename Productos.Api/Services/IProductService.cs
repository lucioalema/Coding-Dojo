using Productos.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Api.Services
{
    public interface IProductService
    {
        Task<List<Products>> GetAllAsync();
    }
}
