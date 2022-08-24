namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screen = new System.Windows.Forms.TextBox();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_porcento = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_vezes = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_mais = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_nove = new System.Windows.Forms.Button();
            this.btn_oito = new System.Windows.Forms.Button();
            this.btn_sete = new System.Windows.Forms.Button();
            this.btn_seis = new System.Windows.Forms.Button();
            this.btn_cinco = new System.Windows.Forms.Button();
            this.btn_quatro = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.btn_dois = new System.Windows.Forms.Button();
            this.btn_um = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_ponto = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.screen.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.ForeColor = System.Drawing.Color.White;
            this.screen.Location = new System.Drawing.Point(12, 12);
            this.screen.MaximumSize = new System.Drawing.Size(500, 500);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(307, 32);
            this.screen.TabIndex = 0;
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.Black;
            this.btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.ForeColor = System.Drawing.Color.White;
            this.btn_c.Location = new System.Drawing.Point(12, 61);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(65, 40);
            this.btn_c.TabIndex = 1;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_porcento
            // 
            this.btn_porcento.BackColor = System.Drawing.Color.Black;
            this.btn_porcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_porcento.ForeColor = System.Drawing.Color.White;
            this.btn_porcento.Location = new System.Drawing.Point(94, 61);
            this.btn_porcento.Name = "btn_porcento";
            this.btn_porcento.Size = new System.Drawing.Size(65, 40);
            this.btn_porcento.TabIndex = 2;
            this.btn_porcento.Text = "%";
            this.btn_porcento.UseVisualStyleBackColor = false;
            // 
            // btn_dividir
            // 
            this.btn_dividir.BackColor = System.Drawing.Color.Black;
            this.btn_dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.ForeColor = System.Drawing.Color.White;
            this.btn_dividir.Location = new System.Drawing.Point(172, 61);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(65, 40);
            this.btn_dividir.TabIndex = 3;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = false;
            this.btn_dividir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_vezes
            // 
            this.btn_vezes.BackColor = System.Drawing.Color.Black;
            this.btn_vezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vezes.ForeColor = System.Drawing.Color.White;
            this.btn_vezes.Location = new System.Drawing.Point(256, 61);
            this.btn_vezes.Name = "btn_vezes";
            this.btn_vezes.Size = new System.Drawing.Size(65, 40);
            this.btn_vezes.TabIndex = 4;
            this.btn_vezes.Text = "X";
            this.btn_vezes.UseVisualStyleBackColor = false;
            this.btn_vezes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.BackColor = System.Drawing.Color.Black;
            this.btn_menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menos.ForeColor = System.Drawing.Color.White;
            this.btn_menos.Location = new System.Drawing.Point(254, 107);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(65, 40);
            this.btn_menos.TabIndex = 5;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = false;
            // 
            // btn_mais
            // 
            this.btn_mais.BackColor = System.Drawing.Color.Black;
            this.btn_mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mais.ForeColor = System.Drawing.Color.White;
            this.btn_mais.Location = new System.Drawing.Point(254, 153);
            this.btn_mais.Name = "btn_mais";
            this.btn_mais.Size = new System.Drawing.Size(65, 40);
            this.btn_mais.TabIndex = 6;
            this.btn_mais.Text = "+";
            this.btn_mais.UseVisualStyleBackColor = false;
            this.btn_mais.Click += new System.EventHandler(this.btn_mais_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.Color.Black;
            this.btn_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igual.ForeColor = System.Drawing.Color.White;
            this.btn_igual.Location = new System.Drawing.Point(254, 199);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(65, 86);
            this.btn_igual.TabIndex = 7;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            // 
            // btn_nove
            // 
            this.btn_nove.BackColor = System.Drawing.Color.Black;
            this.btn_nove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nove.ForeColor = System.Drawing.Color.White;
            this.btn_nove.Location = new System.Drawing.Point(172, 107);
            this.btn_nove.Name = "btn_nove";
            this.btn_nove.Size = new System.Drawing.Size(65, 40);
            this.btn_nove.TabIndex = 10;
            this.btn_nove.Text = "9";
            this.btn_nove.UseVisualStyleBackColor = false;
            // 
            // btn_oito
            // 
            this.btn_oito.BackColor = System.Drawing.Color.Black;
            this.btn_oito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oito.ForeColor = System.Drawing.Color.White;
            this.btn_oito.Location = new System.Drawing.Point(94, 107);
            this.btn_oito.Name = "btn_oito";
            this.btn_oito.Size = new System.Drawing.Size(65, 40);
            this.btn_oito.TabIndex = 9;
            this.btn_oito.Text = "8";
            this.btn_oito.UseVisualStyleBackColor = false;
            // 
            // btn_sete
            // 
            this.btn_sete.BackColor = System.Drawing.Color.Black;
            this.btn_sete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sete.ForeColor = System.Drawing.Color.White;
            this.btn_sete.Location = new System.Drawing.Point(12, 107);
            this.btn_sete.Name = "btn_sete";
            this.btn_sete.Size = new System.Drawing.Size(65, 40);
            this.btn_sete.TabIndex = 8;
            this.btn_sete.Text = "7";
            this.btn_sete.UseVisualStyleBackColor = false;
            // 
            // btn_seis
            // 
            this.btn_seis.BackColor = System.Drawing.Color.Black;
            this.btn_seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seis.ForeColor = System.Drawing.Color.White;
            this.btn_seis.Location = new System.Drawing.Point(172, 153);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(65, 40);
            this.btn_seis.TabIndex = 13;
            this.btn_seis.Text = "6";
            this.btn_seis.UseVisualStyleBackColor = false;
            // 
            // btn_cinco
            // 
            this.btn_cinco.BackColor = System.Drawing.Color.Black;
            this.btn_cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cinco.ForeColor = System.Drawing.Color.White;
            this.btn_cinco.Location = new System.Drawing.Point(94, 153);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(65, 40);
            this.btn_cinco.TabIndex = 12;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseVisualStyleBackColor = false;
            // 
            // btn_quatro
            // 
            this.btn_quatro.BackColor = System.Drawing.Color.Black;
            this.btn_quatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quatro.ForeColor = System.Drawing.Color.White;
            this.btn_quatro.Location = new System.Drawing.Point(12, 153);
            this.btn_quatro.Name = "btn_quatro";
            this.btn_quatro.Size = new System.Drawing.Size(65, 40);
            this.btn_quatro.TabIndex = 11;
            this.btn_quatro.Text = "4";
            this.btn_quatro.UseVisualStyleBackColor = false;
            // 
            // btn_tres
            // 
            this.btn_tres.BackColor = System.Drawing.Color.Black;
            this.btn_tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tres.ForeColor = System.Drawing.Color.White;
            this.btn_tres.Location = new System.Drawing.Point(172, 199);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(65, 40);
            this.btn_tres.TabIndex = 16;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = false;
            // 
            // btn_dois
            // 
            this.btn_dois.BackColor = System.Drawing.Color.Black;
            this.btn_dois.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dois.ForeColor = System.Drawing.Color.White;
            this.btn_dois.Location = new System.Drawing.Point(94, 199);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(65, 40);
            this.btn_dois.TabIndex = 15;
            this.btn_dois.Text = "2";
            this.btn_dois.UseVisualStyleBackColor = false;
            // 
            // btn_um
            // 
            this.btn_um.BackColor = System.Drawing.Color.Black;
            this.btn_um.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_um.ForeColor = System.Drawing.Color.White;
            this.btn_um.Location = new System.Drawing.Point(12, 199);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(65, 40);
            this.btn_um.TabIndex = 14;
            this.btn_um.Text = "1";
            this.btn_um.UseVisualStyleBackColor = false;
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.Black;
            this.btn_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Location = new System.Drawing.Point(172, 245);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(65, 40);
            this.btn_color.TabIndex = 19;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = false;
            // 
            // btn_ponto
            // 
            this.btn_ponto.BackColor = System.Drawing.Color.Black;
            this.btn_ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ponto.ForeColor = System.Drawing.Color.White;
            this.btn_ponto.Location = new System.Drawing.Point(94, 245);
            this.btn_ponto.Name = "btn_ponto";
            this.btn_ponto.Size = new System.Drawing.Size(65, 40);
            this.btn_ponto.TabIndex = 18;
            this.btn_ponto.Text = ".";
            this.btn_ponto.UseVisualStyleBackColor = false;
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.Black;
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.ForeColor = System.Drawing.Color.White;
            this.btn_zero.Location = new System.Drawing.Point(12, 245);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(65, 40);
            this.btn_zero.TabIndex = 17;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(331, 311);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_ponto);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_tres);
            this.Controls.Add(this.btn_dois);
            this.Controls.Add(this.btn_um);
            this.Controls.Add(this.btn_seis);
            this.Controls.Add(this.btn_cinco);
            this.Controls.Add(this.btn_quatro);
            this.Controls.Add(this.btn_nove);
            this.Controls.Add(this.btn_oito);
            this.Controls.Add(this.btn_sete);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_mais);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_vezes);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_porcento);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.screen);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_porcento;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_vezes;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.Button btn_mais;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_nove;
        private System.Windows.Forms.Button btn_oito;
        private System.Windows.Forms.Button btn_sete;
        private System.Windows.Forms.Button btn_seis;
        private System.Windows.Forms.Button btn_cinco;
        private System.Windows.Forms.Button btn_quatro;
        private System.Windows.Forms.Button btn_tres;
        private System.Windows.Forms.Button btn_dois;
        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_ponto;
        private System.Windows.Forms.Button btn_zero;
    }
}

