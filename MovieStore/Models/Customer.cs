using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{   [Table("Customers")]
    public class Customer
    {
        static int IdCount = 0;
                
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(20)]
        public string Lastname { get; set; }

        [Required]
        [MaxLength(40)]
        public string BillingAdress { get; set; }

        [Required]
        [MaxLength(5)]
        public int BillingZip { get; set; }

        [Required]
        [MaxLength(20)]
        public string BillingCity { get; set; }

        [Required]
        [MaxLength(40)]
        public string DeliveryAdress { get; set; }

        [Required]
        [MaxLength(5)]
        public int DeliveryZip { get; set; }

        [Required]
        [MaxLength(20)]
        public string DeliveryCity { get; set; }

        [Required]
        public string EmailAdress { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNo { get; set; }

        public List<Order> Orders { get; set; }

        public Customer()
        {
            Id = IdCount++;
        }
    }

}
