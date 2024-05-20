using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MesasExamenes.Pages
{
    public class PrivacyModels : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        
        public PrivacyModels(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
