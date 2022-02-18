using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercises.Pages.Lesson1
{
    public class Assignment1 : PageModel
    {
        // opdracht 3
        public int Home { get; set; }
         // opdracht 3
        public int Away { get; set; }
        
        // opdracht 2
        public void OnGet([FromQuery] int home, [FromQuery] int away)
        {
            this.Home = home;
            Away = away;
        }
        
        
    }
}
