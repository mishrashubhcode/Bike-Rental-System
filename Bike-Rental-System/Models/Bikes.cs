using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bike_Rental_System.Models
{
    public class Bikes
    {
        [Key]
        public int BikeID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public bool Available { get; set; }

        public virtual ICollection<Rentals> Rentals { get; set; }
    }
}