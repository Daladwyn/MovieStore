using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    [Table("Orders")]
    public class Order
    {
        static int IdCount = 0;

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int CustomerId { get; set; }


        List<OrderRow> OrderRows { get; set; }

        public Order()
        {
            Id = IdCount++;
        }
    }
}