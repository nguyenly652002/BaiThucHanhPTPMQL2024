using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Lophoc 
    {
        [Key]
        public string? FullName { get; set; }
        public string? Address { get; set; }

    }
}