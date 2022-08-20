using htmlproject.core.domain.Entities;
using System.Collections.Generic;

namespace htmlproject.core.contracts
{
    public interface IRecieptRepository
    {
        List<Reciept> Get();
        void Add(Reciept reciept);

    }
}
