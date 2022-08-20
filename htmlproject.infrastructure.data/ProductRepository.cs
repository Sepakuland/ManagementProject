using htmlproject.core.contracts;
using htmlproject.core.domain.Entities;
using htmlproject.infrastructure.ef;
using System;
using System.Collections.Generic;
using System.Linq;

namespace htmlproject.infrastructure.data
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyContext context;
        public ProductRepository(MyContext context)
        {
            this.context = context;
        }


        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public List<Product> Get()
        {
            return context.Products.ToList();
        }

        public void Sell(int id, int q)
        {
            Product p = context.Products.Find(id);
            p.Count = p.Count - q;
            context.SaveChanges();
        }





    }
}
