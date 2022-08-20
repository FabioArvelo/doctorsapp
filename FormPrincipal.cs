using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capasinom;

namespace ModernGUI_V3
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            LoadUserdata();
        }
        #region Formulary functionalities 
        //RESIZE METODO PARA REDIMENSIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
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
            this.panelContenedor.Region = region;
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

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Capture position and height before maximizing to restore
        int lx, ly;
        int sw, sh;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }



        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarratitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Method to drag the form//
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormulary<Form1>();
            button1.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormulary<Form2>();
            button2.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormulary<Form3>();
            button3.BackColor = Color.FromArgb(12, 61, 92);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelFormularies_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadUserdata()
        {
            label2.Text = UserLoginCache.FirstName+", "+UserLoginCache.LastName;
            label3.Text = UserLoginCache.Email;
            label4.Text = UserLoginCache.Position;


        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Please confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        #endregion
        //Method to open formularies within the panel
        private void OpenFormulary<Myform>()where Myform : Form, new() {
            Form formulary;
            formulary = panelFormularies.Controls.OfType<Myform>().FirstOrDefault();//Look in the formulary collection
            //if the formulary/instance does not exist
            if (formulary == null) {
                formulary = new Myform();
                formulary.TopLevel = false;
                formulary.FormBorderStyle = FormBorderStyle.None;
                formulary.Dock = DockStyle.Fill;
                panelFormularies.Controls.Add(formulary);
                panelFormularies.Tag = formulary;
                formulary.Show();
                formulary.BringToFront();
                formulary.FormClosed += new FormClosedEventHandler(CloseForms );
            }
            //if the formulary/instance exist 
            else {
                formulary.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms["Form1"] == null)
                button1.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form2"] == null)
                button2.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form3"] == null)
                button3.BackColor = Color.FromArgb(4, 41, 68);
        }
    }
}
