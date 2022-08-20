using htmlproject.core.contracts;
using htmlproject.core.domain.Entities;
using htmlproject.infrastructure.data;
using System.Collections.Generic;

namespace htmlproject.core.applicationservice
{
    public class RecieptFacade: IRecieptFacade
    {

        private readonly IRecieptRepository recieptRepository;

        public RecieptFacade(RecieptRepository recieptRepository)
        {
            this.recieptRepository = recieptRepository;

        }

        public void Add(Reciept reciept)
        {
            recieptRepository.Add(reciept);
        }
        public IEnumerable<Reciept> Get()
        {
            return recieptRepository.Get();
        }

       

    }
}
