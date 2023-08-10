﻿using System;
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
            string[] lista = File.ReadAllLines("RelacaoDeAlunos.csv");
            MessageBox.Show($"Recebido: {GetIndex}","recebido",MessageBoxButtons.OK);
            string[] alunos = lista[GetIndex].Split(';');

            Lbl_Nome.Text = alunos[0];
            Lbl_ShowNomeDaMae.Text = alunos[1];
            Lbl_ShowNomeDoPai.Text = alunos[2];
            Msk_ShowNascimento.Text = alunos[3];
            Msk_ShowContato1.Text = alunos[4];
            Msk_ShowContato2.Text = alunos[5];
            Lbl_ShowNomeDaRua.Text = alunos[6];
            Lbl_ShowNumero.Text = alunos[7];
            Msk_ShowCEP.Text = alunos[8];
            Lbl_ShowBairro.Text = alunos[9];
            Lbl_ShowCidade.Text = $"{alunos[10]}/{alunos[11]}";
        }
    }
}
