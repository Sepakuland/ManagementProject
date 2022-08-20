using System;

namespace htmlproject.core.domain.Entities
{
    public class Reciept
    {
        public Reciept()
        {
            date = DateTime.Now;
           
        }

        public int RecieptId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime date { get; set; }


    }
}
