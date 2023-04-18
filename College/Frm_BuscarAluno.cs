using Cls_Uteis;
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

namespace College
{
    public partial class Frm_BuscarAluno : Form
    {
        public Frm_BuscarAluno()
        {
            InitializeComponent();
        }

        string nomeBusca;
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            nomeBusca = Txt_NomeBusca.Text;
            
            string localDoArquivo = "RelacaoDeAlunos.csv";
            string nomeDeBusca = nomeBusca;


            string[] linhas = File.ReadAllLines(localDoArquivo);//Vai criar a lista[] de linhas lendo as linhas do arquivo


            foreach (string linha in linhas)
            {
                string[] dado = linha.Split(';');
                

                if (dado[0] == nomeDeBusca)
                {
                    Lbl_Informacao.Text = "";
                    string nome = dado[0];
                    string nomeMae = dado[1];
                    string nomePai = dado[2];
                    string nascimento = dado[3];
                    string contato1 = dado[4];
                    string contato2 = dado[5];
                    string endereco = dado[6];

                    Lbl_Nome.Text = nome;
                    Lbl_NomeMae.Text = nomeMae;
                    Lbl_NomePai.Text = nomePai;
                    Lbl_Nascimento.Text = nascimento;
                    Lbl_Contato1.Text = contato1;
                    Lbl_Contato2.Text = contato2;
                    Lbl_Endereco.Text = endereco;

                    break;
                }
                else
                {
                    Lbl_Informacao.Text = "Aluno não encontrado";
                }

            }
            #region teste
            var a = new Cls_Aluno();

            //Lbl_Nome.Text = a.Nome;
            //Lbl_NomeMae.Text = nomeMae;
            //Lbl_NomePai.Text = nomePai;
            //Lbl_Nascimento.Text = nascimento;
            //Lbl_Contato1.Text = contato1;
            //Lbl_Contato2.Text = contato2;
            //Lbl_Endereco.Text = endereco;

            this.Controls.Add(Lbl_Nome);
            this.Controls.Add(Lbl_NomeMae);
            this.Controls.Add(Lbl_NomePai);
            this.Controls.Add(Lbl_Nascimento);
            this.Controls.Add(Lbl_Contato1);
            this.Controls.Add(Lbl_Contato2);
            this.Controls.Add(Lbl_Endereco);
            //if (Cls_Aluno.BuscarAluno(nomeBusca))
            //{
            //    Lbl_Nome.Text = nome;

            //}
            #endregion

        }
    }
}
