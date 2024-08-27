using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
      public IActionResult Index(Student std)
    {
        string strOutput = "Sinh Viên " + "-" + std.FullName + "-" + "đến từ" + "-" + std.Address;
        ViewBag.thongBao = strOutput;
        return View();
    }
    }
}