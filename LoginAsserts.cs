using System;
using Xunit;

namespace cubic.incar.auth.test
{
    public class LoginAsserts
    {
        private readonly BasePage currentPage;

        public LoginAsserts(LoginPage currentPage)
        {
            Assert.NotNull(currentPage);
            this.currentPage = currentPage;
        }

        public LoginAsserts AssertLoginSuccessful(Credencials credencials)
        {
            Assert.NotNull(credencials);
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info(string.Format("using credentials: username={0} password={1}", credencials.Username,
                credencials.Password));
            var expected = typeof(LoginPage);
            Assert.IsType(expected, currentPage);
            var startTime = DateTime.UtcNow;
            var signedinPage =
                (this.currentPage as LoginPage).LoginToApplication(credencials.Username, credencials.Password);
            var actualTime = DateTime.UtcNow.Subtract(startTime);
            logger.Info(string.Format("sign in took: {0}s", actualTime.TotalSeconds));

            Assert.True(signedinPage.AllElementsPresentAsExpected);

            return this;
        }

        public LoginAsserts AssertPurchaseDataSuccessful()
        {
            var actualPage = (this.currentPage as SignedinPage).ClickOnPurchaseData();
            Assert.NotNull(actualPage);
            Assert.True(actualPage.AllElementsPresentAsExpected);

            return this;
        }
    }
}