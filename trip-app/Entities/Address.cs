using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace trip_app.Entities
{
    [Table("Address")]
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [MaxLength(14)]
        public string State { get; set; }

        [Required]
        [MaxLength(26)]
        public string City { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }
}