namespace _7202708_PaintApplication
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.VE = new System.Windows.Forms.PictureBox();
            this.undo = new System.Windows.Forms.Button();
            this.ctr3 = new System.Windows.Forms.Button();
            this.ctr4 = new System.Windows.Forms.Button();
            this.ctr2 = new System.Windows.Forms.Button();
            this.ctr5 = new System.Windows.Forms.Button();
            this.ctr1 = new System.Windows.Forms.Button();
            this.ctr10 = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.special = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.clrall = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Selectbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VE)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VE
            // 
            this.VE.BackColor = System.Drawing.Color.White;
            this.VE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VE.Location = new System.Drawing.Point(540, 103);
            this.VE.Name = "VE";
            this.VE.Size = new System.Drawing.Size(422, 405);
            this.VE.TabIndex = 50;
            this.VE.TabStop = false;
            this.VE.Click += new System.EventHandler(this.main_click);
            this.VE.Paint += new System.Windows.Forms.PaintEventHandler(this.click_paint);
            this.VE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.click_mouseDown);
            this.VE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clcik_mouseMove);
            this.VE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.click_mouseUp);
            // 
            // undo
            // 
            this.undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undo.Image = ((System.Drawing.Image)(resources.GetObject("undo.Image")));
            this.undo.Location = new System.Drawing.Point(540, 28);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(44, 33);
            this.undo.TabIndex = 51;
            this.undo.Text = " ";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // ctr3
            // 
            this.ctr3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctr3.Image = ((System.Drawing.Image)(resources.GetObject("ctr3.Image")));
            this.ctr3.Location = new System.Drawing.Point(590, 65);
            this.ctr3.Name = "ctr3";
            this.ctr3.Size = new System.Drawing.Size(44, 33);
            this.ctr3.TabIndex = 52;
            this.ctr3.Text = " ";
            this.ctr3.UseVisualStyleBackColor = true;
            this.ctr3.Click += new System.EventHandler(this.click_triangle);
            // 
            // ctr4
            // 
            this.ctr4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctr4.Image = ((System.Drawing.Image)(resources.GetObject("ctr4.Image")));
            this.ctr4.Location = new System.Drawing.Point(640, 65);
            this.ctr4.Name = "ctr4";
            this.ctr4.Size = new System.Drawing.Size(44, 33);
            this.ctr4.TabIndex = 53;
            this.ctr4.Text = " ";
            this.ctr4.UseVisualStyleBackColor = true;
            this.ctr4.Click += new System.EventHandler(this.click_circle);
            // 
            // ctr2
            // 
            this.ctr2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctr2.Image = ((System.Drawing.Image)(resources.GetObject("ctr2.Image")));
            this.ctr2.Location = new System.Drawing.Point(690, 65);
            this.ctr2.Name = "ctr2";
            this.ctr2.Size = new System.Drawing.Size(44, 33);
            this.ctr2.TabIndex = 54;
            this.ctr2.Text = " ";
            this.ctr2.UseVisualStyleBackColor = true;
            this.ctr2.Click += new System.EventHandler(this.click_eclip);
            // 
            // ctr5
            // 
            this.ctr5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctr5.Image = ((System.Drawing.Image)(resources.GetObject("ctr5.Image")));
            this.ctr5.Location = new System.Drawing.Point(740, 65);
            this.ctr5.Name = "ctr5";
            this.ctr5.Size = new System.Drawing.Size(44, 33);
            this.ctr5.TabIndex = 55;
            this.ctr5.Text = " ";
            this.ctr5.UseVisualStyleBackColor = true;
            this.ctr5.Click += new System.EventHandler(this.click_rect);
            // 
            // ctr1
            // 
            this.ctr1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctr1.Image = ((System.Drawing.Image)(resources.GetObject("ctr1.Image")));
            this.ctr1.Location = new System.Drawing.Point(540, 65);
            this.ctr1.Name = "ctr1";
            this.ctr1.Size = new System.Drawing.Size(44, 33);
            this.ctr1.TabIndex = 56;
            this.ctr1.Text = " ";
            this.ctr1.UseVisualStyleBackColor = true;
            this.ctr1.Click += new System.EventHandler(this.ctr1_Click);
            // 
            // ctr10
            // 
            this.ctr10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctr10.Image = ((System.Drawing.Image)(resources.GetObject("ctr10.Image")));
            this.ctr10.Location = new System.Drawing.Point(590, 26);
            this.ctr10.Name = "ctr10";
            this.ctr10.Size = new System.Drawing.Size(44, 33);
            this.ctr10.TabIndex = 57;
            this.ctr10.Text = " ";
            this.ctr10.UseVisualStyleBackColor = true;
            this.ctr10.Click += new System.EventHandler(this.click_brush);
            // 
            // Normal
            // 
            this.Normal.BackColor = System.Drawing.Color.RosyBrown;
            this.Normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Normal.Location = new System.Drawing.Point(796, 26);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(44, 28);
            this.Normal.TabIndex = 58;
            this.Normal.Text = "NOR";
            this.Normal.UseVisualStyleBackColor = false;
            this.Normal.Click += new System.EventHandler(this.normal_key);
            // 
            // special
            // 
            this.special.BackColor = System.Drawing.Color.OrangeRed;
            this.special.Cursor = System.Windows.Forms.Cursors.Hand;
            this.special.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.special.Location = new System.Drawing.Point(846, 26);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(44, 28);
            this.special.TabIndex = 59;
            this.special.Text = "SPEC";
            this.special.UseVisualStyleBackColor = false;
            this.special.Click += new System.EventHandler(this.special_key);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button14.Location = new System.Drawing.Point(896, 38);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 23);
            this.button14.TabIndex = 60;
            this.button14.Text = " ";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btn_black);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button15.Location = new System.Drawing.Point(897, 67);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 23);
            this.button15.TabIndex = 61;
            this.button15.Text = " ";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btn_blue);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(932, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_yellow);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Green;
            this.button16.Location = new System.Drawing.Point(933, 67);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(30, 23);
            this.button16.TabIndex = 63;
            this.button16.Text = " ";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btn_green);
            // 
            // clrall
            // 
            this.clrall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clrall.Location = new System.Drawing.Point(796, 67);
            this.clrall.Name = "clrall";
            this.clrall.Size = new System.Drawing.Size(66, 31);
            this.clrall.TabIndex = 64;
            this.clrall.Text = "Clear All";
            this.clrall.UseVisualStyleBackColor = true;
            this.clrall.Click += new System.EventHandler(this.clrall_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 65;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Selectbtn
            // 
            this.Selectbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Selectbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Selectbtn.Image = ((System.Drawing.Image)(resources.GetObject("Selectbtn.Image")));
            this.Selectbtn.Location = new System.Drawing.Point(640, 26);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(44, 33);
            this.Selectbtn.TabIndex = 66;
            this.Selectbtn.UseVisualStyleBackColor = false;
            this.Selectbtn.Click += new System.EventHandler(this.btn_select);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebtn.Enabled = false;
            this.Deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("Deletebtn.Image")));
            this.Deletebtn.Location = new System.Drawing.Point(690, 27);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(44, 32);
            this.Deletebtn.TabIndex = 67;
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(445, 405);
            this.richTextBox1.TabIndex = 68;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(150, 65);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 69;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 520);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Selectbtn);
            this.Controls.Add(this.clrall);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.special);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.ctr10);
            this.Controls.Add(this.ctr1);
            this.Controls.Add(this.ctr5);
            this.Controls.Add(this.ctr2);
            this.Controls.Add(this.ctr4);
            this.Controls.Add(this.ctr3);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.VE);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VE)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VE;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button ctr3;
        private System.Windows.Forms.Button ctr4;
        private System.Windows.Forms.Button ctr2;
        private System.Windows.Forms.Button ctr5;
        private System.Windows.Forms.Button ctr1;
        private System.Windows.Forms.Button ctr10;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button special;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button clrall;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button Selectbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_run;
    }
}

