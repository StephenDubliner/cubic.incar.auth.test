using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace cubic.incar.auth.test
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;

        protected abstract IEnumerable<string> MandatoryElementsId { get; }

        public virtual bool AllElementsPresentAsExpected
        {
            get
            {
                var result = new Dictionary<string, int>();
                var noElements = true;
                foreach (var elementId in this.MandatoryElementsId)
                {
                    noElements = false;
                    var actualElements = this.driver.FindElements(By.Id(elementId));
                    result[elementId] = actualElements?.Count ?? 0;
                }

                return result.All(e => e.Value == 1) || noElements;
            }
        }

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}