using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Hosting;


namespace WebApplication1.Models
{
    public class Comment
    {
        private BreadandCircusContext context;

        public int Id{ get; set; }

        public string description { get; set; }

        public DateTime date_created {  get; set; }

        public int user_id { get; set; }
        public User User { get; set; }
        // references model user key id
        public int post_id { get; set; }
        public Post Post { get; set; }
        //references model post key id
    }
   
  
}
