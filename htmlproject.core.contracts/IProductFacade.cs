using htmlproject.core.domain.Entities;
using System.Collections.Generic;

namespace htmlproject.core.contracts
{
    public interface IProductFacade
    {
        IEnumerable<Product> Get();
        void Add(Product product);
        void Sell(int id, int q);

    }
}
