using CoinbasePro;
using CoinbasePro.Network.Authentication;
using CoinbasePro.Services.Accounts;
using CoinbasePro.Services.CoinbaseAccounts;
using CoinbasePro.Services.Currencies;
using CoinbasePro.Services.Deposits;
using CoinbasePro.Services.Fills;
using CoinbasePro.Services.Fundings;
using CoinbasePro.Services.Orders;
using CoinbasePro.Services.Payments;
using CoinbasePro.Services.Products;
using CoinbasePro.Services.Reports;
using CoinbasePro.Services.StablecoinConversions;
using CoinbasePro.Services.UserAccount;
using CoinbasePro.Services.Withdrawals;
using CoinbasePro.WebSocket;

namespace WebApp
{
    public class CoinbaseProClient : ICoinbaseProClient
    {
        private readonly CoinbasePro.CoinbaseProClient client;

        public CoinbaseProClient()
        {
            //fill in authenticator details
            var authenticator = new Authenticator("", "", "");

            client = new CoinbasePro.CoinbaseProClient(authenticator, true);
        }

        public IAccountsService AccountsService => client.AccountsService;

        public ICoinbaseAccountsService CoinbaseAccountsService => client.CoinbaseAccountsService;

        public IOrdersService OrdersService => client.OrdersService;

        public IPaymentsService PaymentsService => client.PaymentsService;

        public IWithdrawalsService WithdrawalsService => client.WithdrawalsService;

        public IDepositsService DepositsService => client.DepositsService;

        public IProductsService ProductsService => client.ProductsService;

        public ICurrenciesService CurrenciesService => client.CurrenciesService;

        public IFillsService FillsService => client.FillsService;

        public IFundingsService FundingsService => client.FundingsService;

        public IReportsService ReportsService => client.ReportsService;

        public IUserAccountService UserAccountService => client.UserAccountService;

        public IStablecoinConversionsService StablecoinConversionsService => client.StablecoinConversionsService;

        public IWebSocket WebSocket => client.WebSocket;
    }
}
