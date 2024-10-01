using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int CCCD { get; set; }
        public string? Hoten { get; set; }
        public string? Quequan { get; set; }

    }
}