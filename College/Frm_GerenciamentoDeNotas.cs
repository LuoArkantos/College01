using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using College.Gerenciamento_de_Notas_UC;

namespace College
{
    public partial class Frm_GerenciamentoDeNotas : Form
    {
        public Frm_GerenciamentoDeNotas()
        {
            InitializeComponent();
        }


        //private void bimestreToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Frm_Bimestre_UC u = new Frm_Bimestre_UC();
        //    TabPage tab = new TabPage();

        //    u.Dock = DockStyle.Fill;
        //    tab.Name = "Bimestre";
        //    tab.Text = "Bimestre1";
        //    tab.Controls.Add(u);

        //    //Tbc_Aplicacoes.TabPages.Add(tab);
        //}

        //private void Tbc_Aplicacoes_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void Btn_ShowDadosDoAluno_Click(object sender, EventArgs e)
        {
            Frm_DadosDoAluno_UC u = new Frm_DadosDoAluno_UC();
            TabPage tab = new TabPage();

            u.Dock = DockStyle.Fill;
            tab.Name = "Dados do Aluno";
            tab.Text = "Dados do(a) Aluno(a)";
            tab.Controls.Add(u);

            if (Tbc_Display.TabCount <= 1)
            {
                Tbc_Display.TabPages.Clear();
                Tbc_Display.TabPages.Add(tab);

            }
            else
            {
                Tbc_Display.TabPages.Remove(tab);
            }

        }

        private void Btn_ShowNotasDoBimestre_Click(object sender, EventArgs e)
        {
            Frm_Bimestre_UC u = new Frm_Bimestre_UC();
            TabPage tab = new TabPage();

            u.Dock = DockStyle.Fill;
            tab.Name = "Bimestre";
            tab.Text = "Bimestre1";
            tab.Controls.Add(u);

            if (Tbc_Display.TabCount <= 1)
            {
                Tbc_Display.TabPages.Clear();
                Tbc_Display.TabPages.Add(tab);

            }
            else
            {
                Tbc_Display.TabPages.Remove(tab);
            }

        }
    }
}
