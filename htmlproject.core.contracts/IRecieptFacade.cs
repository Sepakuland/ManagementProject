using htmlproject.core.domain.Entities;
using System.Collections.Generic;

namespace htmlproject.core.contracts
{
    public interface IRecieptFacade
    {
        IEnumerable<Reciept> Get();
        void Add(Reciept reciept);

    }
}
