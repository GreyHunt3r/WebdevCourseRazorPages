using System;
using System.Net;
using System.Text.Json.Serialization;
using Exercises.Pages.Lesson1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace Exercises.Pages.Lesson1
{
    public class Assignment5 : PageModel
    {
        public class MoodCounter
        {
            public int Happy { get; set; }
            public int Disappointed { get; set; }
            public int Angry { get; set; }

        }

        public MoodCounter M = new();
        
        public void OnGet()
        {
        }

        public void OnPost(string mood = "")
        {
            if (HttpContext.Request.Cookies.ContainsKey("myCookie"))
            {
                string value = HttpContext.Request.Cookies["myCookie"];
                M = JsonConvert.DeserializeObject<MoodCounter>(value);
            }
             

            switch (mood)
            {
                case "happy":
                    M.Happy++;
                    break;
                case "disappointed":
                    M.Disappointed++;
                    break;
                case "angry":
                    M.Angry++;
                    break;
                case "reset":
                    M.Disappointed = 0;
                    M.Happy = 0;
                    M.Angry = 0;
                    break;

            }

            string mString= JsonConvert.SerializeObject(M);
            Response.Cookies.Append("myCookie", mString);

        }
    }
}
