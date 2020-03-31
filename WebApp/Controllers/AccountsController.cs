using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoinbasePro;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ICoinbaseProClient Client;

        public AccountsController(ICoinbaseProClient client)
        {
            Client = client;
        }

        // GET: api/Accounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoinbasePro.Services.Accounts.Models.Account>>> Get()
        {
            var allAccounts = await Client.AccountsService.GetAllAccountsAsync();

            return allAccounts.ToArray();
        }
    }
}
