using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.Models
{
    public class Youtuber
    {
        public List<Post> Posts { get; set; }

        public List<ISubscriber> Subscribers { get; set; }

        public Youtuber()
        {
            Subscribers = new List<ISubscriber>();
        }
    }
}
