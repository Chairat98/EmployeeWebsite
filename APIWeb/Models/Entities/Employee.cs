using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;

namespace APIWeb.Models.Entities
{
    [Index("Email", IsUnique = true)]
    public class Employee
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; } = "";
        public decimal Salary { get; set; }

    }
}
