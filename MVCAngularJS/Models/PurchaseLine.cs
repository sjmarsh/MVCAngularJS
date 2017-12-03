namespace MVCAngularJS.Models
{

    public class PurchaseLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }  // free form for now - no products to choose from
        public double Price { get; set; }
    }
}