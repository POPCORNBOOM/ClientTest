using SuperWebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTest
{
    class User
    {

        //socket连接标识ID
        public string sessionID { get; set; }
        //安全标识ID
        public string SN { get; set; }

        public string Name { get; set; }

        public string IP { get; set; }

        public string Project { get; set; }

        public string Role { get; set; }

        public object Tag { get; set; }

        public WebSocketSession Session { get; set; }

        public User(string ID)
        {
            this.sessionID = ID;
        }
        public User(string sessionid, WebSocketSession session, string project, string role, string phone)
        {
            this.sessionID = sessionid;
            this.Session = session;
        }

    }
}
