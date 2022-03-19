using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTest
{
    public partial class Form1 : Form
    {
        serviceCls service = new serviceCls();
        ClientCls client;

        public Form1()
        {
            InitializeComponent();
            string path = AppDomain.CurrentDomain.BaseDirectory + "logger.config";
            log4net.Config.XmlConfigurator.Configure(new FileInfo(path));
            service.logbox = t_log;
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            service.Start(int.Parse(tb_ServerPort.Text));
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            service.End();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            client = new ClientCls(tb_TargetIP.Text.ToString(), tb_TargetPort.Text.ToString());
            client.msggot = t_ClientMsgGot;
            client.Connect();
        }

        private void btn_sendmsg_Click(object sender, EventArgs e)
        {
            client.Send(tb_msg.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            t_log.Text = "Messages";
        }

        private void btn_clearC_Click(object sender, EventArgs e)
        {
            t_ClientMsgGot.Text = "Messages";
        }
    }
}
