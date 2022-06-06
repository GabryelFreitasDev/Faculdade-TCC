using Npgsql;
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
    public partial class Frm_contaCursos : Form
    {
        Conexao db;
        public Frm_contaCursos()
        {
            InitializeComponent();
            Lbl_contadorCursos.Text = contadorCursos();
        }
        private string contadorCursos()
        {
            db = new Conexao();
            var SQL = "SELECT nomeCurso FROM CURSO";
            var dt = db.NpgSQLQuery(SQL);
            string quantia = dt.Rows.Count.ToString();
            return quantia;
        }
    }
}
