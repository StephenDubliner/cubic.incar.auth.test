using System.Collections.Generic;
using OpenQA.Selenium;

namespace cubic.incar.auth.test
{
    public class PurchaseDataPage : BasePage
    {
        protected override IEnumerable<string> MandatoryElementsId => new string[0];


        public PurchaseDataPage(IWebDriver driver) : base(driver)
        {
        }
    }
}