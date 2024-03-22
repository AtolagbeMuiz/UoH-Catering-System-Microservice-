using System.Collections.Generic;
using UoHCateringServices.Repository;

namespace UoHCateringSystem.Product.Microservice.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Models.Product> listOfProducts;
        public List<Models.Product> getAllProducts()
        {
            return listOfProducts;
        }
    }
}
