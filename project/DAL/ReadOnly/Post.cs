﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.DAL
{
    public class Post
    {
        public int OwnerId { get; set; }
        public int Id { get; set; }
        public DateTime CreationDate {get; set;}
        public int Score { get; set; }
        public string Body { get; set; }
        public int PostTypeId { get; set; }
    }
}