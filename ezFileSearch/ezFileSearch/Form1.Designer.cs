namespace ezFileSearch
{
    partial class form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.panel_general = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_editor = new System.Windows.Forms.ComboBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.label_find_files = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_patternList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_locationList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_serverList = new System.Windows.Forms.TextBox();
            this.panel_dynamic = new System.Windows.Forms.Panel();
            this.panel_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_general
            // 
            this.panel_general.BackColor = System.Drawing.Color.Transparent;
            this.panel_general.Controls.Add(this.label4);
            this.panel_general.Controls.Add(this.cb_editor);
            this.panel_general.Controls.Add(this.btn_test);
            this.panel_general.Controls.Add(this.label_find_files);
            this.panel_general.Controls.Add(this.pictureBox1);
            this.panel_general.Controls.Add(this.label3);
            this.panel_general.Controls.Add(this.tb_patternList);
            this.panel_general.Controls.Add(this.label2);
            this.panel_general.Controls.Add(this.tb_locationList);
            this.panel_general.Controls.Add(this.label1);
            this.panel_general.Controls.Add(this.tb_serverList);
            this.panel_general.Location = new System.Drawing.Point(12, 12);
            this.panel_general.Name = "panel_general";
            this.panel_general.Size = new System.Drawing.Size(363, 408);
            this.panel_general.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "editor";
            // 
            // cb_editor
            // 
            this.cb_editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cb_editor.ForeColor = System.Drawing.Color.White;
            this.cb_editor.FormattingEnabled = true;
            this.cb_editor.Items.AddRange(new object[] {
            "Atom",
            "Notepad++",
            "Sublime"});
            this.cb_editor.Location = new System.Drawing.Point(3, 373);
            this.cb_editor.Name = "cb_editor";
            this.cb_editor.Size = new System.Drawing.Size(357, 28);
            this.cb_editor.TabIndex = 11;
            this.cb_editor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_editor_KeyPress);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(204, 341);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(49, 23);
            this.btn_test.TabIndex = 8;
            this.btn_test.Text = "test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Visible = false;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // label_find_files
            // 
            this.label_find_files.AutoSize = true;
            this.label_find_files.BackColor = System.Drawing.Color.Transparent;
            this.label_find_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_find_files.ForeColor = System.Drawing.Color.White;
            this.label_find_files.Location = new System.Drawing.Point(271, 344);
            this.label_find_files.Name = "label_find_files";
            this.label_find_files.Size = new System.Drawing.Size(77, 20);
            this.label_find_files.TabIndex = 10;
            this.label_find_files.Text = "find files";
            this.label_find_files.Click += new System.EventHandler(this.label_find_files_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "file patterns";
            // 
            // tb_patternList
            // 
            this.tb_patternList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_patternList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_patternList.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_patternList.Location = new System.Drawing.Point(3, 276);
            this.tb_patternList.Multiline = true;
            this.tb_patternList.Name = "tb_patternList";
            this.tb_patternList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_patternList.Size = new System.Drawing.Size(357, 59);
            this.tb_patternList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "locations";
            // 
            // tb_locationList
            // 
            this.tb_locationList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_locationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_locationList.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_locationList.Location = new System.Drawing.Point(3, 192);
            this.tb_locationList.Multiline = true;
            this.tb_locationList.Name = "tb_locationList";
            this.tb_locationList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_locationList.Size = new System.Drawing.Size(357, 58);
            this.tb_locationList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "servers";
            // 
            // tb_serverList
            // 
            this.tb_serverList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_serverList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_serverList.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_serverList.Location = new System.Drawing.Point(3, 23);
            this.tb_serverList.Multiline = true;
            this.tb_serverList.Name = "tb_serverList";
            this.tb_serverList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_serverList.Size = new System.Drawing.Size(357, 143);
            this.tb_serverList.TabIndex = 0;
            // 
            // panel_dynamic
            // 
            this.panel_dynamic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dynamic.AutoScroll = true;
            this.panel_dynamic.Location = new System.Drawing.Point(381, 12);
            this.panel_dynamic.Name = "panel_dynamic";
            this.panel_dynamic.Size = new System.Drawing.Size(407, 409);
            this.panel_dynamic.TabIndex = 7;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.panel_dynamic);
            this.Controls.Add(this.panel_general);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.Text = "ezFileSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_main_FormClosing);
            this.Load += new System.EventHandler(this.form_main_Load);
            this.panel_general.ResumeLayout(false);
            this.panel_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_general;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_serverList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_patternList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_locationList;
        private System.Windows.Forms.Panel panel_dynamic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_find_files;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_editor;
    }
}

