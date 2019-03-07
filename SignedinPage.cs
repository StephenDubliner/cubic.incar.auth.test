using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace cubic.incar.auth.test
{
    public class SignedinPage : BasePage
    {
        [CacheLookup]
        private IWebElement SignOutElement
        {
            get { return this.driver.FindElement(By.Id(Assets.SignOutId)); }
        }

        [CacheLookup]
        private IWebElement PurchaseDataElement
        {
            get { return this.driver.FindElement(By.Id(Assets.PurchaseDataId)); }
        }

        protected override IEnumerable<string> MandatoryElementsId => new[] {Assets.SignOutId, Assets.PurchaseDataId};

        public PurchaseDataPage ClickOnPurchaseData()
        {
            this.PurchaseDataElement.Click();
            return new PurchaseDataPage(this.driver);
        }

        public SignedinPage(IWebDriver driver) : base(driver)
        {
        }
    }
}