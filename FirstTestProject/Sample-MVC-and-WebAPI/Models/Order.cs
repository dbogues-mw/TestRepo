using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sample_MVC_and_WebAPI.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime DatePlaced { get; set; }


        //public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}