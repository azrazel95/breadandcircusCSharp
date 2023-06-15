namespace WebApplication1.Models
{
    public class Post
    {
        private BreadandCircusContext context;

        public int Id { get; set; }

        public string post_name { get; set; }

        public string description { get; set; }

        public DateTime date_created { get; set; }

        public int user_id { get; set; }
        public User User { get; set; }
        // references model user key id

    }
}
