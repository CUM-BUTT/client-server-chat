namespace client
{
    partial class ClientWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect_button = new System.Windows.Forms.Button();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label_server_port = new System.Windows.Forms.Label();
            this.label_server_ip = new System.Windows.Forms.Label();
            this.textBox_input_freld = new System.Windows.Forms.TextBox();
            this.textBox_chat = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(688, 7);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(100, 23);
            this.connect_button.TabIndex = 0;
            this.connect_button.Text = "connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(234, 10);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(100, 20);
            this.textBox_port.TabIndex = 1;
            this.textBox_port.Text = "5000";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(65, 10);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(100, 20);
            this.textBox_ip.TabIndex = 2;
            this.textBox_ip.Text = "95.31.60.80";
            // 
            // label_server_port
            // 
            this.label_server_port.AutoSize = true;
            this.label_server_port.Location = new System.Drawing.Point(171, 13);
            this.label_server_port.Name = "label_server_port";
            this.label_server_port.Size = new System.Drawing.Size(57, 13);
            this.label_server_port.TabIndex = 4;
            this.label_server_port.Text = "server port";
            // 
            // label_server_ip
            // 
            this.label_server_ip.AutoSize = true;
            this.label_server_ip.Location = new System.Drawing.Point(12, 13);
            this.label_server_ip.Name = "label_server_ip";
            this.label_server_ip.Size = new System.Drawing.Size(47, 13);
            this.label_server_ip.TabIndex = 5;
            this.label_server_ip.Text = "server ip";
            // 
            // textBox_input_freld
            // 
            this.textBox_input_freld.Location = new System.Drawing.Point(12, 383);
            this.textBox_input_freld.Multiline = true;
            this.textBox_input_freld.Name = "textBox_input_freld";
            this.textBox_input_freld.Size = new System.Drawing.Size(670, 55);
            this.textBox_input_freld.TabIndex = 6;
            this.textBox_input_freld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_input_freld_KeyDown);
            // 
            // textBox_chat
            // 
            this.textBox_chat.Location = new System.Drawing.Point(12, 36);
            this.textBox_chat.Multiline = true;
            this.textBox_chat.Name = "textBox_chat";
            this.textBox_chat.Size = new System.Drawing.Size(776, 341);
            this.textBox_chat.TabIndex = 7;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(688, 383);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(100, 58);
            this.send_button.TabIndex = 8;
            this.send_button.Text = "send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(402, 10);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 9;
            this.textBox_name.Text = "ilya";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "your name";
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.textBox_chat);
            this.Controls.Add(this.textBox_input_freld);
            this.Controls.Add(this.label_server_ip);
            this.Controls.Add(this.label_server_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.connect_button);
            this.Name = "ClientWindow";
            this.Text = "ClientWindow";
            this.Load += new System.EventHandler(this.ClientWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_server_port;
        private System.Windows.Forms.Label label_server_ip;
        private System.Windows.Forms.TextBox textBox_input_freld;
        private System.Windows.Forms.TextBox textBox_chat;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
    }
}