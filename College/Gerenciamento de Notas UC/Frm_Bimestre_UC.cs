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
            double totalAtv = double.Parse(Txt_TotalLiteralAtv.Text);
            double totalTrab = double.Parse(Txt_TotalLiteralTrab.Text);
            double totalProva = double.Parse(Txt_TotalLiteralProva.Text);
            TotalAtv = totalAtv;
            TotalTrab = totalTrab;
            TotalProva = totalProva;
            Rad_cad0.Checked = true;
            MessageBox.Show(GetId.ToString());
        }
        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            //notas dinamicas

            string numeroAtvCad = panel1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            string trab1 = Txt_NotaTrab1.Text;
            string trab2 = Txt_NotaTrab2.Text;
            string prova = Txt_NotaProva.Text;

            //literais
            string totalCaderno = Txt_TotalLiteralAtv.Text;
            string totalTrabalhos = Txt_TotalLiteralTrab.Text;
            string totalProva = Txt_TotalLiteralProva.Text;

            string complemento = Txt_TotalLiteralAtv.Text;

            string mediaFinal = Lbl_ResultadoMedia.Text;

            if ((Btn_SaveCad.BackColor == Color.Green) && (Btn_SaveTrab.BackColor == Color.Green) && (Btn_SaveProva.BackColor == Color.Green))
            {
                Cls_Aluno.LancarNotas(GetId.ToString(), numeroAtvCad, totalCaderno, trab1, trab2, totalTrabalhos, prova, totalProva, complemento, mediaFinal);

                MessageBox.Show("NOTAS SALVAS COM SUCESSO", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Confirme as notas antes de salvar");
            }
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

            Txt_TotalLiteralAtv.Text = totalCaderno.ToString();

            MostrarMedia();
            Btn_SaveCad.BackColor = Color.Green;

        }

        private void Btn_SaveTrab_Click(object sender, EventArgs e)
        {
            double trab1 = double.Parse(Txt_NotaTrab1.Text.Replace('.',','));
            double trab2 = double.Parse(Txt_NotaTrab2.Text.Replace('.', ','));

            double literal = (trab1+trab2)/2;
            double multiplicador = 0.30;
            double totalTrabalhos = literal * multiplicador;
            
            TotalTrab = totalTrabalhos;

            Txt_TotalLiteralTrab.Text = totalTrabalhos.ToString();

            MostrarMedia();
            Btn_SaveTrab.BackColor = Color.Green;


        }

        private void Btn_SaveProva_Click(object sender, EventArgs e)
        {
            double prova = double.Parse(Txt_NotaProva.Text.Replace('.', ','));
            double multiplicador = 0.5;

            double totalProva = prova * multiplicador;

            TotalProva = totalProva;

            Txt_TotalLiteralProva.Text = totalProva.ToString();

            MostrarMedia();
            Btn_SaveProva.BackColor = Color.Green;


        }
    }
}
