namespace UserManagement
{
    public class RegisterUserCommand
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class User
    {
        public long Id { get; set; }
        public string Password { get; private set; }
        public string Username { get; private  set; }
        public User(string username, string password)
        {
            
        }
    }
}