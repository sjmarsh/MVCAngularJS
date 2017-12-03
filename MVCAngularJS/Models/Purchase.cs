using System;
using System.Collections.Generic;

namespace MVCAngularJS.Models
{

    public class Purchase
    {
        public int Id { get; set; }
        public DateTime PurhcaseDate { get; set; }
        public string ReferenceNumber { get; set; }
        public List<PurchaseLine> PurchaseLines { get; set; }
    }
}