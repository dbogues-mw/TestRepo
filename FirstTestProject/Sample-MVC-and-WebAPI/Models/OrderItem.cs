using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sample_MVC_and_WebAPI.Models
{
    [Table("OrderItem")]
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        //[ForeignKey("Orders")]
        public int OrderId { get; set;}

        //[ForeignKey("Items")]
        public int ItemId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Item Item { get; set; }
    }
}