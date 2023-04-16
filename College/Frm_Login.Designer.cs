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
            Pic_ImagemLogin = new PictureBox();
            Lbl_Usuario = new Label();
            Txt_Usuario = new TextBox();
            Txt_Senha = new TextBox();
            Lbl_Senha = new Label();
            Btn_OK = new Button();
            Btn_Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)Pic_ImagemLogin).BeginInit();
            SuspendLayout();
            // 
            // Pic_ImagemLogin
            // 
            Pic_ImagemLogin.Image = Properties.Resources.imagem;
            Pic_ImagemLogin.Location = new Point(29, 34);
            Pic_ImagemLogin.Name = "Pic_ImagemLogin";
            Pic_ImagemLogin.Size = new Size(140, 140);
            Pic_ImagemLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic_ImagemLogin.TabIndex = 0;
            Pic_ImagemLogin.TabStop = false;
            // 
            // Lbl_Usuario
            // 
            Lbl_Usuario.AutoSize = true;
            Lbl_Usuario.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Usuario.Location = new Point(182, 34);
            Lbl_Usuario.Name = "Lbl_Usuario";
            Lbl_Usuario.Size = new Size(92, 23);
            Lbl_Usuario.TabIndex = 1;
            Lbl_Usuario.Text = "Usuário";
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.Location = new Point(189, 61);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(200, 23);
            Txt_Usuario.TabIndex = 2;
            // 
            // Txt_Senha
            // 
            Txt_Senha.Location = new Point(189, 114);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.Size = new Size(200, 23);
            Txt_Senha.TabIndex = 4;
            Txt_Senha.UseSystemPasswordChar = true;
            // 
            // Lbl_Senha
            // 
            Lbl_Senha.AutoSize = true;
            Lbl_Senha.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Senha.Location = new Point(182, 87);
            Lbl_Senha.Name = "Lbl_Senha";
            Lbl_Senha.Size = new Size(78, 23);
            Lbl_Senha.TabIndex = 3;
            Lbl_Senha.Text = "Senha";
            // 
            // Btn_OK
            // 
            Btn_OK.Location = new Point(185, 172);
            Btn_OK.Name = "Btn_OK";
            Btn_OK.Size = new Size(123, 31);
            Btn_OK.TabIndex = 5;
            Btn_OK.Text = "Entrar";
            Btn_OK.UseVisualStyleBackColor = true;
            Btn_OK.MouseDown += Btn_OK_MouseDown;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(314, 172);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(75, 31);
            Btn_Cancel.TabIndex = 6;
            Btn_Cancel.Text = "Cancelar";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(404, 215);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_OK);
            Controls.Add(Txt_Senha);
            Controls.Add(Lbl_Senha);
            Controls.Add(Txt_Usuario);
            Controls.Add(Lbl_Usuario);
            Controls.Add(Pic_ImagemLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)Pic_ImagemLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
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