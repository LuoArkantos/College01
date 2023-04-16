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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        public string usuario;
        public string senha;

        private void Lbl_Usuario_Click(object sender, EventArgs e)
        {

        }
        private void Btn_OK_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            usuario = Txt_Usuario.Text;
            senha = Txt_Senha.Text;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}