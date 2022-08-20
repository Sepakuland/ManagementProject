using htmlproject.core.contracts;
using htmlproject.core.domain.Entities;
using htmlproject.infrastructure.data;
using System;
using System.Collections.Generic;

namespace htmlproject.core.applicationservice
{
    public class ProductFacade: IProductFacade
    {

        private readonly IProductRepository productRepository;

        public ProductFacade(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }

        public void Add(Product product)
        {
            productRepository.Add(product);
        }
        public IEnumerable<Product> Get()
        {
            return productRepository.Get();
        }

        public void Sell(int id, int q)
        {
            productRepository.Sell(id, q);
        }




    }
}
