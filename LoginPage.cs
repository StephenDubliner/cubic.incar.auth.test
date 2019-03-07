using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace cubic.incar.auth.test
{
    public class LoginPage : BasePage
    {
        [CacheLookup]
        private IWebElement UserNameElement
        {
            get { return this.driver.FindElement(By.Id(Assets.LoginPageUserNameId)); }
        }

        [CacheLookup]
        private IWebElement PasswordElement
        {
            get { return this.driver.FindElement(By.Id(Assets.LoginPagePasswordId)); }
        }

        [CacheLookup]
        private IWebElement LoginButtonElement
        {
            get { return this.driver.FindElement(By.Id(Assets.LoginPageSubmit)); }
        }

        [CacheLookup]
        private IWebElement ForgotPasswordElement
        {
            get { return this.driver.FindElement(By.Id(Assets.ForgotPasswordId)); }
        }

        protected override IEnumerable<string> MandatoryElementsId => new[]
            {Assets.LoginPageUserNameId, Assets.LoginPagePasswordId, Assets.LoginPageSubmit, Assets.ForgotPasswordId};

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public SignedinPage LoginToApplication(string username, string password)
        {
            UserNameElement.SendKeys(username);
            PasswordElement.SendKeys(password);
            LoginButtonElement.Submit();
            return new SignedinPage(this.driver);
        }
    }
}