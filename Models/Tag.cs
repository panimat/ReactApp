﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Tag
    {
        public Post PostId { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }

        public void New()
        {

        }
    }
}
