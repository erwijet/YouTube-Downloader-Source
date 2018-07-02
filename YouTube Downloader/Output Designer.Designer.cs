namespace YouTube_Downloader
{
    partial class Output_Designer
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.ll_browse = new System.Windows.Forms.LinkLabel();
            this.rb_folder = new System.Windows.Forms.RadioButton();
            this.rb_ftp = new System.Windows.Forms.RadioButton();
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_done = new System.Windows.Forms.Button();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path: ";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(54, 10);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(347, 20);
            this.tb_path.TabIndex = 1;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // ll_browse
            // 
            this.ll_browse.AutoSize = true;
            this.ll_browse.Location = new System.Drawing.Point(360, 36);
            this.ll_browse.Name = "ll_browse";
            this.ll_browse.Size = new System.Drawing.Size(42, 13);
            this.ll_browse.TabIndex = 2;
            this.ll_browse.TabStop = true;
            this.ll_browse.Text = "Browse";
            this.ll_browse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_browse_LinkClicked);
            // 
            // rb_folder
            // 
            this.rb_folder.AutoSize = true;
            this.rb_folder.Checked = true;
            this.rb_folder.Location = new System.Drawing.Point(16, 54);
            this.rb_folder.Name = "rb_folder";
            this.rb_folder.Size = new System.Drawing.Size(67, 17);
            this.rb_folder.TabIndex = 3;
            this.rb_folder.TabStop = true;
            this.rb_folder.Text = "Directory";
            this.rb_folder.UseVisualStyleBackColor = true;
            this.rb_folder.CheckedChanged += new System.EventHandler(this.rb_folder_CheckedChanged);
            // 
            // rb_ftp
            // 
            this.rb_ftp.AutoSize = true;
            this.rb_ftp.Location = new System.Drawing.Point(16, 77);
            this.rb_ftp.Name = "rb_ftp";
            this.rb_ftp.Size = new System.Drawing.Size(70, 17);
            this.rb_ftp.TabIndex = 4;
            this.rb_ftp.Text = "FTP Path";
            this.rb_ftp.UseVisualStyleBackColor = true;
            // 
            // gb_login
            // 
            this.gb_login.Controls.Add(this.label3);
            this.gb_login.Controls.Add(this.label2);
            this.gb_login.Controls.Add(this.tb_pass);
            this.gb_login.Controls.Add(this.tb_user);
            this.gb_login.Location = new System.Drawing.Point(92, 54);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(201, 75);
            this.gb_login.TabIndex = 5;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "Login Info";
            this.gb_login.Visible = false;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(81, 18);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(114, 20);
            this.tb_user.TabIndex = 0;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(81, 44);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(114, 20);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(327, 111);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(75, 23);
            this.btn_done.TabIndex = 6;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // Output_Designer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 146);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.gb_login);
            this.Controls.Add(this.rb_ftp);
            this.Controls.Add(this.rb_folder);
            this.Controls.Add(this.ll_browse);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Output_Designer";
            this.Text = "Output Designer";
            this.Load += new System.EventHandler(this.Output_Designer_Load);
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.LinkLabel ll_browse;
        private System.Windows.Forms.RadioButton rb_folder;
        private System.Windows.Forms.RadioButton rb_ftp;
        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button btn_done;
    }
}