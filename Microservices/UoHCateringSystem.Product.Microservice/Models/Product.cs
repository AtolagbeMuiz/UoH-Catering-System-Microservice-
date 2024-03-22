using System;

namespace UoHCateringSystem.Product.Microservice.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
        public double Amount { get; set; }
    }
}
