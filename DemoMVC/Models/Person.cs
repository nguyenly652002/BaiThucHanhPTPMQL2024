using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Person
    {
        [Key]
        public int CCCD { get; set; }
        public string? Hoten { get; set; }
        public string? Quequan { get; set;}
    }
}