namespace YouTube_Downloader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_youtube = new System.Windows.Forms.RadioButton();
            this.rb_yps = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ll_testNetwork = new System.Windows.Forms.LinkLabel();
            this.ll_testVideo = new System.Windows.Forms.LinkLabel();
            this.ll_createYPS = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ll_editfilepath = new System.Windows.Forms.LinkLabel();
            this.l_filepath = new System.Windows.Forms.Label();
            this.l_filepath_prompt = new System.Windows.Forms.Label();
            this.ll_editYoutubePath = new System.Windows.Forms.LinkLabel();
            this.l_youtubepath = new System.Windows.Forms.Label();
            this.l_youtubepath_prompt = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.cb_singleType = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(411, 96);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // rb_youtube
            // 
            this.rb_youtube.AutoSize = true;
            this.rb_youtube.Checked = true;
            this.rb_youtube.Location = new System.Drawing.Point(6, 18);
            this.rb_youtube.Name = "rb_youtube";
            this.rb_youtube.Size = new System.Drawing.Size(95, 17);
            this.rb_youtube.TabIndex = 2;
            this.rb_youtube.TabStop = true;
            this.rb_youtube.Text = "From YouTube";
            this.toolTip2.SetToolTip(this.rb_youtube, "Direct manual download from YouTube");
            this.rb_youtube.UseVisualStyleBackColor = true;
            // 
            // rb_yps
            // 
            this.rb_yps.AutoSize = true;
            this.rb_yps.Location = new System.Drawing.Point(6, 42);
            this.rb_yps.Name = "rb_yps";
            this.rb_yps.Size = new System.Drawing.Size(91, 17);
            this.rb_yps.TabIndex = 3;
            this.rb_yps.Text = "From YPS File";
            this.toolTip2.SetToolTip(this.rb_yps, "Use a YPS file to determine YouTube paths and Output Types");
            this.rb_yps.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ll_testNetwork);
            this.groupBox2.Controls.Add(this.ll_testVideo);
            this.groupBox2.Controls.Add(this.ll_createYPS);
            this.groupBox2.Location = new System.Drawing.Point(435, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 65);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // ll_testNetwork
            // 
            this.ll_testNetwork.AutoSize = true;
            this.ll_testNetwork.Location = new System.Drawing.Point(6, 42);
            this.ll_testNetwork.Name = "ll_testNetwork";
            this.ll_testNetwork.Size = new System.Drawing.Size(128, 13);
            this.ll_testNetwork.TabIndex = 2;
            this.ll_testNetwork.TabStop = true;
            this.ll_testNetwork.Text = "Test Network Connection";
            // 
            // ll_testVideo
            // 
            this.ll_testVideo.AutoSize = true;
            this.ll_testVideo.Location = new System.Drawing.Point(6, 29);
            this.ll_testVideo.Name = "ll_testVideo";
            this.ll_testVideo.Size = new System.Drawing.Size(83, 13);
            this.ll_testVideo.TabIndex = 1;
            this.ll_testVideo.TabStop = true;
            this.ll_testVideo.Text = "Test Video Path";
            // 
            // ll_createYPS
            // 
            this.ll_createYPS.AutoSize = true;
            this.ll_createYPS.Location = new System.Drawing.Point(6, 16);
            this.ll_createYPS.Name = "ll_createYPS";
            this.ll_createYPS.Size = new System.Drawing.Size(81, 13);
            this.ll_createYPS.TabIndex = 0;
            this.ll_createYPS.TabStop = true;
            this.ll_createYPS.Text = "Create YPS File";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ll_editfilepath);
            this.groupBox3.Controls.Add(this.l_filepath);
            this.groupBox3.Controls.Add(this.l_filepath_prompt);
            this.groupBox3.Controls.Add(this.ll_editYoutubePath);
            this.groupBox3.Controls.Add(this.l_youtubepath);
            this.groupBox3.Controls.Add(this.l_youtubepath_prompt);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 97);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Source";
            // 
            // ll_editfilepath
            // 
            this.ll_editfilepath.AutoSize = true;
            this.ll_editfilepath.Enabled = false;
            this.ll_editfilepath.Location = new System.Drawing.Point(536, 41);
            this.ll_editfilepath.Name = "ll_editfilepath";
            this.ll_editfilepath.Size = new System.Drawing.Size(25, 13);
            this.ll_editfilepath.TabIndex = 10;
            this.ll_editfilepath.TabStop = true;
            this.ll_editfilepath.Text = "Edit";
            // 
            // l_filepath
            // 
            this.l_filepath.AutoSize = true;
            this.l_filepath.BackColor = System.Drawing.Color.Transparent;
            this.l_filepath.Enabled = false;
            this.l_filepath.ForeColor = System.Drawing.Color.Red;
            this.l_filepath.Location = new System.Drawing.Point(210, 41);
            this.l_filepath.Name = "l_filepath";
            this.l_filepath.Size = new System.Drawing.Size(22, 13);
            this.l_filepath.TabIndex = 12;
            this.l_filepath.Text = "C:\\";
            // 
            // l_filepath_prompt
            // 
            this.l_filepath_prompt.AutoSize = true;
            this.l_filepath_prompt.Enabled = false;
            this.l_filepath_prompt.Location = new System.Drawing.Point(131, 41);
            this.l_filepath_prompt.Name = "l_filepath_prompt";
            this.l_filepath_prompt.Size = new System.Drawing.Size(51, 13);
            this.l_filepath_prompt.TabIndex = 11;
            this.l_filepath_prompt.Text = "File Path:";
            // 
            // ll_editYoutubePath
            // 
            this.ll_editYoutubePath.AutoSize = true;
            this.ll_editYoutubePath.Location = new System.Drawing.Point(536, 20);
            this.ll_editYoutubePath.Name = "ll_editYoutubePath";
            this.ll_editYoutubePath.Size = new System.Drawing.Size(25, 13);
            this.ll_editYoutubePath.TabIndex = 3;
            this.ll_editYoutubePath.TabStop = true;
            this.ll_editYoutubePath.Text = "Edit";
            // 
            // l_youtubepath
            // 
            this.l_youtubepath.AutoSize = true;
            this.l_youtubepath.BackColor = System.Drawing.Color.Transparent;
            this.l_youtubepath.ForeColor = System.Drawing.Color.Red;
            this.l_youtubepath.Location = new System.Drawing.Point(210, 20);
            this.l_youtubepath.Name = "l_youtubepath";
            this.l_youtubepath.Size = new System.Drawing.Size(61, 13);
            this.l_youtubepath.TabIndex = 9;
            this.l_youtubepath.Text = "Path Empty";
            // 
            // l_youtubepath_prompt
            // 
            this.l_youtubepath_prompt.AutoSize = true;
            this.l_youtubepath_prompt.Location = new System.Drawing.Point(131, 20);
            this.l_youtubepath_prompt.Name = "l_youtubepath_prompt";
            this.l_youtubepath_prompt.Size = new System.Drawing.Size(82, 13);
            this.l_youtubepath_prompt.TabIndex = 8;
            this.l_youtubepath_prompt.Text = "YouTube Path: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_yps);
            this.groupBox4.Controls.Add(this.rb_youtube);
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 71);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Source Type";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_edit);
            this.groupBox5.Controls.Add(this.btn_del);
            this.groupBox5.Controls.Add(this.btn_add);
            this.groupBox5.Controls.Add(this.listBox2);
            this.groupBox5.Location = new System.Drawing.Point(12, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(567, 237);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Outputs";
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(65, 206);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(53, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btn_edit, "Edit selected Output");
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Enabled = false;
            this.btn_del.Location = new System.Drawing.Point(36, 206);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(23, 23);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "-";
            this.toolTip1.SetToolTip(this.btn_del, "Remove Output");
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(7, 206);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(23, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "+";
            this.toolTip1.SetToolTip(this.btn_add, "Add Output");
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(7, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(554, 173);
            this.listBox2.TabIndex = 0;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(435, 450);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(144, 23);
            this.btn_convert.TabIndex = 7;
            this.btn_convert.Text = "Start Conversion";
            this.btn_convert.UseVisualStyleBackColor = true;
            // 
            // cb_singleType
            // 
            this.cb_singleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_singleType.FormattingEnabled = true;
            this.cb_singleType.Items.AddRange(new object[] {
            "Audio",
            "Video",
            "Mixed"});
            this.cb_singleType.Location = new System.Drawing.Point(436, 423);
            this.cb_singleType.Name = "cb_singleType";
            this.cb_singleType.Size = new System.Drawing.Size(143, 21);
            this.cb_singleType.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 485);
            this.Controls.Add(this.cb_singleType);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "YouTube Downloader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_youtube;
        private System.Windows.Forms.RadioButton rb_yps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel ll_testNetwork;
        private System.Windows.Forms.LinkLabel ll_testVideo;
        private System.Windows.Forms.LinkLabel ll_createYPS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel ll_editfilepath;
        private System.Windows.Forms.Label l_filepath;
        private System.Windows.Forms.Label l_filepath_prompt;
        private System.Windows.Forms.LinkLabel ll_editYoutubePath;
        private System.Windows.Forms.Label l_youtubepath;
        private System.Windows.Forms.Label l_youtubepath_prompt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.ComboBox cb_singleType;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

