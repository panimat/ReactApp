﻿using System;

namespace Models
{
    public class Comment
    {
        public string Author { get; set; }
        public string Body { get; set; }
        public int CommentId { get; set; }
        public DateTime CreateDate { get; set; }
        public Post PostId { get; set; }

        public void New()
        {

        }
    }
}
