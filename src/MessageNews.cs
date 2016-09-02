using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QyWexin
{
    [Serializable]
    public class MessageNews
    {
        public string touser;

        public string msgtype;

        public int agentid;

        public news news;
    }

    public class news
    {
        public List<Articles> articles;
    }

    public class Articles
    {
        public string title;
        public string description;
        public string url;
        public string picurl;
    }
}
