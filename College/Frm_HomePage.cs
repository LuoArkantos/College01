﻿using System;
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
    public partial class Frm_HomePage : Form
    {
        public Frm_HomePage()
        {
            InitializeComponent();
            conectarToolStripMenuItem.Enabled = true;
            alunoToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            coordenaçãoToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void professorToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_Login l = new Frm_Login();

            if (l.ShowDialog() == DialogResult.OK)
            {
                string usuario = l.usuario;
                string senha = l.senha;

                //if (senha == "prof")
                //{
                //    conectarToolStripMenuItem.Enabled = false;
                //        alunoToolStripMenuItem.Enabled = true;
                //        professorToolStripMenuItem.Enabled = true;
                //        coordenaçãoToolStripMenuItem.Enabled = true;
                //        desconectarToolStripMenuItem.Enabled = true;
                //    MessageBox.Show("Autenticado");
                //}
                //else
                //{
                //    MessageBox.Show("Negado");
                //}

                if (Cls_Uteis.Cls_Uteis.ValidaProfessor(senha) == true)
                {
                    conectarToolStripMenuItem.Enabled = false;
                    alunoToolStripMenuItem.Enabled = true;
                    professorToolStripMenuItem.Enabled = true;
                    coordenaçãoToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show($"Bem vindo {usuario} à interface para Professores!", "Acesso Liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Acesso Negado!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void coordenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_Login l = new Frm_Login();

            if (l.ShowDialog() == DialogResult.OK)
            {
                string usuario = l.usuario;
                string senha = l.senha;

                if (Cls_Uteis.Cls_Uteis.ValidaCoordenador(senha) == true)
                {
                    conectarToolStripMenuItem.Enabled = false;
                    alunoToolStripMenuItem.Enabled = true;
                    professorToolStripMenuItem.Enabled = true;
                    coordenaçãoToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show($"Bem vindo {usuario} à interface para Coordenadores!", "Acesso Liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Acesso Negado!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conectarToolStripMenuItem.Enabled = true;
            alunoToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            coordenaçãoToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            Frm_CadastroAluno c = new Frm_CadastroAluno();
            c.ShowDialog();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Frm_BuscarAluno b = new Frm_BuscarAluno();
            b.Show();
        
        }

        private void Frm_HomePage_Load(object sender, EventArgs e)
        {
            Frm_Login l = new Frm_Login();
            l.ShowDialog();
        }

        private void Btn_GerirNotas_Click(object sender, EventArgs e)
        {
            Frm_ListaDeAlunos l = new Frm_ListaDeAlunos();
            this.Hide();
            l.ShowDialog();
            this.Show();            
        }
    }
}
