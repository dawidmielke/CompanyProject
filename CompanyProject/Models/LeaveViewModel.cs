﻿using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Models
{
    public class LeaveViewModel
    {

        [Required]
        public string LeaveDescription { get; set; }

        [Required]
        public DateTime LeaveStart { get; set; }

        [Required]
        public DateTime LeaveEnd { get; set; }
    }
}
