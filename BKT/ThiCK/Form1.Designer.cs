namespace ThiCK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtLine = new System.Windows.Forms.ToolStripButton();
            this.tbtTriangle = new System.Windows.Forms.ToolStripButton();
            this.tbtRhombus = new System.Windows.Forms.ToolStripButton();
            this.tbtSave = new System.Windows.Forms.ToolStripButton();
            this.tbtOpen = new System.Windows.Forms.ToolStripButton();
            this.tbtContro = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtLine,
            this.tbtTriangle,
            this.tbtRhombus,
            this.tbtSave,
            this.tbtOpen,
            this.tbtContro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(564, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseMove);
            this.toolStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseUp);
            // 
            // tbtLine
            // 
            this.tbtLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtLine.Image = ((System.Drawing.Image)(resources.GetObject("tbtLine.Image")));
            this.tbtLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtLine.Name = "tbtLine";
            this.tbtLine.Size = new System.Drawing.Size(33, 22);
            this.tbtLine.Text = "Line";
            this.tbtLine.Click += new System.EventHandler(this.tbtLine_Click);
            // 
            // tbtTriangle
            // 
            this.tbtTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtTriangle.Image = ((System.Drawing.Image)(resources.GetObject("tbtTriangle.Image")));
            this.tbtTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtTriangle.Name = "tbtTriangle";
            this.tbtTriangle.Size = new System.Drawing.Size(53, 22);
            this.tbtTriangle.Text = "Triangle";
            this.tbtTriangle.Click += new System.EventHandler(this.tbtTriangle_Click);
            // 
            // tbtRhombus
            // 
            this.tbtRhombus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtRhombus.Image = ((System.Drawing.Image)(resources.GetObject("tbtRhombus.Image")));
            this.tbtRhombus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtRhombus.Name = "tbtRhombus";
            this.tbtRhombus.Size = new System.Drawing.Size(62, 22);
            this.tbtRhombus.Text = "Rhombus";
            // 
            // tbtSave
            // 
            this.tbtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtSave.Image = ((System.Drawing.Image)(resources.GetObject("tbtSave.Image")));
            this.tbtSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtSave.Name = "tbtSave";
            this.tbtSave.Size = new System.Drawing.Size(35, 22);
            this.tbtSave.Text = "Save";
            this.tbtSave.Click += new System.EventHandler(this.tbtSave_Click);
            // 
            // tbtOpen
            // 
            this.tbtOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbtOpen.Image")));
            this.tbtOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtOpen.Name = "tbtOpen";
            this.tbtOpen.Size = new System.Drawing.Size(40, 22);
            this.tbtOpen.Text = "Open";
            this.tbtOpen.Click += new System.EventHandler(this.tbtOpen_Click);
            // 
            // tbtContro
            // 
            this.tbtContro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtContro.Image = ((System.Drawing.Image)(resources.GetObject("tbtContro.Image")));
            this.tbtContro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtContro.Name = "tbtContro";
            this.tbtContro.Size = new System.Drawing.Size(50, 22);
            this.tbtContro.Text = "ConTro";
            this.tbtContro.Click += new System.EventHandler(this.tbtContro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 249);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtLine;
        private System.Windows.Forms.ToolStripButton tbtTriangle;
        private System.Windows.Forms.ToolStripButton tbtRhombus;
        private System.Windows.Forms.ToolStripButton tbtSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton tbtOpen;
        private System.Windows.Forms.ToolStripButton tbtContro;
    }
}

