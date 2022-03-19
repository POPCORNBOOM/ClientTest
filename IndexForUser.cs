using SuperWebSocket;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTest
{
    class IndexForUser
    {
        private ArrayList ArrLst;//用于存放User类
        public IndexForUser()
        {
            ArrLst = new ArrayList();
        }

        //声明一个索引器：以编号查找SN
        public string this[string sessionid, WebSocketSession session, string project, string role]
        {
            get
            {
                foreach (User en in ArrLst)
                {
                    if (en.sessionID == sessionid && en.Session == session && en.Project == project && en.Role == role)
                    {
                        return en.SN;
                    }
                }
                return null;
            }
            set
            {
                //new关键字：C#规定，实例化一个类或者调用类的构造函数时，必须使用new关键
                ArrLst.Add(new User(sessionid, session, project, role, value));
            }
        }
        public User this[string id]
        {
            get
            {
                foreach (User en in ArrLst)
                {
                    if (en.sessionID == id)
                    {
                        return en;
                    }
                }
                return null;
            }
        }

    }
}
