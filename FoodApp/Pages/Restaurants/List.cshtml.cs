using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace FoodApp.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        public IConfiguration _config { get; }

        public ListModel(IConfiguration config)
        {
            _config = config;
        }
        public void OnGet()
        {
            //Message = "Hello world";
            Message = _config["Message"];
        }
    }
}