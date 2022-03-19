using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocket4Net;

namespace ClientTest
{

    class ClientCls
    {
        public TextBox msggot;
        public WebSocket ws;
        public event Action<string> OnReceived;
        public event Action OnConnect;
        public event Action OnClose;
        public event Action OnOpen;
        public ClientCls(string ip, string port)
        {
            ws = new WebSocket(string.Format(@"ws://{0}:{1}", ip, port));
            ws.Opened += Ws_Opened;
            ws.MessageReceived += Ws_MessageReceived;
            ws.Closed += Ws_Closed;
        }
        public void Connect()
        {
            ws.Open();
        }

        private void Ws_Opened(object sender, EventArgs e)
        {
            OnOpen?.Invoke();
        }

        public void Send(string message)
        {
            //message =ZEncypt.DESEncrypt(message);
            ws.Send(message);
        }

        private void Ws_Closed(object sender, EventArgs e)
        {
            OnClose?.Invoke();
        }


        private void Ws_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            OnReceived?.Invoke(e.Message);
            msggot.Text += "\r\n" + e.Message;
        }
    }
}
