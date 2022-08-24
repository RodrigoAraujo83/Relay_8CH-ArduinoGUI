namespace desafio3_Portuga
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
            this.listaSenhas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.checkMaiuscula = new System.Windows.Forms.CheckBox();
            this.checkAlgarismo = new System.Windows.Forms.CheckBox();
            this.checkSimbolo = new System.Windows.Forms.CheckBox();
            this.btnGerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            this.SuspendLayout();
            // 
            // listaSenhas
            // 
            this.listaSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaSenhas.FormattingEnabled = true;
            this.listaSenhas.ItemHeight = 24;
            this.listaSenhas.Location = new System.Drawing.Point(12, 24);
            this.listaSenhas.Name = "listaSenhas";
            this.listaSenhas.Size = new System.Drawing.Size(216, 316);
            this.listaSenhas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "N ° Chars:";
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(234, 32);
            this.count.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.count.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(94, 26);
            this.count.TabIndex = 2;
            this.count.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // checkMaiuscula
            // 
            this.checkMaiuscula.AutoSize = true;
            this.checkMaiuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaiuscula.Location = new System.Drawing.Point(234, 75);
            this.checkMaiuscula.Name = "checkMaiuscula";
            this.checkMaiuscula.Size = new System.Drawing.Size(184, 28);
            this.checkMaiuscula.TabIndex = 3;
            this.checkMaiuscula.Text = "Usar MAIÚSCULA.";
            this.checkMaiuscula.UseVisualStyleBackColor = true;
            // 
            // checkAlgarismo
            // 
            this.checkAlgarismo.AutoSize = true;
            this.checkAlgarismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAlgarismo.Location = new System.Drawing.Point(234, 121);
            this.checkAlgarismo.Name = "checkAlgarismo";
            this.checkAlgarismo.Size = new System.Drawing.Size(167, 28);
            this.checkAlgarismo.TabIndex = 4;
            this.checkAlgarismo.Text = "Usar algarismos.";
            this.checkAlgarismo.UseVisualStyleBackColor = true;
            // 
            // checkSimbolo
            // 
            this.checkSimbolo.AutoSize = true;
            this.checkSimbolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSimbolo.Location = new System.Drawing.Point(234, 169);
            this.checkSimbolo.Name = "checkSimbolo";
            this.checkSimbolo.Size = new System.Drawing.Size(152, 28);
            this.checkSimbolo.TabIndex = 5;
            this.checkSimbolo.Text = "Usar símbolos.";
            this.checkSimbolo.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(238, 276);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(256, 66);
            this.btnGerar.TabIndex = 6;
            this.btnGerar.Text = "GERAR";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 353);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.checkSimbolo);
            this.Controls.Add(this.checkAlgarismo);
            this.Controls.Add(this.checkMaiuscula);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaSenhas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaSenhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown count;
        private System.Windows.Forms.CheckBox checkMaiuscula;
        private System.Windows.Forms.CheckBox checkAlgarismo;
        private System.Windows.Forms.CheckBox checkSimbolo;
        private System.Windows.Forms.Button btnGerar;
    }
}

