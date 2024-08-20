using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set;}
        public string? FullName { get; set;}
    } 
}