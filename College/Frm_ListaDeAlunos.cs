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
using System.Windows.Shapes;

namespace College
{
    public partial class Frm_ListaDeAlunos : Form
    {
        public Frm_ListaDeAlunos()
        {
            InitializeComponent();
        }
        private void Frm_ListaDeTurmas_Load(object sender, EventArgs e)
        {
            string localDoArquivo = "RelacaoDeAlunos.csv";


            if (File.Exists(localDoArquivo))
            {

                string[] linhas = File.ReadAllLines(localDoArquivo);

                DataGridView dgv = new DataGridView();

                dgv.Rows.Clear();
                dgv.Columns.Clear();


                string[] columnHeaders = linhas[0].Split(';');


                foreach (string header in columnHeaders)
                {
                    dgv.Columns.Add(header, header);
                }


                for (int i = 1; i < linhas.Length; i++)
                {
                    string[] values = linhas[i].Split(';');
                    dgv.Rows.Add(values);
                }
            }
            else
            {

                MessageBox.Show("File not found: " + localDoArquivo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void Frm_ListaDeTurmas_Load(object sender, EventArgs e)
        //{
        //    DataGridView dgv = new DataGridView();
        //    string localDoArquivo = "RelacaoDeAlunos.csv";

        //    string[] linhas = File.ReadAllLines(localDoArquivo);

        //    for (int i = 0; i < linhas.Length; i++)
        //    {
        //        dgv.Rows.Add(linhas[1]);
        //    }
        //}
    }

}
