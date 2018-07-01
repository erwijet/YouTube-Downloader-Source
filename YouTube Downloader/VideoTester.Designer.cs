namespace YouTube_Downloader
{
    partial class VideoTester
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
            this.tb_urlPath = new System.Windows.Forms.TextBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url:";
            // 
            // tb_urlPath
            // 
            this.tb_urlPath.Location = new System.Drawing.Point(42, 10);
            this.tb_urlPath.Name = "tb_urlPath";
            this.tb_urlPath.Size = new System.Drawing.Size(282, 20);
            this.tb_urlPath.TabIndex = 1;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(168, 39);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 2;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(249, 39);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Close";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // VideoTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 72);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.tb_urlPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VideoTester";
            this.Text = "Video Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_urlPath;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_exit;
    }
}