﻿namespace College
{
    partial class Frm_CadastroAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_NomeMae = new System.Windows.Forms.TextBox();
            this.Lbl_NomeMae = new System.Windows.Forms.Label();
            this.Txt_NomePai = new System.Windows.Forms.TextBox();
            this.Lbl_NomePai = new System.Windows.Forms.Label();
            this.Lbl_Nascimento = new System.Windows.Forms.Label();
            this.Lbl_Contato1 = new System.Windows.Forms.Label();
            this.Msk_Nascimento = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Contato1 = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Contato2 = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Lbl_Informacao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Msk_Cep = new System.Windows.Forms.MaskedTextBox();
            this.Txt_UF = new System.Windows.Forms.TextBox();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_NomeDaRua = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Da Instituição";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(6, 26);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(86, 23);
            this.Lbl_Nome.TabIndex = 2;
            this.Lbl_Nome.Text = "Nome*";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(10, 53);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(426, 26);
            this.Txt_Nome.TabIndex = 0;
            // 
            // Txt_NomeMae
            // 
            this.Txt_NomeMae.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_NomeMae.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeMae.Location = new System.Drawing.Point(83, 82);
            this.Txt_NomeMae.Name = "Txt_NomeMae";
            this.Txt_NomeMae.Size = new System.Drawing.Size(353, 26);
            this.Txt_NomeMae.TabIndex = 2;
            // 
            // Lbl_NomeMae
            // 
            this.Lbl_NomeMae.AutoSize = true;
            this.Lbl_NomeMae.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeMae.Location = new System.Drawing.Point(9, 82);
            this.Lbl_NomeMae.Name = "Lbl_NomeMae";
            this.Lbl_NomeMae.Size = new System.Drawing.Size(68, 23);
            this.Lbl_NomeMae.TabIndex = 4;
            this.Lbl_NomeMae.Text = "Mãe*";
            this.Lbl_NomeMae.Click += new System.EventHandler(this.Lbl_NomeMae_Click);
            // 
            // Txt_NomePai
            // 
            this.Txt_NomePai.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_NomePai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomePai.Location = new System.Drawing.Point(83, 116);
            this.Txt_NomePai.Name = "Txt_NomePai";
            this.Txt_NomePai.Size = new System.Drawing.Size(353, 26);
            this.Txt_NomePai.TabIndex = 3;
            this.Txt_NomePai.TextChanged += new System.EventHandler(this.Txt_NomePai_TextChanged);
            // 
            // Lbl_NomePai
            // 
            this.Lbl_NomePai.AutoSize = true;
            this.Lbl_NomePai.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomePai.Location = new System.Drawing.Point(9, 119);
            this.Lbl_NomePai.Name = "Lbl_NomePai";
            this.Lbl_NomePai.Size = new System.Drawing.Size(44, 23);
            this.Lbl_NomePai.TabIndex = 6;
            this.Lbl_NomePai.Text = "Pai";
            // 
            // Lbl_Nascimento
            // 
            this.Lbl_Nascimento.AutoSize = true;
            this.Lbl_Nascimento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nascimento.Location = new System.Drawing.Point(282, 24);
            this.Lbl_Nascimento.Name = "Lbl_Nascimento";
            this.Lbl_Nascimento.Size = new System.Drawing.Size(56, 23);
            this.Lbl_Nascimento.TabIndex = 8;
            this.Lbl_Nascimento.Text = "DN*";
            // 
            // Lbl_Contato1
            // 
            this.Lbl_Contato1.AutoSize = true;
            this.Lbl_Contato1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contato1.Location = new System.Drawing.Point(9, 151);
            this.Lbl_Contato1.Name = "Lbl_Contato1";
            this.Lbl_Contato1.Size = new System.Drawing.Size(109, 23);
            this.Lbl_Contato1.TabIndex = 10;
            this.Lbl_Contato1.Text = "Contato*";
            // 
            // Msk_Nascimento
            // 
            this.Msk_Nascimento.BackColor = System.Drawing.SystemColors.Info;
            this.Msk_Nascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_Nascimento.Location = new System.Drawing.Point(344, 21);
            this.Msk_Nascimento.Mask = "00/00/0000";
            this.Msk_Nascimento.Name = "Msk_Nascimento";
            this.Msk_Nascimento.Size = new System.Drawing.Size(92, 26);
            this.Msk_Nascimento.TabIndex = 1;
            // 
            // Msk_Contato1
            // 
            this.Msk_Contato1.BackColor = System.Drawing.SystemColors.Info;
            this.Msk_Contato1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_Contato1.Location = new System.Drawing.Point(305, 148);
            this.Msk_Contato1.Mask = "(00) 0 0000-0000";
            this.Msk_Contato1.Name = "Msk_Contato1";
            this.Msk_Contato1.Size = new System.Drawing.Size(131, 26);
            this.Msk_Contato1.TabIndex = 4;
            // 
            // Msk_Contato2
            // 
            this.Msk_Contato2.BackColor = System.Drawing.SystemColors.Info;
            this.Msk_Contato2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_Contato2.Location = new System.Drawing.Point(305, 180);
            this.Msk_Contato2.Mask = "(00) 0 0000-0000";
            this.Msk_Contato2.Name = "Msk_Contato2";
            this.Msk_Contato2.Size = new System.Drawing.Size(131, 26);
            this.Msk_Contato2.TabIndex = 5;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(635, 361);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(113, 47);
            this.Btn_Ok.TabIndex = 3;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Location = new System.Drawing.Point(516, 376);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(113, 31);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Lbl_Informacao
            // 
            this.Lbl_Informacao.AutoSize = true;
            this.Lbl_Informacao.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Informacao.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Informacao.Location = new System.Drawing.Point(487, 111);
            this.Lbl_Informacao.Name = "Lbl_Informacao";
            this.Lbl_Informacao.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Informacao.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rua";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Msk_Cep);
            this.groupBox1.Controls.Add(this.Txt_UF);
            this.groupBox1.Controls.Add(this.Txt_Numero);
            this.groupBox1.Controls.Add(this.Txt_Cidade);
            this.groupBox1.Controls.Add(this.Txt_Bairro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_NomeDaRua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // Msk_Cep
            // 
            this.Msk_Cep.BackColor = System.Drawing.SystemColors.Info;
            this.Msk_Cep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_Cep.Location = new System.Drawing.Point(90, 64);
            this.Msk_Cep.Mask = "00000-000";
            this.Msk_Cep.Name = "Msk_Cep";
            this.Msk_Cep.Size = new System.Drawing.Size(91, 26);
            this.Msk_Cep.TabIndex = 1;
            // 
            // Txt_UF
            // 
            this.Txt_UF.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_UF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UF.Location = new System.Drawing.Point(396, 131);
            this.Txt_UF.MaxLength = 2;
            this.Txt_UF.Name = "Txt_UF";
            this.Txt_UF.Size = new System.Drawing.Size(40, 26);
            this.Txt_UF.TabIndex = 5;
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Numero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Numero.Location = new System.Drawing.Point(396, 64);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(40, 26);
            this.Txt_Numero.TabIndex = 2;
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cidade.Location = new System.Drawing.Point(90, 131);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(257, 26);
            this.Txt_Cidade.TabIndex = 4;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Bairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Bairro.Location = new System.Drawing.Point(90, 102);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(346, 26);
            this.Txt_Bairro.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nº";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "CEP";
            // 
            // Txt_NomeDaRua
            // 
            this.Txt_NomeDaRua.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_NomeDaRua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_NomeDaRua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeDaRua.Location = new System.Drawing.Point(90, 27);
            this.Txt_NomeDaRua.Name = "Txt_NomeDaRua";
            this.Txt_NomeDaRua.Size = new System.Drawing.Size(346, 26);
            this.Txt_NomeDaRua.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_Nome);
            this.groupBox2.Controls.Add(this.Txt_Nome);
            this.groupBox2.Controls.Add(this.Lbl_NomeMae);
            this.groupBox2.Controls.Add(this.Txt_NomeMae);
            this.groupBox2.Controls.Add(this.Lbl_NomePai);
            this.groupBox2.Controls.Add(this.Msk_Contato2);
            this.groupBox2.Controls.Add(this.Txt_NomePai);
            this.groupBox2.Controls.Add(this.Lbl_Nascimento);
            this.groupBox2.Controls.Add(this.Msk_Contato1);
            this.groupBox2.Controls.Add(this.Lbl_Contato1);
            this.groupBox2.Controls.Add(this.Msk_Nascimento);
            this.groupBox2.Location = new System.Drawing.Point(19, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 221);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // Frm_CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(751, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl_Informacao);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_NomeMae;
        private System.Windows.Forms.Label Lbl_NomeMae;
        private System.Windows.Forms.TextBox Txt_NomePai;
        private System.Windows.Forms.Label Lbl_NomePai;
        private System.Windows.Forms.Label Lbl_Nascimento;
        private System.Windows.Forms.Label Lbl_Contato1;
        private System.Windows.Forms.MaskedTextBox Msk_Nascimento;
        private System.Windows.Forms.MaskedTextBox Msk_Contato1;
        private System.Windows.Forms.MaskedTextBox Msk_Contato2;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_Informacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox Msk_Cep;
        private System.Windows.Forms.TextBox Txt_UF;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_NomeDaRua;
    }
}