namespace College
{
    partial class Frm_ListaDeAlunos
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
            this.components = new System.ComponentModel.Container();
            this.Dgv_Lista = new System.Windows.Forms.DataGridView();
            this.clsAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_GerirNotas = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_EditarDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsAlunoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Lista
            // 
            this.Dgv_Lista.AllowUserToAddRows = false;
            this.Dgv_Lista.AllowUserToDeleteRows = false;
            this.Dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Lista.Location = new System.Drawing.Point(149, 2);
            this.Dgv_Lista.Name = "Dgv_Lista";
            this.Dgv_Lista.ReadOnly = true;
            this.Dgv_Lista.Size = new System.Drawing.Size(809, 461);
            this.Dgv_Lista.TabIndex = 0;
            // 
            // clsAlunoBindingSource
            // 
            this.clsAlunoBindingSource.DataSource = typeof(Cls_Uteis.Cls_Aluno);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_GerirNotas);
            this.panel1.Controls.Add(this.Btn_Cancelar);
            this.panel1.Controls.Add(this.Btn_EditarDados);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 461);
            this.panel1.TabIndex = 1;
            // 
            // Btn_GerirNotas
            // 
            this.Btn_GerirNotas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_GerirNotas.Location = new System.Drawing.Point(12, 142);
            this.Btn_GerirNotas.Name = "Btn_GerirNotas";
            this.Btn_GerirNotas.Size = new System.Drawing.Size(122, 54);
            this.Btn_GerirNotas.TabIndex = 23;
            this.Btn_GerirNotas.Text = "Gerir Notas";
            this.Btn_GerirNotas.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Location = new System.Drawing.Point(12, 393);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(122, 54);
            this.Btn_Cancelar.TabIndex = 22;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarDados
            // 
            this.Btn_EditarDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_EditarDados.Location = new System.Drawing.Point(12, 202);
            this.Btn_EditarDados.Name = "Btn_EditarDados";
            this.Btn_EditarDados.Size = new System.Drawing.Size(122, 54);
            this.Btn_EditarDados.TabIndex = 21;
            this.Btn_EditarDados.Text = "Editar Dados";
            this.Btn_EditarDados.UseVisualStyleBackColor = true;
            // 
            // Frm_ListaDeAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_Lista);
            this.Name = "Frm_ListaDeAlunos";
            this.Text = "Frm_ListaDeTurmas";
            this.Load += new System.EventHandler(this.Frm_ListaDeTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsAlunoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clsAlunoBindingSource;
        private System.Windows.Forms.DataGridView Dgv_Lista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_GerirNotas;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_EditarDados;
    }
}