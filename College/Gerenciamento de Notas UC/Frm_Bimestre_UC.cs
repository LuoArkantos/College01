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
        public int GetId { get; set; }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Bimestre_UC_Load(object sender, EventArgs e)
        {
            Rad_cad1.Select();
            RadioButton RdBtn = new RadioButton();
            if (RdBtn.Enabled == true)
            {
                switch (RdBtn.Name)
                {
                    case Rad_cad1.Select():
                        Msk_TotalLiteralAtv.Text = "0.40";
                        break;
                    case "Rad_Cad2":
                        Msk_TotalLiteralAtv.Text = "0.80";
                        break;
                    case ("Rad_Cad3"):
                        Msk_TotalLiteralAtv.Text = "1.20";
                        break;
                    case ("Rad_Cad4"):
                        Msk_TotalLiteralAtv.Text = "1.60";
                        break;
                    case ("Rad_Cad5"):
                        Msk_TotalLiteralAtv.Text = "2.00";
                        break;
                    default:
                        break;
                }
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            //notas dinamicas
            double atividade;
            
            //radio buttons
            RadioButton RdBtn = new RadioButton();
            
            switch (RdBtn.Name)
            {
                case ("Rad_Cad1"):
                    Msk_TotalLiteralAtv.Text = "0.40";
                    break;
                case ("Rad_Cad2"):
                    Msk_TotalLiteralAtv.Text = "0.80";
                    break;
                case ("Rad_Cad3"):
                    Msk_TotalLiteralAtv.Text = "1.20";
                    break;
                case ("Rad_Cad4"):
                    Msk_TotalLiteralAtv.Text = "1.60";
                    break;
                case ("Rad_Cad5"):
                    Msk_TotalLiteralAtv.Text = "2.00";
                    break;
                default:
                    break;
            } 

            string trab1 = Msk_NotaTrab1.Text;
            string trab2 = Msk_NotaTrab2.Text;

            string prova = Msk_NotaProva.Text;

            //literais
            string totalCaderno = Msk_TotalLiteralAtv.Text;
            string totalTrabalhos = Msk_TotalLiteralTrab.Text;
            string totalProva = Msk_TotalLiteralProva.Text;

            string complemento = Msk_TotalLiteralAtv.Text;

            Cls_Aluno boletin = new Cls_Aluno();

            //Cls_Aluno.LancarNotas();
            boletin.ID = GetId.ToString();

            boletin.Caderno = totalCaderno;
            boletin.Trabalhos = totalTrabalhos;
            boletin.Prova = totalProva;
        }
    }
}
