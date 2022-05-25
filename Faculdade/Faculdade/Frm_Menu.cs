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

namespace Faculdade
{
    public partial class Frm_Menu : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0X2;[DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public Frm_Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            Pn_Menu.Visible = false;
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Pn_Menu.Visible = false;
        }

        private void Btn_Cursos_Click(object sender, EventArgs e)
        {
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Curso>();
        }
        private void Btn_Alunos_Click(object sender, EventArgs e)
        {
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Aluno>();
        }


        public void Pn_Menu_Paint(object sender, PaintEventArgs e)
        {
            Form formulario;
            formulario = Pn_Menu.Controls.OfType<Form>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Form();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.Size = Pn_Menu.Size;
                Pn_Menu.Controls.Add(formulario);
                Pn_Menu.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }

            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
           
        }

        public void AbrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = Pn_Menu.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.Size = Pn_Menu.Size;
                Pn_Menu.Controls.Add(formulario);
                Pn_Menu.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }
    }
}

