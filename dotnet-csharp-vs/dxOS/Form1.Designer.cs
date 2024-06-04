
namespace dxOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ieMenu = new System.Windows.Forms.PictureBox();
            this.cmdMenu = new System.Windows.Forms.PictureBox();
            this.ie = new System.Windows.Forms.PictureBox();
            this.cmd = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ieTaskbar = new System.Windows.Forms.PictureBox();
            this.cmdTaskbar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ieMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ieTaskbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTaskbar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(157, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 707);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 47);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ieMenu);
            this.panel1.Controls.Add(this.cmdMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 295);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // ieMenu
            // 
            this.ieMenu.Image = global::dxOS.Properties.Resources.Internet_Explorer_9;
            this.ieMenu.Location = new System.Drawing.Point(16, 80);
            this.ieMenu.Name = "ieMenu";
            this.ieMenu.Size = new System.Drawing.Size(32, 32);
            this.ieMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ieMenu.TabIndex = 5;
            this.ieMenu.TabStop = false;
            this.ieMenu.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // cmdMenu
            // 
            this.cmdMenu.Image = global::dxOS.Properties.Resources.cmd;
            this.cmdMenu.Location = new System.Drawing.Point(16, 27);
            this.cmdMenu.Name = "cmdMenu";
            this.cmdMenu.Size = new System.Drawing.Size(32, 32);
            this.cmdMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdMenu.TabIndex = 4;
            this.cmdMenu.TabStop = false;
            this.cmdMenu.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // ie
            // 
            this.ie.BackColor = System.Drawing.Color.Transparent;
            this.ie.Image = ((System.Drawing.Image)(resources.GetObject("ie.Image")));
            this.ie.Location = new System.Drawing.Point(28, 22);
            this.ie.Name = "ie";
            this.ie.Size = new System.Drawing.Size(64, 64);
            this.ie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ie.TabIndex = 5;
            this.ie.TabStop = false;
            this.ie.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // cmd
            // 
            this.cmd.Image = global::dxOS.Properties.Resources.cmd;
            this.cmd.Location = new System.Drawing.Point(28, 123);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(64, 64);
            this.cmd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmd.TabIndex = 7;
            this.cmd.TabStop = false;
            this.cmd.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Command\r\n Prompt";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ieTaskbar);
            this.panel2.Controls.Add(this.cmdTaskbar);
            this.panel2.Location = new System.Drawing.Point(98, 707);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 47);
            this.panel2.TabIndex = 9;
            // 
            // ieTaskbar
            // 
            this.ieTaskbar.Image = global::dxOS.Properties.Resources.Internet_Explorer_9;
            this.ieTaskbar.Location = new System.Drawing.Point(71, 8);
            this.ieTaskbar.Name = "ieTaskbar";
            this.ieTaskbar.Size = new System.Drawing.Size(32, 32);
            this.ieTaskbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ieTaskbar.TabIndex = 1;
            this.ieTaskbar.TabStop = false;
            this.ieTaskbar.Click += new System.EventHandler(this.ieTaskbar_Click);
            // 
            // cmdTaskbar
            // 
            this.cmdTaskbar.Image = global::dxOS.Properties.Resources.cmd;
            this.cmdTaskbar.Location = new System.Drawing.Point(17, 8);
            this.cmdTaskbar.Name = "cmdTaskbar";
            this.cmdTaskbar.Size = new System.Drawing.Size(32, 32);
            this.cmdTaskbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdTaskbar.TabIndex = 0;
            this.cmdTaskbar.TabStop = false;
            this.cmdTaskbar.Click += new System.EventHandler(this.cmdTaskbar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Browser";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 766);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "dxOS";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ieMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ieTaskbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdTaskbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ie;
        private System.Windows.Forms.PictureBox cmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cmdMenu;
        private System.Windows.Forms.PictureBox ieMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ieTaskbar;
        private System.Windows.Forms.PictureBox cmdTaskbar;
        private System.Windows.Forms.Label label3;
    }
}

