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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Aluno_Click(object sender, EventArgs e)
        {
            Frm_Aluno aluno = new Frm_Aluno();
            aluno.ShowDialog();
        }

        private void Btn_Curso_Click(object sender, EventArgs e)
        {
            Frm_Curso curso = new Frm_Curso();
            curso.ShowDialog();
        }
    }
}
