using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class EmployeeDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string? Phone { get; set; }

        public decimal Salary { get; set; }
    }

}
