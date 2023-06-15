using WebApplication1.Utilities;

namespace WebApplication1.Models
{
    public class User
    {
        private BreadandCircusContext context;

        public int Id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public void Create()
        {
            //Hashes the password before saving
            //password = PasswordHasher.HashPassword(password);
            //Saves the password and user to the DB
            //context.Users.Add(this);
            //context.SaveChanges();
        }
    }
}
