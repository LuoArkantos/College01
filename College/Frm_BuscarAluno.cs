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

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string nomeBusca = Txt_NomeBusca.Text;
            string localDoArquivo = "RelacaoDeAlunos.csv";
            Btn_Buscar.DialogResult = DialogResult.Yes;
            try
            {
                string[] linhas = File.ReadAllLines(localDoArquivo);

                foreach (string linha in linhas)
                {
                    string[] dado = linha.Split(';');

                    if (dado[0] == nomeBusca)
                    {
                        Lbl_Informacao.Text = "";
                        string nome = dado[0];
                        string nomeMae = dado[1];
                        string nomePai = dado[2];
                        string nascimento = dado[3];
                        string contato1 = dado[4];
                        string contato2 = dado[5];
                        string rua = dado[6];
                        string numero = dado[7];
                        string cep = dado[8];
                        string bairro = dado[9];
                        string cidade = dado[10];
                        string uf = dado[11];

                        Lbl_Nome.Text = nome;
                        Lbl_NomeMae.Text = nomeMae;
                        Lbl_NomePai.Text = nomePai;
                        Lbl_Nascimento.Text = nascimento;
                        Lbl_Contato1.Text = contato1;
                        Lbl_Contato2.Text = contato2;
                        Lbl_Endereco.Text = ($"Rua {rua}, Nº {numero} \nCEP {cep}, Bairro {bairro}, \n{cidade+" "+uf.ToUpper()}");

                        return; // exit the function after finding a match
                    }
                }

                // if we get here, the loop completed without finding a match
                Lbl_Informacao.Text = "Aluno não encontrado";
            }
            catch (Exception ex)
            {
                // handle any exceptions that occurred while reading the file
                MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}");
            }
        }

        void Buscar() 
        {
            string nomeBusca = Txt_NomeBusca.Text;
            string localDoArquivo = "RelacaoDeAlunos.csv";
            Btn_Buscar.DialogResult = DialogResult.Yes;
            try
            {
                string[] linhas = File.ReadAllLines(localDoArquivo);

                foreach (string linha in linhas)
                {
                    string[] dado = linha.Split(';');

                    if (dado[0] == nomeBusca)
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

                        return; // exit the function after finding a match
                    }
                }

                // if we get here, the loop completed without finding a match
                Lbl_Informacao.Text = "Aluno não encontrado";
            }
            catch (Exception ex)
            {
                // handle any exceptions that occurred while reading the file
                MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
