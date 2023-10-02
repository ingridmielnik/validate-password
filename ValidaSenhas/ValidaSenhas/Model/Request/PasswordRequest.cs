namespace ValidaSenhas.Model.Request
{
    public class PasswordRequest
    {
        public string Password { get; set; }

        public PasswordRequest(string password)
        {
            Password = password;
        }
    }
}
