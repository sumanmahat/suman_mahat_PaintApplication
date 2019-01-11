namespace _77202708_PaintApplication
{
    partial class GraphicalProgramming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicalProgramming));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_line = new System.Windows.Forms.Label();
            this.toolFillPolygon = new System.Windows.Forms.Label();
            this.toolFillCircle = new System.Windows.Forms.Label();
            this.toolFillRectangle = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_polygon = new System.Windows.Forms.Label();
            this.lbl_circle = new System.Windows.Forms.Label();
            this.lbl_rectangle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_command = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.lbl_line);
            this.panel1.Controls.Add(this.toolFillPolygon);
            this.panel1.Controls.Add(this.toolFillCircle);
            this.panel1.Controls.Add(this.toolFillRectangle);
            this.panel1.Controls.Add(this.lbl_color);
            this.panel1.Controls.Add(this.lbl_polygon);
            this.panel1.Controls.Add(this.lbl_circle);
            this.panel1.Controls.Add(this.lbl_rectangle);
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(105, 437);
            this.panel1.TabIndex = 18;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(6, 387);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 36);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_line
            // 
            this.lbl_line.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_line.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_line.Image = ((System.Drawing.Image)(resources.GetObject("lbl_line.Image")));
            this.lbl_line.Location = new System.Drawing.Point(21, 259);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_line.Size = new System.Drawing.Size(51, 28);
            this.lbl_line.TabIndex = 12;
            this.lbl_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_line.Click += new System.EventHandler(this.toolLine_Click);
            // 
            // toolFillPolygon
            // 
            this.toolFillPolygon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolFillPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolFillPolygon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolFillPolygon.ForeColor = System.Drawing.SystemColors.Info;
            this.toolFillPolygon.Location = new System.Drawing.Point(0, 216);
            this.toolFillPolygon.Name = "toolFillPolygon";
            this.toolFillPolygon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolFillPolygon.Size = new System.Drawing.Size(113, 28);
            this.toolFillPolygon.TabIndex = 11;
            this.toolFillPolygon.Text = "Fill Polygon";
            this.toolFillPolygon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolFillPolygon.Click += new System.EventHandler(this.toolFillPolygon_Click);
            // 
            // toolFillCircle
            // 
            this.toolFillCircle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolFillCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolFillCircle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolFillCircle.ForeColor = System.Drawing.SystemColors.Info;
            this.toolFillCircle.Location = new System.Drawing.Point(3, 146);
            this.toolFillCircle.Name = "toolFillCircle";
            this.toolFillCircle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolFillCircle.Size = new System.Drawing.Size(113, 28);
            this.toolFillCircle.TabIndex = 10;
            this.toolFillCircle.Text = "Fill Circle";
            this.toolFillCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolFillCircle.Click += new System.EventHandler(this.toolFillCircle_Click);
            // 
            // toolFillRectangle
            // 
            this.toolFillRectangle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolFillRectangle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolFillRectangle.ForeColor = System.Drawing.SystemColors.Info;
            this.toolFillRectangle.Location = new System.Drawing.Point(-1, 67);
            this.toolFillRectangle.Name = "toolFillRectangle";
            this.toolFillRectangle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolFillRectangle.Size = new System.Drawing.Size(112, 29);
            this.toolFillRectangle.TabIndex = 9;
            this.toolFillRectangle.Text = "Fill Rectangle";
            this.toolFillRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_color
            // 
            this.lbl_color.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_color.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_color.Image = ((System.Drawing.Image)(resources.GetObject("lbl_color.Image")));
            this.lbl_color.Location = new System.Drawing.Point(20, 310);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_color.Size = new System.Drawing.Size(49, 28);
            this.lbl_color.TabIndex = 8;
            this.lbl_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_color.Click += new System.EventHandler(this.toolColor_Click);
            // 
            // lbl_polygon
            // 
            this.lbl_polygon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_polygon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_polygon.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_polygon.Image = ((System.Drawing.Image)(resources.GetObject("lbl_polygon.Image")));
            this.lbl_polygon.Location = new System.Drawing.Point(20, 174);
            this.lbl_polygon.Name = "lbl_polygon";
            this.lbl_polygon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_polygon.Size = new System.Drawing.Size(52, 28);
            this.lbl_polygon.TabIndex = 7;
            this.lbl_polygon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_polygon.Click += new System.EventHandler(this.toolPolygon_Click);
            // 
            // lbl_circle
            // 
            this.lbl_circle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_circle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_circle.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_circle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_circle.Image")));
            this.lbl_circle.Location = new System.Drawing.Point(20, 107);
            this.lbl_circle.Name = "lbl_circle";
            this.lbl_circle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_circle.Size = new System.Drawing.Size(50, 28);
            this.lbl_circle.TabIndex = 6;
            this.lbl_circle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_circle.Click += new System.EventHandler(this.toolCircle_Click);
            // 
            // lbl_rectangle
            // 
            this.lbl_rectangle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_rectangle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rectangle.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_rectangle.Image")));
            this.lbl_rectangle.Location = new System.Drawing.Point(20, 29);
            this.lbl_rectangle.Name = "lbl_rectangle";
            this.lbl_rectangle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_rectangle.Size = new System.Drawing.Size(49, 29);
            this.lbl_rectangle.TabIndex = 5;
            this.lbl_rectangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_command
            // 
            this.lbl_command.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_command.ForeColor = System.Drawing.Color.Green;
            this.lbl_command.Location = new System.Drawing.Point(0, 536);
            this.lbl_command.Name = "lbl_command";
            this.lbl_command.Size = new System.Drawing.Size(1081, 46);
            this.lbl_command.TabIndex = 17;
            this.lbl_command.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCommand
            // 
            this.txtCommand.BackColor = System.Drawing.Color.Silver;
            this.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCommand.Location = new System.Drawing.Point(0, 582);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(1081, 21);
            this.txtCommand.TabIndex = 16;
            this.txtCommand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyUp);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.SlateGray;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvas.Location = new System.Drawing.Point(135, 96);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(934, 437);
            this.panelCanvas.TabIndex = 15;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint);
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(135, 65);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(75, 23);
            this.btn_openfile.TabIndex = 20;
            this.btn_openfile.Text = "OpenFile";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "SaveFile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // GraphicalProgramming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_openfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_command);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.panelCanvas);
            this.Name = "GraphicalProgramming";
            this.Text = "GraphicalProgramming";
            this.Load += new System.EventHandler(this.GraphicalProgramming_Load);
            this.panel1.ResumeLayout(false);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.Label toolFillPolygon;
        private System.Windows.Forms.Label toolFillCircle;
        private System.Windows.Forms.Label toolFillRectangle;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_polygon;
        private System.Windows.Forms.Label lbl_circle;
        private System.Windows.Forms.Label lbl_rectangle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_command;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Button btn_clear;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}