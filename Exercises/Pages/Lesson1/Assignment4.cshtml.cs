using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.CompilerServices;

namespace Exercises.Pages.Lesson1
{
    public class Assignment4 : PageModel
    {
        [BindProperty] private int CategoryHeading { get; set; }
        [BindProperty] int SubCategoryHeading { get; set; }
        [BindProperty] int ProductIdHeading { get; set; }
        public void OnGet()
        {
            
        }
    }
}
