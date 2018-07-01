namespace YouTube_Downloader
{
    partial class Network_Test
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
            this.btn_ping = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Traceback = new System.Windows.Forms.GroupBox();
            this.l_traceback = new System.Windows.Forms.ListBox();
            this.Traceback.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ping
            // 
            this.btn_ping.Location = new System.Drawing.Point(266, 215);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(75, 23);
            this.btn_ping.TabIndex = 0;
            this.btn_ping.Text = "Ping";
            this.btn_ping.UseVisualStyleBackColor = true;
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Traceback
            // 
            this.Traceback.Controls.Add(this.l_traceback);
            this.Traceback.Location = new System.Drawing.Point(13, 13);
            this.Traceback.Name = "Traceback";
            this.Traceback.Size = new System.Drawing.Size(409, 196);
            this.Traceback.TabIndex = 2;
            this.Traceback.TabStop = false;
            this.Traceback.Text = "Reply";
            // 
            // l_traceback
            // 
            this.l_traceback.FormattingEnabled = true;
            this.l_traceback.Location = new System.Drawing.Point(7, 20);
            this.l_traceback.Name = "l_traceback";
            this.l_traceback.Size = new System.Drawing.Size(396, 160);
            this.l_traceback.TabIndex = 0;
            // 
            // Network_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 250);
            this.Controls.Add(this.Traceback);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ping);
            this.Name = "Network_Test";
            this.Text = "Network Test";
            this.Traceback.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ping;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Traceback;
        private System.Windows.Forms.ListBox l_traceback;
    }
}