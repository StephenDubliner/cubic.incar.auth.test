using Xunit;
using System.Configuration;

namespace cubic.incar.auth.test
{
    public class AuthenticationTestSuite
    {
        [Fact]
        public void SuccessfulLoginTest()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            new LoginAsserts(Page.Login).AssertLoginSuccessful(Credencials.GetValidRandom());
            BrowserFactory.CloseAllDrivers();
        }
    }
}