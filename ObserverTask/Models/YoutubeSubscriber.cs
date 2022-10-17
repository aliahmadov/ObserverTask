﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.Models
{
    public class YoutubeSubscriber : ISubscriber
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Post> Posts { get; set; }
        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}