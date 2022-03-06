namespace InformationSite.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class XamarinModel : PageModel
    {
        private readonly ILogger<XamarinModel> _logger;

        public XamarinModel(ILogger<XamarinModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
