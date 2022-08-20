using htmlproject.core.domain.Entities;
using System;
using System.Collections.Generic;

namespace htmlproject.core.contracts
{
    public interface IProductRepository
    {
         List<Product> Get();
         void Add(Product product);
         void Sell(int id, int q);

    }
}
