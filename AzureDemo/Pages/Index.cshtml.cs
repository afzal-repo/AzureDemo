using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AzureDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration Configuration;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public void OnGet()
        {
            ViewData["key1"] = Configuration["key1"];
            ViewData["key2"] = Configuration["key2"];
            ViewData["key3"] = Configuration["key3"];
            ViewData["connectionString"] = Configuration.GetConnectionString("dbConnectionName");
        }
    }
}
