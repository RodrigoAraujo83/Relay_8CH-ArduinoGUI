namespace desafio1_Portuga
{
    partial class Form1
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
            this.btn_conectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_conectar
            // 
            this.btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.Location = new System.Drawing.Point(173, 270);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(99, 29);
            this.btn_conectar.TabIndex = 2;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(84, 107);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(188, 20);
            this.text_usuario.TabIndex = 0;
            this.text_usuario.TextChanged += new System.EventHandler(this.text_textChanged);
            this.text_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_usuario_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(84, 177);
            this.text_senha.Name = "text_senha";
            this.text_senha.Size = new System.Drawing.Size(188, 20);
            this.text_senha.TabIndex = 1;
            this.text_senha.TextChanged += new System.EventHandler(this.text_textChanged);
            this.text_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_senha_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 311);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_conectar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_senha;
    }
}

