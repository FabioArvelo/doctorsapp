
namespace ModernGUI_V3
{
    partial class Login2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.Errormsg = new System.Windows.Forms.Label();
            this.btnrestore = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestore)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(74, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtuser.Location = new System.Drawing.Point(374, 90);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(241, 20);
            this.txtuser.TabIndex = 2;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtpass.Location = new System.Drawing.Point(382, 136);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(239, 20);
            this.txtpass.TabIndex = 3;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(432, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnlogin.FlatAppearance.BorderSize = 5;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(368, 203);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(247, 40);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "ACCESS";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.linkpass.LinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.linkpass.Location = new System.Drawing.Point(413, 265);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(148, 21);
            this.linkpass.TabIndex = 7;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "Forgot password?";
            this.linkpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 376;
            this.lineShape2.X2 = 622;
            this.lineShape2.Y1 = 166;
            this.lineShape2.Y2 = 166;
            this.lineShape2.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 374;
            this.lineShape1.X2 = 620;
            this.lineShape1.Y1 = 119;
            this.lineShape1.Y2 = 119;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(645, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(37, 21);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 10;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(688, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(731, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(37, 21);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 12;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Errormsg
            // 
            this.Errormsg.AutoSize = true;
            this.Errormsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errormsg.ForeColor = System.Drawing.Color.Red;
            this.Errormsg.Location = new System.Drawing.Point(408, 246);
            this.Errormsg.Name = "Errormsg";
            this.Errormsg.Size = new System.Drawing.Size(153, 21);
            this.Errormsg.TabIndex = 13;
            this.Errormsg.Text = "Invalid credentials";
            this.Errormsg.Visible = false;
            // 
            // btnrestore
            // 
            this.btnrestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestore.BackColor = System.Drawing.Color.Turquoise;
            this.btnrestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestore.Image = ((System.Drawing.Image)(resources.GetObject("btnrestore.Image")));
            this.btnrestore.Location = new System.Drawing.Point(609, 13);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(30, 20);
            this.btnrestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnrestore.TabIndex = 14;
            this.btnrestore.TabStop = false;
            this.btnrestore.Visible = false;
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click);
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btnrestore);
            this.Controls.Add(this.Errormsg);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login2";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Login2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label Errormsg;
        private System.Windows.Forms.PictureBox btnrestore;
    }
}