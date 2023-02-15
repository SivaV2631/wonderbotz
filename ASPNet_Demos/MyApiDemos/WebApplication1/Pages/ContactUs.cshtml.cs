using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class ContactUsModel : PageModel
    {
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
        }

        public Employee? emp;

        public void OnGet()
        {
            this.emp = new Employee()
            {
                Id = 1,
                FirstName = "Manoj Kumar",
                LastName = "Sharma"
            };

        }
    }
}
