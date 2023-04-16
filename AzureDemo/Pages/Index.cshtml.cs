using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;

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



            #region SecretClient Changes
            //const string secretName = "apsec";
            //var kvUri = "https://apkeyvalultnew.vault.azure.net/";
            //var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());           
            //var secret = client.GetSecret(secretName);
            //var result = secret.Value.Value.ToString();

            //const string secretName = "apdbconn";
            //var kvUri = "https://apkeyvalultdemo.vault.azure.net/";
            //var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            //var secret = client.GetSecretAsync(secretName).Result.Value;
            #endregion

        }
    }
}
