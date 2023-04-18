using System.Drawing;
using System.Windows.Forms;

namespace College
{
    partial class Frm_Login
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
            this.Pic_ImagemLogin = new System.Windows.Forms.PictureBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ImagemLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_ImagemLogin
            // 
            this.Pic_ImagemLogin.Image = global::College.Properties.Resources.imagem;
            this.Pic_ImagemLogin.Location = new System.Drawing.Point(25, 29);
            this.Pic_ImagemLogin.Name = "Pic_ImagemLogin";
            this.Pic_ImagemLogin.Size = new System.Drawing.Size(120, 121);
            this.Pic_ImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_ImagemLogin.TabIndex = 0;
            this.Pic_ImagemLogin.TabStop = false;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Usuario.Location = new System.Drawing.Point(156, 29);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(92, 23);
            this.Lbl_Usuario.TabIndex = 1;
            this.Lbl_Usuario.Text = "Usuário";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(162, 53);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(172, 20);
            this.Txt_Usuario.TabIndex = 2;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(162, 99);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(172, 20);
            this.Txt_Senha.TabIndex = 4;
            this.Txt_Senha.UseSystemPasswordChar = true;
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Senha.Location = new System.Drawing.Point(156, 75);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(78, 23);
            this.Lbl_Senha.TabIndex = 3;
            this.Lbl_Senha.Text = "Senha";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(159, 149);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(105, 27);
            this.Btn_OK.TabIndex = 5;
            this.Btn_OK.Text = "Entrar";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_OK_MouseDown);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(269, 149);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(64, 27);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(346, 186);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Pic_ImagemLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ImagemLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Pic_ImagemLogin;
        private Label Lbl_Usuario;
        private TextBox Txt_Usuario;
        private TextBox Txt_Senha;
        private Label Lbl_Senha;
        private Button Btn_OK;
        private Button Btn_Cancel;
    }
}