using log4net;
using SuperSocket.SocketBase;
using SuperWebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTest
{
    class serviceCls
    {
        //创建服务端对象
        public WebSocketServer appServer = new WebSocketServer();
        //初始化日志对象
        public ILog log = LogManager.GetLogger("即时通讯服务");
        //已连接客户端列表
        public IndexForUser UserList = new IndexForUser();

        public TextBox logbox;
        
        //启动服务
        public void Start(int port)
        {
            log.Debug("SuperWebSocket(0.8).Source服务器 start the WebSocketServer!");
            logbox.Text += "\r\nSuperWebSocket(0.8).Source服务器 start the WebSocketServer!";
            if (!appServer.Setup(port))
            {
                log.Error("Failed to setup!");
                logbox.Text += "\r\nFailed to setup";
                return;
            }
            appServer.NewSessionConnected += new SessionHandler<WebSocketSession>(appServer_NewClientConnected);
            appServer.NewMessageReceived += new SessionHandler<WebSocketSession, string>(appServer_NewMessageReceived);
            appServer.SessionClosed += new SessionHandler<WebSocketSession, SuperSocket.SocketBase.CloseReason>(appServer_SessionClosed);
            if (!appServer.Start())
            {
                log.Error("Failed to start!");
                logbox.Text += "\r\nFailed to setup";

                return;
            }
            log.Info("通讯服务器启动成功!");
            logbox.Text += "\r\n通讯服务器启动成功!";

        }
        //停止websocket服务
        public void End()
        {
            appServer.Stop();
        }
        //发送消息方法
        private void SendMsg(WebSocketSession session, string msg)
        {
            session.Send(msg);
        }
        
        //客户端连接成功事件，在此事件中可以开启一个定时器，在规定时间内验证客户端身份，比如3秒钟后验证是否上传基本身份信息，如果与数据库中ID做对比，如果不存在则断开连接
        private void appServer_NewClientConnected(WebSocketSession session)
        {
            log.Debug("Connected with" + session.SessionID);
            logbox.Text += "\r\nConnected with" + session.SessionID;
            MessageBox.Show("Server:\nConnected with" + session.SessionID);
            User user = new User(session.SessionID);

        }

            //收到来自客户端的消息，有可能是身份信息，也有可能是业务指令。如果是身份信息则修改索引器中用户基本信息，如果是业务指令，则操作相关业务
        private void appServer_NewMessageReceived(WebSocketSession session, string message)
        {
            MessageBox.Show("Server:\nReceive msg form " + session.SessionID + ":" + message);
            logbox.Text += "\r\nReceive msg form " + session.SessionID + ":" + message;

            SendMsg(session,"Hi Client(Time"+ DateTime.Now+")("+ session.SessionID + "),got ur msg:" +  message);

        }

        //当客户端断开后事件，此处应删除已端开用户
        private void appServer_SessionClosed(WebSocketSession session, SuperSocket.SocketBase.CloseReason closeRs)
        {
            MessageBox.Show("Server:\nClosed session" + session.SessionID + ";Rs:" + closeRs);
            logbox.Text += "\r\nClosed session" + session.SessionID + ";Rs:" + closeRs;

        }
    }
}
