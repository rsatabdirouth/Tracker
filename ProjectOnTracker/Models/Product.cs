using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOnTracker.Models
{
    public class Product
    {
     [Key]   public int ID { get; set; }
        public string ProductName { get; set; }
    }
}