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
            this.label_replaceText = new System.Windows.Forms.Label();
            this.pb_replaceText = new System.Windows.Forms.PictureBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.label_findFiles = new System.Windows.Forms.Label();
            this.pb_findFiles = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_newText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_editor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_patternList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_locationList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_serverList = new System.Windows.Forms.TextBox();
            this.panel_dynamic = new System.Windows.Forms.Panel();
            this.panel_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_replaceText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_findFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_general
            // 
            this.panel_general.BackColor = System.Drawing.Color.Transparent;
            this.panel_general.Controls.Add(this.label_replaceText);
            this.panel_general.Controls.Add(this.pb_replaceText);
            this.panel_general.Controls.Add(this.btn_test);
            this.panel_general.Controls.Add(this.label_findFiles);
            this.panel_general.Controls.Add(this.pb_findFiles);
            this.panel_general.Controls.Add(this.label6);
            this.panel_general.Controls.Add(this.tb_newText);
            this.panel_general.Controls.Add(this.label5);
            this.panel_general.Controls.Add(this.tb_text);
            this.panel_general.Controls.Add(this.label4);
            this.panel_general.Controls.Add(this.cb_editor);
            this.panel_general.Controls.Add(this.label3);
            this.panel_general.Controls.Add(this.tb_patternList);
            this.panel_general.Controls.Add(this.label2);
            this.panel_general.Controls.Add(this.tb_locationList);
            this.panel_general.Controls.Add(this.label1);
            this.panel_general.Controls.Add(this.tb_serverList);
            this.panel_general.Location = new System.Drawing.Point(12, 12);
            this.panel_general.Name = "panel_general";
            this.panel_general.Size = new System.Drawing.Size(363, 594);
            this.panel_general.TabIndex = 1;
            // 
            // label_replaceText
            // 
            this.label_replaceText.AutoSize = true;
            this.label_replaceText.BackColor = System.Drawing.Color.Transparent;
            this.label_replaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_replaceText.ForeColor = System.Drawing.Color.White;
            this.label_replaceText.Location = new System.Drawing.Point(276, 532);
            this.label_replaceText.Name = "label_replaceText";
            this.label_replaceText.Size = new System.Drawing.Size(68, 20);
            this.label_replaceText.TabIndex = 21;
            this.label_replaceText.Text = "replace";
            this.label_replaceText.Click += new System.EventHandler(this.label_replaceText_Click);
            // 
            // pb_replaceText
            // 
            this.pb_replaceText.Image = ((System.Drawing.Image)(resources.GetObject("pb_replaceText.Image")));
            this.pb_replaceText.Location = new System.Drawing.Point(260, 526);
            this.pb_replaceText.Name = "pb_replaceText";
            this.pb_replaceText.Size = new System.Drawing.Size(101, 32);
            this.pb_replaceText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_replaceText.TabIndex = 20;
            this.pb_replaceText.TabStop = false;
            this.pb_replaceText.Click += new System.EventHandler(this.pb_replaceText_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(185, 535);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(49, 23);
            this.btn_test.TabIndex = 17;
            this.btn_test.Text = "test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Visible = false;
            // 
            // label_findFiles
            // 
            this.label_findFiles.AutoSize = true;
            this.label_findFiles.BackColor = System.Drawing.Color.Transparent;
            this.label_findFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_findFiles.ForeColor = System.Drawing.Color.White;
            this.label_findFiles.Location = new System.Drawing.Point(272, 432);
            this.label_findFiles.Name = "label_findFiles";
            this.label_findFiles.Size = new System.Drawing.Size(77, 20);
            this.label_findFiles.TabIndex = 19;
            this.label_findFiles.Text = "find files";
            this.label_findFiles.Click += new System.EventHandler(this.label_findFiles_Click);
            // 
            // pb_findFiles
            // 
            this.pb_findFiles.Image = ((System.Drawing.Image)(resources.GetObject("pb_findFiles.Image")));
            this.pb_findFiles.Location = new System.Drawing.Point(260, 426);
            this.pb_findFiles.Name = "pb_findFiles";
            this.pb_findFiles.Size = new System.Drawing.Size(101, 32);
            this.pb_findFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_findFiles.TabIndex = 18;
            this.pb_findFiles.TabStop = false;
            this.pb_findFiles.Click += new System.EventHandler(this.pb_findFiles_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "replace text";
            // 
            // tb_newText
            // 
            this.tb_newText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_newText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newText.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_newText.Location = new System.Drawing.Point(3, 461);
            this.tb_newText.Multiline = true;
            this.tb_newText.Name = "tb_newText";
            this.tb_newText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_newText.Size = new System.Drawing.Size(357, 59);
            this.tb_newText.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "text in file";
            // 
            // tb_text
            // 
            this.tb_text.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_text.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_text.Location = new System.Drawing.Point(3, 361);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_text.Size = new System.Drawing.Size(357, 59);
            this.tb_text.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 538);
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
            this.cb_editor.Location = new System.Drawing.Point(3, 561);
            this.cb_editor.Name = "cb_editor";
            this.cb_editor.Size = new System.Drawing.Size(357, 28);
            this.cb_editor.TabIndex = 11;
            this.cb_editor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_editor_KeyPress);
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
            this.panel_dynamic.Size = new System.Drawing.Size(407, 595);
            this.panel_dynamic.TabIndex = 7;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.panel_dynamic);
            this.Controls.Add(this.panel_general);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.Text = "ezFileSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_main_FormClosing);
            this.Load += new System.EventHandler(this.form_main_Load);
            this.panel_general.ResumeLayout(false);
            this.panel_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_replaceText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_findFiles)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_editor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Label label_replaceText;
        private System.Windows.Forms.PictureBox pb_replaceText;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label label_findFiles;
        private System.Windows.Forms.PictureBox pb_findFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_newText;
    }
}

