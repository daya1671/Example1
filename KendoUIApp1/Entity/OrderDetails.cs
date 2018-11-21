namespace KendoUIApp1.Entity
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public int Quatity { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}