namespace Weight
{
    partial class Form1
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
            this.btn_hilowcheck = new System.Windows.Forms.Button();
            this.btn_normal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_changelaguage = new System.Windows.Forms.Button();
            this.lbl_version = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_hilowcheck
            // 
            this.btn_hilowcheck.BackColor = System.Drawing.Color.Yellow;
            this.btn_hilowcheck.Location = new System.Drawing.Point(65, 89);
            this.btn_hilowcheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_hilowcheck.Name = "btn_hilowcheck";
            this.btn_hilowcheck.Size = new System.Drawing.Size(166, 68);
            this.btn_hilowcheck.TabIndex = 0;
            this.btn_hilowcheck.Text = "Chế độ kiểm tra HI-Low Check";
            this.btn_hilowcheck.UseVisualStyleBackColor = false;
            this.btn_hilowcheck.Click += new System.EventHandler(this.btn_hilowcheck_Click);
            // 
            // btn_normal
            // 
            this.btn_normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_normal.Location = new System.Drawing.Point(273, 89);
            this.btn_normal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(166, 68);
            this.btn_normal.TabIndex = 1;
            this.btn_normal.Text = "Chế độ chạy thường";
            this.btn_normal.UseVisualStyleBackColor = false;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.setupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.setupToolStripMenuItem.Text = "File";
            // 
            // setupToolStripMenuItem1
            // 
            this.setupToolStripMenuItem1.Name = "setupToolStripMenuItem1";
            this.setupToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.setupToolStripMenuItem1.Text = "Setup";
            this.setupToolStripMenuItem1.Click += new System.EventHandler(this.setupToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_header.Location = new System.Drawing.Point(79, 37);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(343, 31);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = "Hãy lựa chọn chế độ cân!";
            // 
            // btn_changelaguage
            // 
            this.btn_changelaguage.BackColor = System.Drawing.Color.Silver;
            this.btn_changelaguage.Location = new System.Drawing.Point(386, 189);
            this.btn_changelaguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_changelaguage.Name = "btn_changelaguage";
            this.btn_changelaguage.Size = new System.Drawing.Size(128, 38);
            this.btn_changelaguage.TabIndex = 4;
            this.btn_changelaguage.Text = "日本語";
            this.btn_changelaguage.UseVisualStyleBackColor = false;
            this.btn_changelaguage.Click += new System.EventHandler(this.btn_changelaguage_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.Location = new System.Drawing.Point(12, 203);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(51, 20);
            this.lbl_version.TabIndex = 5;
            this.lbl_version.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 232);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.btn_changelaguage);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.btn_normal);
            this.Controls.Add(this.btn_hilowcheck);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm lựa chọn chương trình cân trọng lượng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hilowcheck;
        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_changelaguage;
        private System.Windows.Forms.Label lbl_version;
    }
}

