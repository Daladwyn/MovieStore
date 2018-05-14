using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{   [Table("OrderRows")]
    public class OrderRow
    {
        static int IdCount = 0;

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public decimal Price { get; set; }

        public OrderRow()
        {
            Id = IdCount++;
        }
    }
}