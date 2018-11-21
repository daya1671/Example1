using System.Collections.Generic;

namespace KendoUIApp1.Entity
{
    public class Product : IEntity
    {
        public Product()
        {
            OrderDetails = new List<OrderDetails>();
        }
      //  public int ID { get; set; }
        public int Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string ProductImage { get; set; }
        public string ProductType { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}