﻿using System.ComponentModel.DataAnnotations;

namespace CarParkManagement.Domain
{
    public class Location
    {
        [Key]
        public string? LocationName { get; set; }
        public string? Address { get; set; }
        public int PostalCode { get; set; }
        public int Capacity { get; set; }
    }
}
