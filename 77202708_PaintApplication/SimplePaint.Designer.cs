namespace _77202708_PaintApplication
{
    partial class SimplePaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplePaint));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.toolFillRectangle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolRectangle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolLine = new System.Windows.Forms.Label();
            this.toolFillPolygon = new System.Windows.Forms.Label();
            this.toolFillCircle = new System.Windows.Forms.Label();
            this.toolColor = new System.Windows.Forms.Label();
            this.toolPolygon = new System.Windows.Forms.Label();
            this.toolCircle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(112, 397);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(899, 46);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCommand
            // 
            this.txtCommand.BackColor = System.Drawing.Color.MintCream;
            this.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCommand.Location = new System.Drawing.Point(112, 443);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(899, 46);
            this.txtCommand.TabIndex = 12;
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.SlateGray;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvas.Location = new System.Drawing.Point(123, 7);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(821, 421);
            this.panelCanvas.TabIndex = 11;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(-1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToolBox";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolRectangle
            // 
            this.toolRectangle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolRectangle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolRectangle.ForeColor = System.Drawing.SystemColors.Info;
            this.toolRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolRectangle.Image")));
            this.toolRectangle.Location = new System.Drawing.Point(20, 29);
            this.toolRectangle.Name = "toolRectangle";
            this.toolRectangle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolRectangle.Size = new System.Drawing.Size(47, 29);
            this.toolRectangle.TabIndex = 5;
            this.toolRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.toolLine);
            this.panel1.Controls.Add(this.toolFillPolygon);
            this.panel1.Controls.Add(this.toolFillCircle);
            this.panel1.Controls.Add(this.toolFillRectangle);
            this.panel1.Controls.Add(this.toolColor);
            this.panel1.Controls.Add(this.toolPolygon);
            this.panel1.Controls.Add(this.toolCircle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolRectangle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(112, 489);
            this.panel1.TabIndex = 14;
            // 
            // toolLine
            // 
            this.toolLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolLine.ForeColor = System.Drawing.SystemColors.Info;
            this.toolLine.Image = ((System.Drawing.Image)(resources.GetObject("toolLine.Image")));
            this.toolLine.Location = new System.Drawing.Point(-2, 259);
            this.toolLine.Name = "toolLine";
            this.toolLine.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolLine.Size = new System.Drawing.Size(113, 28);
            this.toolLine.TabIndex = 12;
            this.toolLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // toolColor
            // 
            this.toolColor.BackColor = System.Drawing.Color.OrangeRed;
            this.toolColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolColor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolColor.ForeColor = System.Drawing.SystemColors.Info;
            this.toolColor.Location = new System.Drawing.Point(-1, 301);
            this.toolColor.Name = "toolColor";
            this.toolColor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolColor.Size = new System.Drawing.Size(113, 28);
            this.toolColor.TabIndex = 8;
            this.toolColor.Text = "Change Color";
            this.toolColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolPolygon
            // 
            this.toolPolygon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolPolygon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolPolygon.ForeColor = System.Drawing.SystemColors.Info;
            this.toolPolygon.Image = ((System.Drawing.Image)(resources.GetObject("toolPolygon.Image")));
            this.toolPolygon.Location = new System.Drawing.Point(26, 174);
            this.toolPolygon.Name = "toolPolygon";
            this.toolPolygon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolPolygon.Size = new System.Drawing.Size(52, 28);
            this.toolPolygon.TabIndex = 7;
            this.toolPolygon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolCircle
            // 
            this.toolCircle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolCircle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolCircle.ForeColor = System.Drawing.SystemColors.Info;
            this.toolCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolCircle.Image")));
            this.toolCircle.Location = new System.Drawing.Point(17, 108);
            this.toolCircle.Name = "toolCircle";
            this.toolCircle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolCircle.Size = new System.Drawing.Size(50, 28);
            this.toolCircle.TabIndex = 6;
            this.toolCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SimplePaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 489);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.panel1);
            this.Name = "SimplePaint";
            this.Text = "SimplePaint";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Label toolFillRectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toolRectangle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label toolLine;
        private System.Windows.Forms.Label toolFillPolygon;
        private System.Windows.Forms.Label toolFillCircle;
        private System.Windows.Forms.Label toolColor;
        private System.Windows.Forms.Label toolPolygon;
        private System.Windows.Forms.Label toolCircle;
    }
}