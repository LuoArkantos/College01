namespace College
{
    partial class Frm_BuscarAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_NomeInstituicao = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_NomeBusca = new System.Windows.Forms.TextBox();
            this.Lbl_NomeBusca = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_NomeMae = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_NomePai = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_Nascimento = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Lbl_Contato1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Lbl_Endereco = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Lbl_Contato2 = new System.Windows.Forms.Label();
            this.Btn_EditarDados = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_GerirNotas = new System.Windows.Forms.Button();
            this.Lbl_Informacao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_NomeInstituicao
            // 
            this.Lbl_NomeInstituicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_NomeInstituicao.AutoSize = true;
            this.Lbl_NomeInstituicao.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeInstituicao.Location = new System.Drawing.Point(542, 9);
            this.Lbl_NomeInstituicao.Name = "Lbl_NomeInstituicao";
            this.Lbl_NomeInstituicao.Size = new System.Drawing.Size(265, 32);
            this.Lbl_NomeInstituicao.TabIndex = 0;
            this.Lbl_NomeInstituicao.Text = "Nome Da Instituição";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(589, 41);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(165, 25);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Buscar Aluno";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.Location = new System.Drawing.Point(828, 107);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(122, 32);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_NomeBusca
            // 
            this.Txt_NomeBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeBusca.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeBusca.Location = new System.Drawing.Point(282, 107);
            this.Txt_NomeBusca.Name = "Txt_NomeBusca";
            this.Txt_NomeBusca.Size = new System.Drawing.Size(536, 32);
            this.Txt_NomeBusca.TabIndex = 3;
            // 
            // Lbl_NomeBusca
            // 
            this.Lbl_NomeBusca.AutoSize = true;
            this.Lbl_NomeBusca.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeBusca.Location = new System.Drawing.Point(36, 107);
            this.Lbl_NomeBusca.Name = "Lbl_NomeBusca";
            this.Lbl_NomeBusca.Size = new System.Drawing.Size(173, 25);
            this.Lbl_NomeBusca.TabIndex = 4;
            this.Lbl_NomeBusca.Text = "Nome do Aluno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(22, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome:";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.BackColor = System.Drawing.Color.Silver;
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(314, 33);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(455, 28);
            this.Lbl_Nome.TabIndex = 6;
            // 
            // Lbl_NomeMae
            // 
            this.Lbl_NomeMae.BackColor = System.Drawing.Color.Silver;
            this.Lbl_NomeMae.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeMae.Location = new System.Drawing.Point(314, 70);
            this.Lbl_NomeMae.Name = "Lbl_NomeMae";
            this.Lbl_NomeMae.Size = new System.Drawing.Size(455, 28);
            this.Lbl_NomeMae.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(22, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nome da Mãe:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Lbl_NomePai
            // 
            this.Lbl_NomePai.BackColor = System.Drawing.Color.Silver;
            this.Lbl_NomePai.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomePai.Location = new System.Drawing.Point(314, 110);
            this.Lbl_NomePai.Name = "Lbl_NomePai";
            this.Lbl_NomePai.Size = new System.Drawing.Size(455, 28);
            this.Lbl_NomePai.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(22, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nome do Pai:";
            // 
            // Lbl_Nascimento
            // 
            this.Lbl_Nascimento.BackColor = System.Drawing.Color.Silver;
            this.Lbl_Nascimento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nascimento.Location = new System.Drawing.Point(314, 148);
            this.Lbl_Nascimento.Name = "Lbl_Nascimento";
            this.Lbl_Nascimento.Size = new System.Drawing.Size(145, 28);
            this.Lbl_Nascimento.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(22, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Data de Nascimento:";
            // 
            // Lbl_Contato1
            // 
            this.Lbl_Contato1.BackColor = System.Drawing.Color.Silver;
            this.Lbl_Contato1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contato1.Location = new System.Drawing.Point(314, 188);
            this.Lbl_Contato1.Name = "Lbl_Contato1";
            this.Lbl_Contato1.Size = new System.Drawing.Size(176, 28);
            this.Lbl_Contato1.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(22, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Contatos:";
            // 
            // Lbl_Endereco
            // 
            this.Lbl_Endereco.BackColor = System.Drawing.Color.Silver;
            this.Lbl_Endereco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Endereco.Location = new System.Drawing.Point(314, 225);
            this.Lbl_Endereco.Name = "Lbl_Endereco";
            this.Lbl_Endereco.Size = new System.Drawing.Size(455, 101);
            this.Lbl_Endereco.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(22, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 19);
            this.label15.TabIndex = 15;
            this.label15.Text = "Endereço:";
            // 
            // Lbl_Contato2
            // 
            this.Lbl_Contato2.BackColor = System.Drawing.Color.Silver;
            this.Lbl_Contato2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contato2.Location = new System.Drawing.Point(496, 188);
            this.Lbl_Contato2.Name = "Lbl_Contato2";
            this.Lbl_Contato2.Size = new System.Drawing.Size(171, 28);
            this.Lbl_Contato2.TabIndex = 17;
            // 
            // Btn_EditarDados
            // 
            this.Btn_EditarDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_EditarDados.Location = new System.Drawing.Point(828, 221);
            this.Btn_EditarDados.Name = "Btn_EditarDados";
            this.Btn_EditarDados.Size = new System.Drawing.Size(122, 54);
            this.Btn_EditarDados.TabIndex = 18;
            this.Btn_EditarDados.Text = "Editar Dados";
            this.Btn_EditarDados.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Location = new System.Drawing.Point(828, 426);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(122, 54);
            this.Btn_Cancelar.TabIndex = 19;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_GerirNotas
            // 
            this.Btn_GerirNotas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_GerirNotas.Location = new System.Drawing.Point(827, 161);
            this.Btn_GerirNotas.Name = "Btn_GerirNotas";
            this.Btn_GerirNotas.Size = new System.Drawing.Size(122, 54);
            this.Btn_GerirNotas.TabIndex = 20;
            this.Btn_GerirNotas.Text = "Gerir Notas";
            this.Btn_GerirNotas.UseVisualStyleBackColor = true;
            // 
            // Lbl_Informacao
            // 
            this.Lbl_Informacao.AutoSize = true;
            this.Lbl_Informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Informacao.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Informacao.Location = new System.Drawing.Point(534, 84);
            this.Lbl_Informacao.Name = "Lbl_Informacao";
            this.Lbl_Informacao.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Informacao.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lbl_Contato1);
            this.panel1.Controls.Add(this.Lbl_Nome);
            this.panel1.Controls.Add(this.Lbl_Endereco);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Lbl_Contato2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Lbl_NomeMae);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Lbl_Nascimento);
            this.panel1.Controls.Add(this.Lbl_NomePai);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(38, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 335);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Frm_BuscarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_Informacao);
            this.Controls.Add(this.Btn_GerirNotas);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_EditarDados);
            this.Controls.Add(this.Lbl_NomeBusca);
            this.Controls.Add(this.Txt_NomeBusca);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Lbl_NomeInstituicao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BuscarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Aluno";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_NomeInstituicao;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_NomeBusca;
        private System.Windows.Forms.Label Lbl_NomeBusca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_NomeMae;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_NomePai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_Nascimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Lbl_Contato1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Lbl_Endereco;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Lbl_Contato2;
        private System.Windows.Forms.Button Btn_EditarDados;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_GerirNotas;
        private System.Windows.Forms.Label Lbl_Informacao;
        private System.Windows.Forms.Panel panel1;
    }
}