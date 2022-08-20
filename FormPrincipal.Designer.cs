
namespace ModernGUI_V3
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularies = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBarratitulo = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelFormularies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBarratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelFormularies);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarratitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(903, 650);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularies
            // 
            this.panelFormularies.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFormularies.Controls.Add(this.btnlogout);
            this.panelFormularies.Controls.Add(this.label1);
            this.panelFormularies.Controls.Add(this.pictureBox1);
            this.panelFormularies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularies.Location = new System.Drawing.Point(250, 46);
            this.panelFormularies.Name = "panelFormularies";
            this.panelFormularies.Size = new System.Drawing.Size(653, 604);
            this.panelFormularies.TabIndex = 2;
            this.panelFormularies.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularies_Paint);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Red;
            this.btnlogout.Location = new System.Drawing.Point(0, 0);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 31);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(318, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "DMA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.pictureBox6);
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 46);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 604);
            this.panelMenu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(83, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(83, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(83, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(74, 52);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 191);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(0, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel appointment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(0, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "View and modify";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(0, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Book an appointment";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBarratitulo
            // 
            this.panelBarratitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelBarratitulo.Controls.Add(this.btnminimizar);
            this.panelBarratitulo.Controls.Add(this.btnrestaurar);
            this.panelBarratitulo.Controls.Add(this.btnmaximizar);
            this.panelBarratitulo.Controls.Add(this.btncerrar);
            this.panelBarratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarratitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarratitulo.Name = "panelBarratitulo";
            this.panelBarratitulo.Size = new System.Drawing.Size(903, 46);
            this.panelBarratitulo.TabIndex = 0;
            this.panelBarratitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelBarratitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarratitulo_MouseMove);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(816, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(23, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 1;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.BackColor = System.Drawing.Color.Turquoise;
            this.btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaurar.Image")));
            this.btnrestaurar.Location = new System.Drawing.Point(790, 12);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnrestaurar.TabIndex = 2;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Visible = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(845, 12);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmaximizar.TabIndex = 1;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(871, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularies.ResumeLayout(false);
            this.panelFormularies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBarratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelFormularies;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelBarratitulo;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

