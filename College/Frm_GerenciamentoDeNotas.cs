using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class Frm_GerenciamentoDeNotas : Form
    {
        public Frm_GerenciamentoDeNotas()
        {
            InitializeComponent();
        }


        private void bimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bimestre_UC u = new Frm_Bimestre_UC();
            TabPage tab = new TabPage();

            u.Dock = DockStyle.Fill;
            tab.Name = "Bimestre";
            tab.Text = "Bimestre1";
            tab.Controls.Add(u);

            Tbc_Aplicacoes.TabPages.Add(tab);
        }
    }
}
