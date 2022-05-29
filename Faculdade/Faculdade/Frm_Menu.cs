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
        public const int HT_CAPTION = 0X2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            Pn_Menu.Visible = false;
            Btn_Menu.BackColor = Color.FromArgb(35,35,60);
        }


        public void descolorirAbas()
        {
            Btn_Menu.BackColor = Color.FromArgb(51, 51, 76);
            Btn_Alunos.BackColor = Color.FromArgb(51, 51, 76);
            Btn_Materias.BackColor = Color.FromArgb(51, 51, 76);
            Btn_Cursos.BackColor = Color.FromArgb(51, 51, 76);
            Btn_Notas.BackColor = Color.FromArgb(51, 51, 76);
            Btn_Professores.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Menu.BackColor = Color.FromArgb(35, 35, 60);
            Pn_Menu.Visible = false;
        }

        private void Btn_Cursos_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Cursos.BackColor = Color.FromArgb(35, 35, 60);
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Curso>();
        }

        private void Btn_Alunos_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Alunos.BackColor = Color.FromArgb(35, 35, 60);
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Aluno>();
            
        }

        private void Btn_Professores_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Professores.BackColor = Color.FromArgb(35, 35, 60);
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Turma>();
        }

        private void Btn_Materias_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Materias.BackColor = Color.FromArgb(35, 35, 60);
        }

        private void Btn_Notas_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Notas.BackColor = Color.FromArgb(35, 35, 60);
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

        private void Pn_Menu_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pic_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pic_Maximizar_Click(object sender, EventArgs e)
        {
            if(Width < 1400)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void Pic_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

