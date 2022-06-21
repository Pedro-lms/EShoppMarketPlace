using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EShoppMarketPlace.src.Web.WebMVC
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [Authorize(AuthenticationSchemes = OpenIdConnectDefaults.AuthenticationScheme)]
       // public async Task<IActionResult> SignIn(string returnUrl)
      //  {
       //     var user = User as ClaimsPrincipal;
            //var token = await HttpContent.GetTokenAsync("access_token");
      //  }
    }
}
