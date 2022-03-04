using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.CompilerServices;

namespace Exercises.Pages.Lesson1
{
    public class Assignment4 : PageModel
    {
        [BindProperty (SupportsGet = true)] private int CategoryHeading { get; set; }
        [BindProperty (SupportsGet = true)] int SubCategoryHeading { get; set; }
        [BindProperty (SupportsGet = true)] int ProductIdHeading { get; set; }
        
        public void OnGet()
        {
            
        }
    }
    
    
}
