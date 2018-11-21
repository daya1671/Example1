using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIApp1.Entity
{
    public class Order : IEntity
    {
        public Order()
        {
            OrderDetail = new List<OrderDetails>();
        }
        //public int ID { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetails> OrderDetail { get; set; }

        
    }
}