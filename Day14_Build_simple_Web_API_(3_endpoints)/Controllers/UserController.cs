using Microsoft.AspNetCore.Mvc;
using WebAPI_Endpoint.Models;

namespace WebAPI_Endpoint.Controllers
{
    
    public class UserController : Controller
    {
        public IActionResult Details()
        {
            Console.WriteLine("User Details Page");
            var user = new UserViewModel
            {
                Id = 1,
                Name = "Hussain Saabri",
                Email = "hussain.saabri@gmail.com",
                Status = "Active"
            };

            
            return View(user);
        }
    }
}
