using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Productos.Api.DTOs.Responses;
using Productos.Api.Models;

namespace Productos.Api.Mapping
{
    public class ModelToResponseProfile: Profile
    {
        public ModelToResponseProfile()
        {
            CreateMap<Products, ProductsDTO>();
        }
    }
}
