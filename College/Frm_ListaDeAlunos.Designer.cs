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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsAlunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Lista
            // 
            this.Dgv_Lista.AllowUserToAddRows = false;
            this.Dgv_Lista.AllowUserToDeleteRows = false;
            this.Dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Lista.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Lista.Name = "Dgv_Lista";
            this.Dgv_Lista.ReadOnly = true;
            this.Dgv_Lista.Size = new System.Drawing.Size(958, 461);
            this.Dgv_Lista.TabIndex = 0;
            // 
            // clsAlunoBindingSource
            // 
            this.clsAlunoBindingSource.DataSource = typeof(Cls_Uteis.Cls_Aluno);
            // 
            // Frm_ListaDeAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 461);
            this.Controls.Add(this.Dgv_Lista);
            this.Name = "Frm_ListaDeAlunos";
            this.Text = "Frm_ListaDeTurmas";
            this.Load += new System.EventHandler(this.Frm_ListaDeTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsAlunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clsAlunoBindingSource;
        private System.Windows.Forms.DataGridView Dgv_Lista;
    }
}