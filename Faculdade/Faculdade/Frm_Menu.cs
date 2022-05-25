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
        private Form frm;
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Cursos_Click(object sender, EventArgs e)
        {
                frm?.Close();
                frm = new Frm_Curso()
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };
                Pn_Menu.Controls.Add(frm);
                Pn_Menu.AutoScroll = true;
                frm.Show();
        }

        private void Btn_Alunos_Click(object sender, EventArgs e)
        {
            frm?.Close();
            frm = new Frm_Aluno()
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,

            };
            Pn_Menu.Controls.Add(frm);
            Pn_Menu.AutoScroll = true;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
