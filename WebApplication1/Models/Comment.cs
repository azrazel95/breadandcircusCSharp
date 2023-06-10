using Microsoft.AspNetCore.Http.Features;

namespace WebApplication1.Models
{
    public class Comment
    {
        private BreadandCircusContext context;

        public int Id
        { get; set; }

        public string description { get; set; }

        public DateTime date_created {  get; set; }

        public int user_id { get; set; }
        // references model user key id
        public int post_id { get; set; }
        //references model post key id
    }
}
