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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Inserir(textBox1.Text);
            MessageBox.Show(curso.mensagem);
        }

        private void Btn_excluiCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Excluir(Txb_excluiCurso.Text);
            MessageBox.Show(curso.mensagem);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Editar(Txb_nomeAlterar.Text, Txb_nomeNovo.Text);
            MessageBox.Show(curso.mensagem);
        }

        private void Txb_listaCurso_TextChanged(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.BuscarTudo();

        }
    }
}
