using System;

namespace TSport.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Tag { get; set; }
        public DateTime TimePosted { get; set; }
    }

}
