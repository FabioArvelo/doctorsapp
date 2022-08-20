using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }

        #region Formulary functionalities 
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //Capture position and height before maximizing to restore
        int lx, ly;
        int sw, sh;

        private void Login2_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtuser.Text != null) {
                if (txtpass.Text != null) {
                    Validate user = new Validate();
                    var validLogin = user.Loginuser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();

                    }
                    else
                    {
                        Error("Incorrect credentials");
                        txtpass.Clear();
                        txtuser.Focus();
                    }
                }
                else Error("Please enter valid password");
            }
            else Error("Please enter valid username");
        }
        private void Error(string msg)
        {
            Errormsg.Text = "    " + msg;
            Errormsg.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Clear();
            txtuser.Clear();
            Errormsg.Visible = false;
            this.Show();
            txtuser.Focus();

        }
        

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
               txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            btnrestore.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
    }
}
#endregion