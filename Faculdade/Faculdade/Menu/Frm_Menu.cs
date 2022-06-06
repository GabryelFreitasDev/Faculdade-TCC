using Faculdade.Nota;
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

        public Frm_Menu()
        {
            InitializeComponent();
            AbrirForm<Frm_Aluno>();
            AbrirForm<Frm_Curso>();
            AbrirForm<Frm_Turma>();
            AbrirForm<Frm_Materia>();
            AbrirForm<Frm_Nota>();
            AbrirForm<Frm_menuGeral>();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            Btn_Menu.BackColor = Color.FromArgb(43, 51, 90);
            Pn_Menu.Visible = true;
            AbrirForm<Frm_menuGeral>();
        }

        public void descolorirAbas()
        {
            Btn_Menu.BackColor = Color.FromArgb(24, 30, 54);
            Btn_Alunos.BackColor = Color.FromArgb(24, 30, 54);
            Btn_Materias.BackColor = Color.FromArgb(24, 30, 54);
            Btn_Cursos.BackColor = Color.FromArgb(24, 30, 54);
            Btn_Notas.BackColor = Color.FromArgb(24, 30, 54);
            Btn_Turmas.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Menu.BackColor = Color.FromArgb(43, 51, 90);
            Pn_Menu.Visible = true;
            AbrirForm<Frm_menuGeral>();
        }

        private void Btn_Cursos_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Cursos.BackColor = Color.FromArgb(43, 51, 90);
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Curso>();
        }

        private void Btn_Alunos_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Alunos.BackColor = Color.FromArgb(43, 51, 90);
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Aluno>();
        }

        private void Btn_Professores_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Turmas.BackColor = Color.FromArgb(43, 51, 90);
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Turma>();           
        }

        private void Btn_Materias_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Materias.BackColor = Color.FromArgb(43, 51, 90);
            Pn_Menu.Visible = true;
            AbrirForm<Frm_Materia>();
        }

        private void Btn_Notas_Click(object sender, EventArgs e)
        {
            descolorirAbas();
            Btn_Notas.BackColor = Color.FromArgb(43, 51, 90);
            Pn_Menu.Visible= true;  
            AbrirForm<Frm_Nota>();
        }

        public void AbrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = Pn_Menu.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                Pn_Menu.Controls.Add(formulario);
                Pn_Menu.Tag = formulario;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.Size = Pn_Menu.Size;
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

        private void Pic_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pic_Maximizar_Click(object sender, EventArgs e)
        {
           Maximizar();
        }

        // Serve para arrumar o botão de Maximizar e também a posição de alguns itens
        private void Maximizar()
        {
            Pic_Maximizar.Visible = !Pic_Maximizar.Visible;
            Pic_Maximizar2.Visible = !Pic_Maximizar2.Visible;

            if(Pic_Maximizar.Visible) // Se a tela não estiver maximizada
            {
                WindowState = FormWindowState.Normal;
            } else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Pic_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Pic_Maximizar2_Click(object sender, EventArgs e)
        {
            Maximizar();
        }
    }
}

