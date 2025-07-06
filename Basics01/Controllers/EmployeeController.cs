using Basics01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics01.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult IndexE()
        {
            string message = $"hello world. {DateTime.Now.ToString()}";
            return View("IndexE",message);
            
        }
        public string IndexE2()
        {
            return "ayberk";

        }
        public ViewResult IndexE3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1,FirstName="abdf",LastName="aytar`",Age=20 },
                new Employee(){Id=2,FirstName="b",LastName="aytar`",Age=3 },
                new Employee(){Id=3,FirstName="n",LastName="aytar`",Age=4 },
            };
            return View("IndexE2",list);
        }


    }
}  
