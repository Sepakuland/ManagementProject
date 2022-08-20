using htmlproject.core.contracts;
using htmlproject.core.domain.Entities;
using htmlproject.infrastructure.ef;
using System.Collections.Generic;
using System.Linq;

namespace htmlproject.infrastructure.data
{
    public class RecieptRepository : IRecieptRepository
    {
        private readonly MyContext context;
        

        public RecieptRepository(MyContext context)
        {
            this.context = context;
        }

        public List<Reciept> Get()
        {
            return context.Reciepts.ToList();
        }

        public void Add(Reciept reciept)
        {

            int id = reciept.ProductId;
            int count = reciept.Quantity;
            Product p = context.Products.Find(id);
            p.Count = p.Count - count;
            context.Reciepts.Add(reciept);
            context.SaveChanges();


        }


    }
}
