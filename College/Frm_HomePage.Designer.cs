﻿using System.Drawing;
using System.Windows.Forms;

namespace College
{
    partial class Frm_HomePage
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.coordenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfólioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordenaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaPorTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Cadastro = new System.Windows.Forms.Button();
            this.Btn_GerirNotas = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.coordenaçãoToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professorToolStripMenuItem4,
            this.coordenadorToolStripMenuItem});
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            // 
            // professorToolStripMenuItem4
            // 
            this.professorToolStripMenuItem4.Name = "professorToolStripMenuItem4";
            this.professorToolStripMenuItem4.Size = new System.Drawing.Size(144, 22);
            this.professorToolStripMenuItem4.Text = "Professor";
            this.professorToolStripMenuItem4.Click += new System.EventHandler(this.professorToolStripMenuItem4_Click);
            // 
            // coordenadorToolStripMenuItem
            // 
            this.coordenadorToolStripMenuItem.Name = "coordenadorToolStripMenuItem";
            this.coordenadorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.coordenadorToolStripMenuItem.Text = "Coordenador";
            this.coordenadorToolStripMenuItem.Click += new System.EventHandler(this.coordenadorToolStripMenuItem_Click);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarAlunoToolStripMenuItem,
            this.alterarDadosToolStripMenuItem,
            this.boletimToolStripMenuItem});
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // buscarAlunoToolStripMenuItem
            // 
            this.buscarAlunoToolStripMenuItem.Name = "buscarAlunoToolStripMenuItem";
            this.buscarAlunoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.buscarAlunoToolStripMenuItem.Text = "Buscar Aluno";
            // 
            // alterarDadosToolStripMenuItem
            // 
            this.alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            this.alterarDadosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            // 
            // boletimToolStripMenuItem
            // 
            this.boletimToolStripMenuItem.Name = "boletimToolStripMenuItem";
            this.boletimToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.boletimToolStripMenuItem.Text = "Boletim";
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turmaToolStripMenuItem,
            this.gerirNotasToolStripMenuItem,
            this.portfólioToolStripMenuItem});
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // gerirNotasToolStripMenuItem
            // 
            this.gerirNotasToolStripMenuItem.Name = "gerirNotasToolStripMenuItem";
            this.gerirNotasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.gerirNotasToolStripMenuItem.Text = "Gerir Notas";
            // 
            // portfólioToolStripMenuItem
            // 
            this.portfólioToolStripMenuItem.Name = "portfólioToolStripMenuItem";
            this.portfólioToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.portfólioToolStripMenuItem.Text = "Portfólio";
            // 
            // coordenaçãoToolStripMenuItem
            // 
            this.coordenaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem,
            this.buscarAlunoToolStripMenuItem1,
            this.alterarDadosToolStripMenuItem1,
            this.médiaPorTurmaToolStripMenuItem});
            this.coordenaçãoToolStripMenuItem.Name = "coordenaçãoToolStripMenuItem";
            this.coordenaçãoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.coordenaçãoToolStripMenuItem.Text = "Coordenação";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem2,
            this.professorToolStripMenuItem2});
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.novoAlunoToolStripMenuItem.Text = "Novo";
            // 
            // alunoToolStripMenuItem2
            // 
            this.alunoToolStripMenuItem2.Name = "alunoToolStripMenuItem2";
            this.alunoToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
            this.alunoToolStripMenuItem2.Text = "Aluno";
            // 
            // professorToolStripMenuItem2
            // 
            this.professorToolStripMenuItem2.Name = "professorToolStripMenuItem2";
            this.professorToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
            this.professorToolStripMenuItem2.Text = "Professor";
            // 
            // buscarAlunoToolStripMenuItem1
            // 
            this.buscarAlunoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem3,
            this.professorToolStripMenuItem3});
            this.buscarAlunoToolStripMenuItem1.Name = "buscarAlunoToolStripMenuItem1";
            this.buscarAlunoToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.buscarAlunoToolStripMenuItem1.Text = "Buscar";
            // 
            // alunoToolStripMenuItem3
            // 
            this.alunoToolStripMenuItem3.Name = "alunoToolStripMenuItem3";
            this.alunoToolStripMenuItem3.Size = new System.Drawing.Size(123, 22);
            this.alunoToolStripMenuItem3.Text = "Aluno";
            // 
            // professorToolStripMenuItem3
            // 
            this.professorToolStripMenuItem3.Name = "professorToolStripMenuItem3";
            this.professorToolStripMenuItem3.Size = new System.Drawing.Size(123, 22);
            this.professorToolStripMenuItem3.Text = "Professor";
            // 
            // alterarDadosToolStripMenuItem1
            // 
            this.alterarDadosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem1,
            this.professorToolStripMenuItem1});
            this.alterarDadosToolStripMenuItem1.Name = "alterarDadosToolStripMenuItem1";
            this.alterarDadosToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.alterarDadosToolStripMenuItem1.Text = "Alterar Dados";
            // 
            // alunoToolStripMenuItem1
            // 
            this.alunoToolStripMenuItem1.Name = "alunoToolStripMenuItem1";
            this.alunoToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.alunoToolStripMenuItem1.Text = "Aluno";
            // 
            // professorToolStripMenuItem1
            // 
            this.professorToolStripMenuItem1.Name = "professorToolStripMenuItem1";
            this.professorToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.professorToolStripMenuItem1.Text = "Professor";
            // 
            // médiaPorTurmaToolStripMenuItem
            // 
            this.médiaPorTurmaToolStripMenuItem.Name = "médiaPorTurmaToolStripMenuItem";
            this.médiaPorTurmaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.médiaPorTurmaToolStripMenuItem.Text = "Média por Turma";
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Btn_Cadastro
            // 
            this.Btn_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cadastro.BackgroundImage = global::College.Properties.Resources.cadastro;
            this.Btn_Cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cadastro.FlatAppearance.BorderSize = 0;
            this.Btn_Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cadastro.Location = new System.Drawing.Point(247, 195);
            this.Btn_Cadastro.Name = "Btn_Cadastro";
            this.Btn_Cadastro.Size = new System.Drawing.Size(85, 85);
            this.Btn_Cadastro.TabIndex = 1;
            this.Btn_Cadastro.UseVisualStyleBackColor = false;
            this.Btn_Cadastro.Click += new System.EventHandler(this.Btn_Cadastro_Click);
            // 
            // Btn_GerirNotas
            // 
            this.Btn_GerirNotas.BackColor = System.Drawing.Color.Transparent;
            this.Btn_GerirNotas.BackgroundImage = global::College.Properties.Resources.gerir_notas;
            this.Btn_GerirNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_GerirNotas.FlatAppearance.BorderSize = 0;
            this.Btn_GerirNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GerirNotas.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_GerirNotas.Location = new System.Drawing.Point(437, 195);
            this.Btn_GerirNotas.Name = "Btn_GerirNotas";
            this.Btn_GerirNotas.Size = new System.Drawing.Size(85, 85);
            this.Btn_GerirNotas.TabIndex = 2;
            this.Btn_GerirNotas.UseVisualStyleBackColor = false;
            this.Btn_GerirNotas.Click += new System.EventHandler(this.Btn_GerirNotas_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Buscar.BackgroundImage = global::College.Properties.Resources.buscar;
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Location = new System.Drawing.Point(631, 195);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(85, 85);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_Cadastro
            // 
            this.Lbl_Cadastro.AutoSize = true;
            this.Lbl_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Cadastro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cadastro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Lbl_Cadastro.Location = new System.Drawing.Point(214, 283);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(152, 20);
            this.Lbl_Cadastro.TabIndex = 4;
            this.Lbl_Cadastro.Text = "Cadastrar Aluno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(425, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerir Turma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(611, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar Aluno";
            // 
            // Frm_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::College.Properties.Resources.escola1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_GerirNotas);
            this.Controls.Add(this.Btn_Cadastro);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_HomePage";
            this.Load += new System.EventHandler(this.Frm_HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem conectarToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem buscarAlunoToolStripMenuItem;
        private ToolStripMenuItem alterarDadosToolStripMenuItem;
        private ToolStripMenuItem boletimToolStripMenuItem;
        private ToolStripMenuItem professorToolStripMenuItem;
        private ToolStripMenuItem turmaToolStripMenuItem;
        private ToolStripMenuItem gerirNotasToolStripMenuItem;
        private ToolStripMenuItem portfólioToolStripMenuItem;
        private ToolStripMenuItem coordenaçãoToolStripMenuItem;
        private ToolStripMenuItem novoAlunoToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem2;
        private ToolStripMenuItem professorToolStripMenuItem2;
        private ToolStripMenuItem buscarAlunoToolStripMenuItem1;
        private ToolStripMenuItem alunoToolStripMenuItem3;
        private ToolStripMenuItem professorToolStripMenuItem3;
        private ToolStripMenuItem alterarDadosToolStripMenuItem1;
        private ToolStripMenuItem alunoToolStripMenuItem1;
        private ToolStripMenuItem professorToolStripMenuItem1;
        private ToolStripMenuItem médiaPorTurmaToolStripMenuItem;
        private ToolStripMenuItem desconectarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem professorToolStripMenuItem4;
        private ToolStripMenuItem coordenadorToolStripMenuItem;
        private Button Btn_Cadastro;
        private Button Btn_Buscar;
        private Button Btn_GerirNotas;
        private Label Lbl_Cadastro;
        private Label label1;
        private Label label2;
    }
}