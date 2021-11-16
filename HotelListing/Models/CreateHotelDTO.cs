﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel Name Is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Hotel Address Is Too Long")]
        public string Address { get; set; }
        [Required]
        [Range(1, 5)]
        public float Rating { get; set; }
        //[Required]
        public int CountryId { get; set; }
    }
}