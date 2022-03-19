
namespace ClientTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_sendmsg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TargetIP = new System.Windows.Forms.TextBox();
            this.tb_TargetPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ServerPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_log = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.t_ClientMsgGot = new System.Windows.Forms.TextBox();
            this.btn_clearC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(17, 198);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(132, 73);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start Server";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(174, 198);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(132, 73);
            this.btn_stop.TabIndex = 0;
            this.btn_stop.Text = "Stop Server";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(21, 74);
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(269, 31);
            this.tb_msg.TabIndex = 1;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(21, 198);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(132, 73);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect Server";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_sendmsg
            // 
            this.btn_sendmsg.Location = new System.Drawing.Point(311, 74);
            this.btn_sendmsg.Name = "btn_sendmsg";
            this.btn_sendmsg.Size = new System.Drawing.Size(81, 31);
            this.btn_sendmsg.TabIndex = 2;
            this.btn_sendmsg.Text = "send";
            this.btn_sendmsg.UseVisualStyleBackColor = true;
            this.btn_sendmsg.Click += new System.EventHandler(this.btn_sendmsg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.t_log);
            this.panel1.Controls.Add(this.tb_ServerPort);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 437);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btn_clearC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.t_ClientMsgGot);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_TargetPort);
            this.panel2.Controls.Add(this.tb_TargetIP);
            this.panel2.Controls.Add(this.tb_msg);
            this.panel2.Controls.Add(this.btn_Connect);
            this.panel2.Controls.Add(this.btn_sendmsg);
            this.panel2.Location = new System.Drawing.Point(459, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 437);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Panel";
            // 
            // tb_TargetIP
            // 
            this.tb_TargetIP.Location = new System.Drawing.Point(21, 141);
            this.tb_TargetIP.Name = "tb_TargetIP";
            this.tb_TargetIP.Size = new System.Drawing.Size(269, 31);
            this.tb_TargetIP.TabIndex = 3;
            this.tb_TargetIP.Text = "127.0.0.1";
            // 
            // tb_TargetPort
            // 
            this.tb_TargetPort.Location = new System.Drawing.Point(311, 141);
            this.tb_TargetPort.Name = "tb_TargetPort";
            this.tb_TargetPort.Size = new System.Drawing.Size(81, 31);
            this.tb_TargetPort.TabIndex = 3;
            this.tb_TargetPort.Text = "5233";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Panel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(292, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(16, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(306, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Port";
            // 
            // tb_ServerPort
            // 
            this.tb_ServerPort.Location = new System.Drawing.Point(17, 74);
            this.tb_ServerPort.Name = "tb_ServerPort";
            this.tb_ServerPort.Size = new System.Drawing.Size(85, 31);
            this.tb_ServerPort.TabIndex = 2;
            this.tb_ServerPort.Text = "5233";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Port Setting(0-65535)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(16, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Message";
            // 
            // t_log
            // 
            this.t_log.Location = new System.Drawing.Point(3, 360);
            this.t_log.Multiline = true;
            this.t_log.Name = "t_log";
            this.t_log.ReadOnly = true;
            this.t_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_log.Size = new System.Drawing.Size(435, 74);
            this.t_log.TabIndex = 3;
            this.t_log.Text = "Form Opened";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(330, 299);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(108, 38);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear Msg";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // t_ClientMsgGot
            // 
            this.t_ClientMsgGot.Location = new System.Drawing.Point(3, 360);
            this.t_ClientMsgGot.Multiline = true;
            this.t_ClientMsgGot.Name = "t_ClientMsgGot";
            this.t_ClientMsgGot.ReadOnly = true;
            this.t_ClientMsgGot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_ClientMsgGot.Size = new System.Drawing.Size(405, 74);
            this.t_ClientMsgGot.TabIndex = 3;
            this.t_ClientMsgGot.Text = "Form Opened";
            // 
            // btn_clearC
            // 
            this.btn_clearC.Location = new System.Drawing.Point(297, 299);
            this.btn_clearC.Name = "btn_clearC";
            this.btn_clearC.Size = new System.Drawing.Size(108, 38);
            this.btn_clearC.TabIndex = 4;
            this.btn_clearC.Text = "Clear Msg";
            this.btn_clearC.UseVisualStyleBackColor = true;
            this.btn_clearC.Click += new System.EventHandler(this.btn_clearC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(882, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_sendmsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TargetPort;
        private System.Windows.Forms.TextBox tb_TargetIP;
        private System.Windows.Forms.TextBox tb_ServerPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_log;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_clearC;
        private System.Windows.Forms.TextBox t_ClientMsgGot;
    }
}

