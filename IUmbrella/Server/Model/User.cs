namespace IUmbrella.Server.Model
{
    public class User
    {
        public User(int id, string login, string password)
        {
            Id = id;
            this.login = login;
            this.password = password;
        }

        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }

    }
}
