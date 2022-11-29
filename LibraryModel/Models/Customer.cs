﻿namespace Oana_Oprea_lab2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public int? CityID { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public City? City { get; set; }
    }
}
