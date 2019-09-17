using Productos.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Api.DTOs.Responses
{
    public class ProductsDTO
    {
        public string Account { get; set; }
        public DateTime StartDate { get; set; }
        public Category Category { get; set; }
        //public string CategoryDescription { get; set; }
    }
}
