using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace aspnetcoreapp.Pages
{
    public class SignUpModel : PageModel
    {
        private readonly ILogger<SignUpModel> _logger;

        public SignUpModel(ILogger<SignUpModel> logger) 
        {
            _logger = logger;
        }

        public void OnGet()
    {

    }
    
    }
}
