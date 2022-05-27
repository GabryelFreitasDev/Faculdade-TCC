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
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Pn_Menu.Visible = false;
        }

        private void exibirCursos()
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

            Btn_InserirCursos.Location = new Point(0, Btn_Cursos.Location.Y + 100);
            Btn_AlterarCursos.Location = new Point(0, Btn_Cursos.Location.Y + 130);
            Btn_DeletarCursos.Location = new Point(0, Btn_Cursos.Location.Y + 160);
            Btn_RelatorioCursos.Location = new Point(0, Btn_Cursos.Location.Y + 190);
        }

        private void ocultarCursos()
        {
            Location = new Point(Location.X, Location.Y + 60);

            Pic_SetaCursos.Load("seta.png");
            Size = new Size(Width, Height - 120);
            Btn_RelatorioCursos.Location = new Point(1450, 690);
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

        private void exibirAlunos()
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

            Btn_InserirAlunos.Location = new Point(0, Btn_Alunos.Location.Y + 100);
            Btn_AlterarAlunos.Location = new Point(0, Btn_Alunos.Location.Y + 130);
            Btn_DeletarAlunos.Location = new Point(0, Btn_Alunos.Location.Y + 160);
            Btn_RelatorioAlunos.Location = new Point(0, Btn_Alunos.Location.Y + 190);
        }

        private void ocultarAlunos()
        {
            Location = new Point(Location.X, Location.Y + 60);

            Pic_SetaAlunos.Load("seta.png");
            Size = new Size(Width, Height - 120);
            Btn_RelatorioAlunos.Location = new Point(1450, 690);
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

        private void exibirProfessores()
        {
            Location = new Point(Location.X, Location.Y - 60);

            Pic_SetaProfessores.Load("setaCima.png");
            Size = new Size(Width, Height + 120);

            Btn_Materias.Location = new Point(Btn_Materias.Location.X, Btn_Materias.Location.Y + 100);
            Btn_Notas.Location = new Point(Btn_Notas.Location.X, Btn_Notas.Location.Y + 100);

            Pic_SetaMaterias.Location = new Point(Pic_SetaMaterias.Location.X, Pic_SetaMaterias.Location.Y + 100);
            Pic_SetaNotas.Location = new Point(Pic_SetaNotas.Location.X, Pic_SetaNotas.Location.Y + 100);

            Btn_InserirProfessores.Location = new Point(0, Btn_Professores.Location.Y + 100);
            Btn_AlterarProfessores.Location = new Point(0, Btn_Professores.Location.Y + 130);
            Btn_DeletarProfessores.Location = new Point(0, Btn_Professores.Location.Y + 160);
            Btn_RelatorioProfessores.Location = new Point(0, Btn_Professores.Location.Y + 190);
        }

        private void ocultarProfessores()
        {
            Location = new Point(Location.X, Location.Y + 60);

            Pic_SetaProfessores.Load("seta.png");
            Size = new Size(Width, Height - 120);
            Btn_RelatorioProfessores.Location = new Point(1450, 690);
            Btn_InserirProfessores.Location = new Point(1450, 690);
            Btn_AlterarProfessores.Location = new Point(1450, 690);
            Btn_DeletarProfessores.Location = new Point(1450, 690);

            Btn_Materias.Location = new Point(Btn_Materias.Location.X, Btn_Materias.Location.Y - 100);
            Btn_Notas.Location = new Point(Btn_Notas.Location.X, Btn_Notas.Location.Y - 100);

            Pic_SetaMaterias.Location = new Point(Pic_SetaMaterias.Location.X, Pic_SetaMaterias.Location.Y - 100);
            Pic_SetaNotas.Location = new Point(Pic_SetaNotas.Location.X, Pic_SetaNotas.Location.Y - 100);
        }

        private void exibirMaterias()
        {
            Location = new Point(Location.X, Location.Y - 60);

            Pic_SetaMaterias.Load("setaCima.png");
            Size = new Size(Width, Height + 120);

            Btn_Notas.Location = new Point(Btn_Notas.Location.X, Btn_Notas.Location.Y + 100);

            Pic_SetaNotas.Location = new Point(Pic_SetaNotas.Location.X, Pic_SetaNotas.Location.Y + 100);

            Btn_InserirMaterias.Location = new Point(0, Btn_Materias.Location.Y + 100);
            Btn_AlterarMaterias.Location = new Point(0, Btn_Materias.Location.Y + 130);
            Btn_DeletarMaterias.Location = new Point(0, Btn_Materias.Location.Y + 160);
            Btn_RelatorioMaterias.Location = new Point(0, Btn_Materias.Location.Y + 190);
        }

        private void ocultarMaterias()
        {
            Location = new Point(Location.X, Location.Y + 60);

            Pic_SetaMaterias.Load("seta.png");
            Size = new Size(Width, Height - 120);
            Btn_RelatorioMaterias.Location = new Point(1450, 690);
            Btn_InserirMaterias.Location = new Point(1450, 690);
            Btn_AlterarMaterias.Location = new Point(1450, 690);
            Btn_DeletarMaterias.Location = new Point(1450, 690);

            Btn_Notas.Location = new Point(Btn_Notas.Location.X, Btn_Notas.Location.Y - 100);

            Pic_SetaNotas.Location = new Point(Pic_SetaNotas.Location.X, Pic_SetaNotas.Location.Y - 100);
        }

        private void exibirNotas()
        {
            Location = new Point(Location.X, Location.Y - 60);

            Pic_SetaNotas.Load("setaCima.png");
            Size = new Size(Width, Height + 120);

            Btn_InserirNotas.Location = new Point(0, Btn_Notas.Location.Y + 100);
            Btn_AlterarNotas.Location = new Point(0, Btn_Notas.Location.Y + 130);
            Btn_DeletarNotas.Location = new Point(0, Btn_Notas.Location.Y + 160);
            Btn_RelatorioNotas.Location = new Point(0, Btn_Notas.Location.Y + 190);
        }

        private void ocultarNotas()
        {
            Location = new Point(Location.X, Location.Y + 60);

            Pic_SetaNotas.Load("seta.png");
            Size = new Size(Width, Height - 120);

            Btn_RelatorioNotas.Location = new Point(1450, 690);
            Btn_InserirNotas.Location = new Point(1450, 690);
            Btn_AlterarNotas.Location = new Point(1450, 690);
            Btn_DeletarNotas.Location = new Point(1450, 690);
        }

        private void Btn_Cursos_Click(object sender, EventArgs e)
        {
            if (Btn_RelatorioAlunos.Location.X != 1450) ocultarAlunos();

            if (Btn_RelatorioProfessores.Location.X != 1450) ocultarProfessores();

            if (Btn_RelatorioMaterias.Location.X != 1450) ocultarMaterias();

            if (Btn_RelatorioNotas.Location.X != 1450) ocultarNotas();

            if (Btn_RelatorioCursos.Location.X == 1450)
            {
                exibirCursos();
            }
            else
            {
                ocultarCursos();
            }

            Pn_Menu.Visible = true;
            AbrirForm<Frm_Curso>();
        }

        private void Btn_Alunos_Click(object sender, EventArgs e)
        {
            if (Btn_RelatorioCursos.Location.X != 1450) ocultarCursos();

            if (Btn_RelatorioProfessores.Location.X != 1450) ocultarProfessores();

            if (Btn_RelatorioMaterias.Location.X != 1450) ocultarMaterias();

            if (Btn_RelatorioNotas.Location.X != 1450) ocultarNotas();

            if (Btn_RelatorioAlunos.Location.X == 1450)
            {
                exibirAlunos();
            }
            else
            {
                ocultarAlunos();
            }

            Pn_Menu.Visible = true;
            AbrirForm<Frm_Aluno>();
            
        }

        private void Btn_Professores_Click(object sender, EventArgs e)
        {
            if (Btn_RelatorioCursos.Location.X != 1450) ocultarCursos();

            if (Btn_RelatorioAlunos.Location.X != 1450) ocultarAlunos();

            if (Btn_RelatorioMaterias.Location.X != 1450) ocultarMaterias();

            if (Btn_RelatorioNotas.Location.X != 1450) ocultarNotas();

            if (Btn_RelatorioProfessores.Location.X == 1450)
            {
                exibirProfessores();
            }
            else
            {
                ocultarProfessores();
            }
        }

        private void Btn_Materias_Click(object sender, EventArgs e)
        {
            if (Btn_RelatorioCursos.Location.X != 1450) ocultarCursos();

            if (Btn_RelatorioAlunos.Location.X != 1450) ocultarAlunos();

            if (Btn_RelatorioProfessores.Location.X != 1450) ocultarProfessores();

            if (Btn_RelatorioNotas.Location.X != 1450) ocultarNotas();

            if (Btn_RelatorioMaterias.Location.X == 1450)
            {
                exibirMaterias();
            }
            else
            {
                ocultarMaterias();
            }
        }

        private void Btn_Notas_Click(object sender, EventArgs e)
        {
            if (Btn_RelatorioCursos.Location.X != 1450) ocultarCursos();

            if (Btn_RelatorioAlunos.Location.X != 1450) ocultarAlunos();

            if (Btn_RelatorioProfessores.Location.X != 1450) ocultarProfessores();

            if (Btn_RelatorioMaterias.Location.X != 1450) ocultarMaterias();

            if (Btn_RelatorioNotas.Location.X == 1450)
            {
                exibirNotas();
            }
            else
            {
                ocultarNotas();
            }
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

