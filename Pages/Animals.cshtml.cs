using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DZ2_31._01._2024_.Pages
{
        public class AnimalsModel : PageModel
        {
            public AnimalViewModel ?AnimalViewModel { get; set; }

            public void OnGet()
            {
                AnimalViewModel = new AnimalViewModel();
        }
        }
    }
