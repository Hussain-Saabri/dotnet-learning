using System.ComponentModel.DataAnnotations;

namespace WebAPI_Endpoint.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression(@".*@gmail\.com$", ErrorMessage = "Email must end with @gmail.com")]
        public string Email { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}
