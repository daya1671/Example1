using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIApp1.Entity
{
    public class Customer : IEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Customer()
        {
            Orders = new List<Order>();
        }

        //public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerImage { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}