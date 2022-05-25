using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculdade
{
    public partial class Frm_Menu_Alunos : Form
    {
        public Frm_Menu_Alunos()
        {
            InitializeComponent();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Frm_Menu menu = new Frm_Menu();
            menu.Visible = true;
            Visible = false;
        }

        private void Btn_Cursos_Click(object sender, EventArgs e)
        {
            Frm_Menu_Cursos cursos = new Frm_Menu_Cursos();
            Visible = false;
            cursos.Visible = true;
        }

        private void Btn_Alunos_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Aluno_Click(object sender, EventArgs e)
        {
            Frm_Aluno aluno = new Frm_Aluno();
            aluno.ShowDialog();
        }
    }
}
