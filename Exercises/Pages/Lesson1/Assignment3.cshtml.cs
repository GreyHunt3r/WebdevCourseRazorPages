using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment3 : PageModel
    {
        [BindProperty]
        public int Result { get; set; }
        public void OnGet()
        {

        }
        
        public void OnPostAdd([FromForm] int input)
        {
            Result = Result + input;
        }

        public void OnPostSub([FromForm] int input)
        {
            Result = Result - input;
        }
        
        public void OnPostDiv([FromForm] int input)
        {
            Result = Result / input;
        }
        
        public void OnPostMul([FromForm] int input)
        {
            Result = Result * input;
        }
    }
}
