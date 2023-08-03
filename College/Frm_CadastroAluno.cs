using Cls_Uteis;
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
    public partial class Frm_CadastroAluno : Form
    {
        public Frm_CadastroAluno()
        {
            InitializeComponent();
        }
        string nome;
        string nomeMae;
        string nomePai;
        string nascimento;
        string telefone1;
        string telefone2;
        string rua;
        string cep;
        string numero;
        string bairro;
        string cidade;
        string uf;
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            nome = Txt_Nome.Text;
            nomeMae = Txt_NomeMae.Text;
            nomePai = Txt_NomePai.Text;
            nascimento = Msk_Nascimento.Text;
            telefone1 = Msk_Contato1.Text;
            telefone2 = Msk_Contato2.Text;
            rua = Txt_NomeDaRua.Text;
            cep = Msk_Cep.Text;
            numero = Txt_Numero.Text;
            bairro = Txt_Bairro.Text;
            cidade = Txt_Cidade.Text;
            uf = Txt_UF.Text;
            //endereco = Txt_Endereco.Text;

            //Cls_Aluno aluno = new Cls_Aluno();


            if ((nome != "") && (nomeMae != "") && (nascimento != "") && (telefone1 != "") && (rua != "") && (bairro != "") && (cidade != ""))
            {
                Cls_Aluno.CadastrarAluno(nome, nomeMae, nomePai, nascimento, telefone1, telefone2, rua, numero, cep, bairro, cidade, uf);

                if (MessageBox.Show($"Aluno {nome} cadastrado ! :)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                Lbl_Informacao.Text = "Faltam dados obrigatórios";
            }

            
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Btn_Cancelar.DialogResult = DialogResult.Cancel;
        }

        private void Lbl_NomeMae_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NomePai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
