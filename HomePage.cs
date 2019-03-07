using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace cubic.incar.auth.test
{
    public class HomePage : BasePage
    {
        [CacheLookup]
        private IWebElement MyAccountElement
        {
            get { return this.driver.FindElement(By.Id("account")); }
        }

        protected override IEnumerable<string> MandatoryElementsId => new[]
            {Assets.LoginPageUserNameId, Assets.LoginPagePasswordId, Assets.LoginPageSubmit, Assets.ForgotPasswordId};

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnMyAccount()
        {
            MyAccountElement.Click();
        }
    }
}