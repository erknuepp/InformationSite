namespace InformationSite.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CSharpModel : PageModel
    {
        private readonly ILogger<CSharpModel> _logger;

        public CSharpModel(ILogger<CSharpModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
