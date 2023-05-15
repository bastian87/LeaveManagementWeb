﻿using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Models
{
    public class LeaveRequestCreateVM: IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Required]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }        
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date must be before End Date", new[] { nameof(StartDate), nameof(EndDate) });
            }

        }
    }
}
