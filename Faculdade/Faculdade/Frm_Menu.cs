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

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            Pn_Menu.Visible = false;
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Pn_Menu.Visible = false;
        }

        private void exibirCursos()
        {
            if (Btn_PesquisarCursos.Location.X == 1450)
            {
                Location = new Point(Location.X, Location.Y - 60);

                Pic_SetaCursos.Load("setaCima.png");
                Size = new Size(Width, Height + 120);

                Btn_Alunos.Location = new Point(Btn_Alunos.Location.X, Btn_Alunos.Location.Y + 120);
                Btn_Professores.Location = new Point(Btn_Professores.Location.X, Btn_Professores.Location.Y + 100);
                Btn_Materias.Location = new Point(Btn_Materias.Location.X, Btn_Materias.Location.Y + 100);
                Btn_Notas.Location = new Point(Btn_Notas.Location.X, Btn_Notas.Location.Y + 100);

                Pic_SetaAlunos.Location = new Point(Pic_SetaAlunos.Location.X, Pic_SetaAlunos.Location.Y + 120);
                Pic_SetaProfessores.Location = new Point(Pic_SetaProfessores.Location.X, Pic_SetaProfessores.Location.Y + 100);
                Pic_SetaMaterias.Location = new Point(Pic_SetaMaterias.Location.X, Pic_SetaMaterias.Location.Y + 100);
                Pic_SetaNotas.Location = new Point(Pic_SetaNotas.Location.X, Pic_SetaNotas.Location.Y + 100);

                Btn_PesquisarCursos.Location = new Point(0, Btn_Cursos.Location.Y + 100);
                Btn_InserirCursos.Location = new Point(0, Btn_Cursos.Location.Y + 130);
                Btn_AlterarCursos.Location = new Point(0, Btn_Cursos.Location.Y + 160);
                Btn_DeletarCursos.Location = new Point(0, Btn_Cursos.Location.Y + 190);
            }
            else
            {
                Location = new Point(Location.X, Location.Y + 60);

                Pic_SetaCursos.Load("seta.png");
                Size = new Size(Width, Height - 120);
                Btn_PesquisarCursos.Location = new Point(1450, 690);
                Btn_InserirCursos.Location = new Point(1450, 690);
                Btn_AlterarCursos.Location = new Point(1450, 690);
                Btn_DeletarCursos.Location = new Point(1450, 690);

                Btn_Alunos.Location = new Point(Btn_Alunos.Location.X, Btn_Alunos.Location.Y - 120);
                Btn_Professores.Location = new Point(Btn_Professores.Location.X, Btn_Professores.Location.Y - 100);
                Btn_Materias.Location = new Point(Btn_Materias.Location.X, Btn_Materias.Location.Y - 100);
                Btn_Notas.Location = new Point(Btn_Notas.Location.X, Btn_Notas.Location.Y - 100);

                Pic_SetaAlunos.Location = new Point(Pic_SetaAlunos.Location.X, Pic_SetaAlunos.Location.Y - 120);
                Pic_SetaProfessores.Location = new Point(Pic_SetaProfessores.Location.X, Pic_SetaProfessores.Location.Y - 100);
                Pic_SetaMaterias.Location = new Point(Pic_SetaMaterias.Location.X, Pic_SetaMaterias.Location.Y - 100);
                Pic_SetaNotas.Location = new Point(Pic_SetaNotas.Location.X, Pic_SetaNotas.Location.Y - 100);
            }
        }

        private void exibirAlunos()
        {
            if (Btn_PesquisarAlunos.Location.X == 1450)
            {
                Location = new Point(Location.X, Location.Y - 60);

                Pic_SetaAlunos.Load("setaCima.png");
                Size = new Size(Width, Height + 120);

                Btn_Professores.Location = new Point(Btn_Professores.Location.X, Btn_Professores.Location.Y + 100);
                Btn_Materias.Location = new Point(Btn_Materias.Location.X, Btn_Materias.Location.Y + 100);
                Btn_Notas.Location = new Point(Btn_Notas.Location.X, Btn_Notas.Location.Y + 100);

                Pic_SetaProfessores.Location = new Point(Pic_SetaProfessores.Location.X, Pic_SetaProfessores.Location.Y + 100);
                Pic_SetaMaterias.Location = new Point(Pic_SetaMaterias.Location.X, Pic_SetaMaterias.Location.Y + 100);
                Pic_SetaNotas.Location = new Point(Pic_SetaNotas.Location.X, Pic_SetaNotas.Location.Y + 100);

                Btn_PesquisarAlunos.Location = new Point(0, Btn_Alunos.Location.Y + 100);
                Btn_InserirAlunos.Location = new Point(0, Btn_Alunos.Location.Y + 130);
                Btn_AlterarAlunos.Location = new Point(0, Btn_Alunos.Location.Y + 160);
                Btn_DeletarAlunos.Location = new Point(0, Btn_Alunos.Location.Y + 190);
            }
            else
            {
                Location = new Point(Location.X, Location.Y + 60);

                Pic_SetaAlunos.Load("seta.png");
                Size = new Size(Width, Height - 120);
                Btn_PesquisarAlunos.Location = new Point(1450, 690);
                Btn_InserirAlunos.Location = new Point(1450, 690);
                Btn_AlterarAlunos.Location = new Point(1450, 690);
                Btn_DeletarAlunos.Location = new Point(1450, 690);

                Btn_Professores.Location = new Point(Btn_Professores.Location.X, Btn_Professores.Location.Y - 100);
                Btn_Materias.Location = new Point(Btn_Materias.Location.X, Btn_Materias.Location.Y - 100);
                Btn_Notas.Location = new Point(Btn_Notas.Location.X, Btn_Notas.Location.Y - 100);

                Pic_SetaProfessores.Location = new Point(Pic_SetaProfessores.Location.X, Pic_SetaProfessores.Location.Y - 100);
                Pic_SetaMaterias.Location = new Point(Pic_SetaMaterias.Location.X, Pic_SetaMaterias.Location.Y - 100);
                Pic_SetaNotas.Location = new Point(Pic_SetaNotas.Location.X, Pic_SetaNotas.Location.Y - 100);
            }
        }

        private void Btn_Cursos_Click(object sender, EventArgs e)
        {
            if (Btn_PesquisarAlunos.Location.X != 1450) exibirAlunos();
            exibirCursos();

            
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Curso>();
            
        }
        private void Btn_Alunos_Click(object sender, EventArgs e)
        {
            if(Btn_PesquisarCursos.Location.X != 1450) exibirCursos();
            exibirAlunos();

            
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

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pn_Menu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Pic_SetaAlunos_Click(object sender, EventArgs e)
        {

        }

        private void Pn_Menu_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}

