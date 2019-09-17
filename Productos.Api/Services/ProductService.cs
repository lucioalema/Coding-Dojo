using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productos.Api.Data;
using Productos.Api.Models;

namespace Productos.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ProductService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Products>> GetAllAsync()
        {
            return await _applicationDbContext.Products.ToListAsync();
        }
    }
}
