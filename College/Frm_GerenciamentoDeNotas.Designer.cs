namespace College
{
    partial class Frm_GerenciamentoDeNotas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_NomeAluno = new System.Windows.Forms.Label();
            this.Btn_ShowResumoDoAluno = new System.Windows.Forms.Button();
            this.Btn_ShowFrequenciaDoAluno = new System.Windows.Forms.Button();
            this.Btn_ShowNotasDoBimestre = new System.Windows.Forms.Button();
            this.Btn_ShowDadosDoAluno = new System.Windows.Forms.Button();
            this.Tbc_Display = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_NomeAluno);
            this.panel1.Controls.Add(this.Btn_ShowResumoDoAluno);
            this.panel1.Controls.Add(this.Btn_ShowFrequenciaDoAluno);
            this.panel1.Controls.Add(this.Btn_ShowNotasDoBimestre);
            this.panel1.Controls.Add(this.Btn_ShowDadosDoAluno);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 461);
            this.panel1.TabIndex = 2;
            // 
            // Lbl_NomeAluno
            // 
            this.Lbl_NomeAluno.AutoSize = true;
            this.Lbl_NomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeAluno.Location = new System.Drawing.Point(13, 37);
            this.Lbl_NomeAluno.Name = "Lbl_NomeAluno";
            this.Lbl_NomeAluno.Size = new System.Drawing.Size(162, 25);
            this.Lbl_NomeAluno.TabIndex = 4;
            this.Lbl_NomeAluno.Text = "Nome Do Aluno";
            // 
            // Btn_ShowResumoDoAluno
            // 
            this.Btn_ShowResumoDoAluno.Location = new System.Drawing.Point(3, 339);
            this.Btn_ShowResumoDoAluno.Name = "Btn_ShowResumoDoAluno";
            this.Btn_ShowResumoDoAluno.Size = new System.Drawing.Size(202, 63);
            this.Btn_ShowResumoDoAluno.TabIndex = 3;
            this.Btn_ShowResumoDoAluno.Text = "Resumo do Aluno";
            this.Btn_ShowResumoDoAluno.UseVisualStyleBackColor = true;
            // 
            // Btn_ShowFrequenciaDoAluno
            // 
            this.Btn_ShowFrequenciaDoAluno.Location = new System.Drawing.Point(3, 270);
            this.Btn_ShowFrequenciaDoAluno.Name = "Btn_ShowFrequenciaDoAluno";
            this.Btn_ShowFrequenciaDoAluno.Size = new System.Drawing.Size(202, 63);
            this.Btn_ShowFrequenciaDoAluno.TabIndex = 2;
            this.Btn_ShowFrequenciaDoAluno.Text = "Frequencia";
            this.Btn_ShowFrequenciaDoAluno.UseVisualStyleBackColor = true;
            // 
            // Btn_ShowNotasDoBimestre
            // 
            this.Btn_ShowNotasDoBimestre.Location = new System.Drawing.Point(3, 201);
            this.Btn_ShowNotasDoBimestre.Name = "Btn_ShowNotasDoBimestre";
            this.Btn_ShowNotasDoBimestre.Size = new System.Drawing.Size(202, 63);
            this.Btn_ShowNotasDoBimestre.TabIndex = 1;
            this.Btn_ShowNotasDoBimestre.Text = "Notas do Bimestre";
            this.Btn_ShowNotasDoBimestre.UseVisualStyleBackColor = true;
            this.Btn_ShowNotasDoBimestre.Click += new System.EventHandler(this.Btn_ShowNotasDoBimestre_Click);
            // 
            // Btn_ShowDadosDoAluno
            // 
            this.Btn_ShowDadosDoAluno.Location = new System.Drawing.Point(4, 132);
            this.Btn_ShowDadosDoAluno.Name = "Btn_ShowDadosDoAluno";
            this.Btn_ShowDadosDoAluno.Size = new System.Drawing.Size(202, 63);
            this.Btn_ShowDadosDoAluno.TabIndex = 0;
            this.Btn_ShowDadosDoAluno.Text = "Dados do Aluno";
            this.Btn_ShowDadosDoAluno.UseVisualStyleBackColor = true;
            this.Btn_ShowDadosDoAluno.Click += new System.EventHandler(this.Btn_ShowDadosDoAluno_Click);
            // 
            // Tbc_Display
            // 
            this.Tbc_Display.Location = new System.Drawing.Point(208, 0);
            this.Tbc_Display.Name = "Tbc_Display";
            this.Tbc_Display.SelectedIndex = 0;
            this.Tbc_Display.Size = new System.Drawing.Size(751, 460);
            this.Tbc_Display.TabIndex = 4;
            // 
            // Frm_GerenciamentoDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 461);
            this.Controls.Add(this.Tbc_Display);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Frm_GerenciamentoDeNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_GerenciamentoDeNotas";
            this.Load += new System.EventHandler(this.Frm_GerenciamentoDeNotas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_NomeAluno;
        private System.Windows.Forms.Button Btn_ShowResumoDoAluno;
        private System.Windows.Forms.Button Btn_ShowFrequenciaDoAluno;
        private System.Windows.Forms.Button Btn_ShowNotasDoBimestre;
        private System.Windows.Forms.Button Btn_ShowDadosDoAluno;
        private System.Windows.Forms.TabControl Tbc_Display;
    }
}