using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College.Gerenciamento_de_Notas_UC
{
    public partial class Frm_DadosDoAluno_UC : UserControl
    {
        public Frm_DadosDoAluno_UC()
        {
            InitializeComponent();
        }
        public int GetIndex { get; set; }

        private void Frm_DadosDoAluno_UC_Load(object sender, EventArgs e)
        {
            Frm_GerenciamentoDeNotas gerenciamento = new Frm_GerenciamentoDeNotas();
            string[] lista = File.ReadAllLines("RelacaoDeAlunos.csv");
            MessageBox.Show($"Recebido: {GetIndex}","recebido",MessageBoxButtons.OK);
            string[] alunos = lista[GetIndex].Split(';');

            Lbl_Nome.Text = alunos[0];
            Lbl_NomeDaMae.Text = alunos[1];
            Lbl_NomeDoPai.Text = alunos[2];
            Lbl_Nascimento.Text = alunos[3];
        }
    }
}
