using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Post
    {
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Header { get; set; }
        public Post PostId { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public void New()
        {

        }
    }
}
