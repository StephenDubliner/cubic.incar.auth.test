namespace cubic.incar.auth.test
{
    public static class Page
    {
        public static HomePage Home => new HomePage(BrowserFactory.Driver);

        public static LoginPage Login => new LoginPage(BrowserFactory.Driver);
    }
}