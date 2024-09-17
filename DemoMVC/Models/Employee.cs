using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Employee 
    {
        [Key]
        public string? EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }

    }
}