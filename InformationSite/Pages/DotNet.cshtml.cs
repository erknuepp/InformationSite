namespace InformationSite.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DotNetModel : PageModel
    {
        private readonly ILogger<DotNetModel> _logger;

        public DotNetModel(ILogger<DotNetModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
