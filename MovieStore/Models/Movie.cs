using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{   [Table("Movies")]
    public class Movie
    {
        static int IdCount = 0;

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(30)]
        public string Director { get; set; }
        [Required]
        public DateTime ReleaseYear { get; set; }
        [Required]
        public decimal Price { get; set; }

        List<OrderRow> OrderRows { get; set; }

        public Movie()
        {
            Id = IdCount++;
        }
    }
}