namespace MVCAngularJS.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public PersonalDetails PersonalDetails { get; set; }

        public Address AddressDetails { get; set; }

        public Purchase PurchaseDetails { get; set; }

    }
}