using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }        

        [Display(Name = "Number Of Days")]
        [Required]
        [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
        public int NumberOfDays { get; set; }

        [Required]
        public int Period {get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}
