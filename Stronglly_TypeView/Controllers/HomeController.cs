using Microsoft.AspNetCore.Mvc;
using Stronglly_TypeView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stronglly_TypeView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            Employee emp1 = new Employee();
            emp1.name = "Saifullah";
            emp1.gender = "male";
            emp1.designation = "Lecturer";

            Employee emp2 = new Employee();
            emp1.name = "Shoaib mahar";
            emp1.gender = "male";
            emp1.designation = "Lecturer";

            Employee emp3 = new Employee();
            emp1.name = "Zulqarnain";
            emp1.gender = "male";
            emp1.designation = "Lecturer";

            List<Employee> mylist = new List<Employee>();
            mylist.Add(emp1);
            mylist.Add(emp2);
            mylist.Add(emp3);

            return View(mylist);
        }
    }
}
