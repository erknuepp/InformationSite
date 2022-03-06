namespace InformationSite.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class UnityModel : PageModel
    {
        private readonly ILogger<UnityModel> _logger;
        
        public UnityModel(ILogger<UnityModel> logger)
        {
            _logger = logger;
        }
        
        public void OnGet()
        {
        
        }
    }
}
