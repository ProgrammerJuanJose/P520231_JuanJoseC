using System;

namespace P520231_JuanJoseC.Forms
{
    partial class FrmLogin
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
            this.correo = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContrasennia = new System.Windows.Forms.TextBox();
            this.lblRecuperarContrasenia = new System.Windows.Forms.LinkLabel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerContrasennia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContrasennia)).BeginInit();
            this.SuspendLayout();
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.ForeColor = System.Drawing.SystemColors.Control;
            this.correo.Location = new System.Drawing.Point(28, 271);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(302, 38);
            this.correo.TabIndex = 0;
            this.correo.Text = "Correo electrónico";
            // 
            // contra
            // 
            this.contra.AutoSize = true;
            this.contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.ForeColor = System.Drawing.SystemColors.Control;
            this.contra.Location = new System.Drawing.Point(28, 367);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(196, 38);
            this.contra.TabIndex = 1;
            this.contra.Text = "Contraseña";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(33, 314);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(408, 30);
            this.txtEmail.TabIndex = 3;
            // 
            // txtContrasennia
            // 
            this.txtContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasennia.Location = new System.Drawing.Point(33, 408);
            this.txtContrasennia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContrasennia.Name = "txtContrasennia";
            this.txtContrasennia.Size = new System.Drawing.Size(408, 30);
            this.txtContrasennia.TabIndex = 4;
            this.txtContrasennia.UseSystemPasswordChar = true;
            // 
            // lblRecuperarContrasenia
            // 
            this.lblRecuperarContrasenia.AutoSize = true;
            this.lblRecuperarContrasenia.Location = new System.Drawing.Point(286, 442);
            this.lblRecuperarContrasenia.Name = "lblRecuperarContrasenia";
            this.lblRecuperarContrasenia.Size = new System.Drawing.Size(155, 18);
            this.lblRecuperarContrasenia.TabIndex = 5;
            this.lblRecuperarContrasenia.TabStop = true;
            this.lblRecuperarContrasenia.Text = "Recuperar contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Lime;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.Location = new System.Drawing.Point(33, 475);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(170, 40);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(270, 477);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 38);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P520231_JuanJoseC.Properties.Resources.p5logo1;
            this.pictureBox1.Location = new System.Drawing.Point(96, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerContrasennia
            // 
            this.btnVerContrasennia.BackColor = System.Drawing.SystemColors.Window;
            this.btnVerContrasennia.Image = global::P520231_JuanJoseC.Properties.Resources.ojo;
            this.btnVerContrasennia.Location = new System.Drawing.Point(405, 404);
            this.btnVerContrasennia.Name = "btnVerContrasennia";
            this.btnVerContrasennia.Size = new System.Drawing.Size(36, 35);
            this.btnVerContrasennia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVerContrasennia.TabIndex = 8;
            this.btnVerContrasennia.TabStop = false;
            this.btnVerContrasennia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVerContrasennia_MouseDown_1);
            this.btnVerContrasennia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVerContrasennia_MouseUp);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(474, 564);
            this.Controls.Add(this.btnVerContrasennia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblRecuperarContrasenia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.txtContrasennia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContrasennia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label contra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContrasennia;
        private System.Windows.Forms.LinkLabel lblRecuperarContrasenia;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox btnVerContrasennia;
    }
}