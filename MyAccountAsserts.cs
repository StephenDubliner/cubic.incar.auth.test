using Xunit;

namespace cubic.incar.auth.test
{
    public class MyAccountAsserts
    {
        private readonly SignedinPage signedinPage;

        public MyAccountAsserts(SignedinPage signedinPage)
        {
            this.signedinPage = signedinPage;
        }

        public MyAccountAsserts AssertElementsAsExpected()
        {
            Assert.True(this.signedinPage.AllElementsPresentAsExpected);
            this.signedinPage.ClickOnPurchaseData();
            return this;
        }
    }
}