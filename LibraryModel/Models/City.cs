using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oana_Oprea_lab2.Models
{
    public class City
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        //public ICollection<Customer> Customers1 { get; set; }
    }
}
