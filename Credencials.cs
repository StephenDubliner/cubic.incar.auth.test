namespace cubic.incar.auth.test
{
    public class Credencials
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static Credencials GetValidRandom()
        {
            return new Credencials() {Username = "", Password = ""};
        }
    }
}