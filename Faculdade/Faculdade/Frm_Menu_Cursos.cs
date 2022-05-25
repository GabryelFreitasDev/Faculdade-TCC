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
    public partial class Frm_Menu_Cursos : Form
    {
        public Frm_Menu_Cursos()
        {
            InitializeComponent();
        }

        private void Btn_Curso_Click(object sender, EventArgs e)
        {
            Frm_Curso curso = new Frm_Curso();
            curso.ShowDialog();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            Frm_Menu menu = new Frm_Menu();
            menu.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Alunos_Click(object sender, EventArgs e)
        {
            Frm_Menu_Alunos alunos = new Frm_Menu_Alunos();
            alunos.Visible = true;
            Visible = false;
        }
    }
}
