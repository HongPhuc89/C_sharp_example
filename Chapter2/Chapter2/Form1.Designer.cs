namespace Chapter2
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
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.txtBoxX = new System.Windows.Forms.TextBox();
            this.txtReslut = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arithmeticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logarithmicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.log10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trigonometricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbx = new System.Windows.Forms.Label();
            this.lby = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxY
            // 
            this.txtBoxY.Location = new System.Drawing.Point(181, 112);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.Size = new System.Drawing.Size(100, 20);
            this.txtBoxY.TabIndex = 0;
            // 
            // txtBoxX
            // 
            this.txtBoxX.Location = new System.Drawing.Point(181, 66);
            this.txtBoxX.Name = "txtBoxX";
            this.txtBoxX.Size = new System.Drawing.Size(100, 20);
            this.txtBoxX.TabIndex = 1;
            // 
            // txtReslut
            // 
            this.txtReslut.Location = new System.Drawing.Point(181, 158);
            this.txtReslut.Name = "txtReslut";
            this.txtReslut.Size = new System.Drawing.Size(100, 20);
            this.txtReslut.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arithmeticToolStripMenuItem,
            this.trigonometricToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arithmeticToolStripMenuItem
            // 
            this.arithmeticToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.powToolStripMenuItem,
            this.exponentialToolStripMenuItem,
            this.logarithmicToolStripMenuItem,
            this.log10ToolStripMenuItem});
            this.arithmeticToolStripMenuItem.Name = "arithmeticToolStripMenuItem";
            this.arithmeticToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.arithmeticToolStripMenuItem.Text = "Arithmetic ";
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem.Text = "Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // powToolStripMenuItem
            // 
            this.powToolStripMenuItem.Name = "powToolStripMenuItem";
            this.powToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.powToolStripMenuItem.Text = "Pow";
            this.powToolStripMenuItem.Click += new System.EventHandler(this.powToolStripMenuItem_Click);
            // 
            // exponentialToolStripMenuItem
            // 
            this.exponentialToolStripMenuItem.Name = "exponentialToolStripMenuItem";
            this.exponentialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exponentialToolStripMenuItem.Text = "Exponential";
            this.exponentialToolStripMenuItem.Click += new System.EventHandler(this.exponentialToolStripMenuItem_Click);
            // 
            // logarithmicToolStripMenuItem
            // 
            this.logarithmicToolStripMenuItem.Name = "logarithmicToolStripMenuItem";
            this.logarithmicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logarithmicToolStripMenuItem.Text = "Logarithmic";
            this.logarithmicToolStripMenuItem.Click += new System.EventHandler(this.logarithmicToolStripMenuItem_Click);
            // 
            // log10ToolStripMenuItem
            // 
            this.log10ToolStripMenuItem.Name = "log10ToolStripMenuItem";
            this.log10ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.log10ToolStripMenuItem.Text = "Log10";
            this.log10ToolStripMenuItem.Click += new System.EventHandler(this.log10ToolStripMenuItem_Click);
            // 
            // trigonometricToolStripMenuItem
            // 
            this.trigonometricToolStripMenuItem.AutoToolTip = true;
            this.trigonometricToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinToolStripMenuItem,
            this.cosToolStripMenuItem,
            this.tanToolStripMenuItem,
            this.secToolStripMenuItem,
            this.cscToolStripMenuItem,
            this.cotToolStripMenuItem});
            this.trigonometricToolStripMenuItem.Name = "trigonometricToolStripMenuItem";
            this.trigonometricToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.trigonometricToolStripMenuItem.Text = "Trigonometric";
            this.trigonometricToolStripMenuItem.ToolTipText = "\"X unit must be rad\"";
            // 
            // sinToolStripMenuItem
            // 
            this.sinToolStripMenuItem.Name = "sinToolStripMenuItem";
            this.sinToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.sinToolStripMenuItem.Text = "sin";
            this.sinToolStripMenuItem.Click += new System.EventHandler(this.sinToolStripMenuItem_Click);
            // 
            // cosToolStripMenuItem
            // 
            this.cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            this.cosToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.cosToolStripMenuItem.Text = "cos";
            this.cosToolStripMenuItem.Click += new System.EventHandler(this.cosToolStripMenuItem_Click);
            // 
            // tanToolStripMenuItem
            // 
            this.tanToolStripMenuItem.Name = "tanToolStripMenuItem";
            this.tanToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.tanToolStripMenuItem.Text = "tan";
            this.tanToolStripMenuItem.Click += new System.EventHandler(this.tanToolStripMenuItem_Click);
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            this.secToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.secToolStripMenuItem.Text = "sec";
            this.secToolStripMenuItem.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // cscToolStripMenuItem
            // 
            this.cscToolStripMenuItem.Name = "cscToolStripMenuItem";
            this.cscToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.cscToolStripMenuItem.Text = "csc";
            this.cscToolStripMenuItem.Click += new System.EventHandler(this.cscToolStripMenuItem_Click);
            // 
            // cotToolStripMenuItem
            // 
            this.cotToolStripMenuItem.Name = "cotToolStripMenuItem";
            this.cotToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.cotToolStripMenuItem.Text = "cot";
            this.cotToolStripMenuItem.Click += new System.EventHandler(this.cotToolStripMenuItem_Click);
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.Location = new System.Drawing.Point(93, 73);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(23, 13);
            this.lbx.TabIndex = 5;
            this.lbx.Text = "X =";
            // 
            // lby
            // 
            this.lby.AutoSize = true;
            this.lby.Location = new System.Drawing.Point(93, 118);
            this.lby.Name = "lby";
            this.lby.Size = new System.Drawing.Size(23, 13);
            this.lby.TabIndex = 6;
            this.lby.Text = "Y =";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(93, 165);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 13);
            this.lbResult.TabIndex = 7;
            this.lbResult.Text = "Result";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lby);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.txtReslut);
            this.Controls.Add(this.txtBoxX);
            this.Controls.Add(this.txtBoxY);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxY;
        private System.Windows.Forms.TextBox txtBoxX;
        private System.Windows.Forms.TextBox txtReslut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arithmeticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trigonometricToolStripMenuItem;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lby;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ToolStripMenuItem powToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exponentialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logarithmicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem log10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotToolStripMenuItem;
    }
}

