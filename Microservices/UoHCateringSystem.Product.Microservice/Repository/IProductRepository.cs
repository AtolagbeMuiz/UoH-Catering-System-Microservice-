using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using UoHCateringSystem.Product.Microservice.Models;

namespace UoHCateringServices.Repository
{
    public interface IProductRepository
    {
        List<Product> getAllProducts();
    }
}
