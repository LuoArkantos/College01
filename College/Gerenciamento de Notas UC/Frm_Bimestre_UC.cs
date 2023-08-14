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
    public partial class Frm_Bimestre_UC : UserControl
    {
        public Frm_Bimestre_UC()
        {
            InitializeComponent();
        }
        #region PROPRIEDADES
        public int GetId { get; set; }

        public double TotalAtv { get; set; }
        public double TotalTrab { get; set; }
        public double TotalProva { get; set; }

        public double MediaFinal { get; set; }

        #endregion

        public void MostrarMedia()
        {
            double media = TotalAtv + TotalTrab + TotalProva;
            Lbl_ResultadoMedia.Text = media.ToString();
        }

        private void Frm_Bimestre_UC_Load(object sender, EventArgs e)
        {
            double totalAtv = double.Parse(Msk_TotalLiteralAtv.Text);
            double totalTrab = double.Parse(Msk_TotalLiteralTrab.Text);
            double totalProva = double.Parse(Msk_TotalLiteralProva.Text);
            TotalAtv = totalAtv;
            TotalTrab = totalTrab;
            TotalProva = totalProva;

            MessageBox.Show(GetId.ToString());
        }
        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            //notas dinamicas

            string numeroAtvCad = panel1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            string trab1 = Msk_NotaTrab1.Text;
            string trab2 = Msk_NotaTrab2.Text;
            string prova = Msk_NotaProva.Text;

            //literais
            string totalCaderno = Msk_TotalLiteralAtv.Text;
            string totalTrabalhos = Msk_TotalLiteralTrab.Text;
            string totalProva = Msk_TotalLiteralProva.Text;

            string complemento = Msk_TotalLiteralAtv.Text;

            string mediaFinal = Lbl_ResultadoMedia.Text;

            Cls_Aluno.LancarNotas(GetId.ToString(),numeroAtvCad,totalCaderno,trab1,trab2,totalTrabalhos,prova,totalProva,complemento,mediaFinal);

            //boletin.ID = GetId.ToString();

            //boletin.QntdAtvCad = numeroAtvCad;
            //boletin.Trab1 = trab1;
            //boletin.Trab2 = trab2;
            //boletin.NotaProva = prova;

            //boletin.CadernoLiteral = totalCaderno;
            //boletin.TrabalhosLiteral = totalTrabalhos;
            //boletin.ProvaLiteral = totalProva;

        }

        private void Btn_SaveCad_Click(object sender, EventArgs e)
        {
            int multiplicador;

            /* Entendendo estrutura de captura de radiobuton:

            panel1.Controls.OfType<>() == O controle do painel onde estão os RdBtns, OfType<RadioButton> pega o tipo do objeto que queremos (que é radiobutton)

            SingleOrDefault(RadioButton => RadioButton.Checked) == Pega entre os Radio Buttons, o Que está selecionado.

             */

            multiplicador = int.Parse(panel1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text);
            double peso = 0.40;
            double totalCaderno = multiplicador * peso;

            TotalAtv = totalCaderno;

            Msk_TotalLiteralAtv.Text = totalCaderno.ToString();

            MostrarMedia();

        }

        private void Btn_SaveTrab_Click(object sender, EventArgs e)
        {
            double trab1 = double.Parse(Msk_NotaTrab1.Text);
            double trab2 = double.Parse(Msk_NotaTrab2.Text);

            double literal = (trab1+trab2)/2;
            double multiplicador = 0.30;
            double totalTrabalhos = literal * multiplicador;
            
            TotalTrab = totalTrabalhos;

            Msk_TotalLiteralTrab.Text = totalTrabalhos.ToString();

            MostrarMedia();

        }

        private void Btn_SaveProva_Click(object sender, EventArgs e)
        {
            double prova = double.Parse(Msk_NotaProva.Text);
            double multiplicador = 0.5;

            double totalProva = prova * multiplicador;

            TotalProva = totalProva;

            Msk_TotalLiteralProva.Text = totalProva.ToString();

            MostrarMedia();

        }


    }
}
