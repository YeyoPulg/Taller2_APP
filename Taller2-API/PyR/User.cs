namespace PyR
{
    public class User
    {
        public User(string username, string password, string name, string email)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.email = email;
        }

        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}
