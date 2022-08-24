namespace _8CH_Reley
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesligar1 = new System.Windows.Forms.Button();
            this.btnLigar1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesligar2 = new System.Windows.Forms.Button();
            this.btnLigar2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDesligar3 = new System.Windows.Forms.Button();
            this.btnLigar3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDesligar4 = new System.Windows.Forms.Button();
            this.btnLigar4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDesligar8 = new System.Windows.Forms.Button();
            this.btnLigar8 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDesligar7 = new System.Windows.Forms.Button();
            this.btnLigar7 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnDesligar6 = new System.Windows.Forms.Button();
            this.btnLigar6 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnDesligar5 = new System.Windows.Forms.Button();
            this.btnLigar5 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnAllOn = new System.Windows.Forms.Button();
            this.btnAllOff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(18, 12);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(222, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // timerCOM
            // 
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnDesligar1);
            this.groupBox1.Controls.Add(this.btnLigar1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel 1";
            // 
            // btnDesligar1
            // 
            this.btnDesligar1.BackColor = System.Drawing.SystemColors.Control;
            this.btnDesligar1.Location = new System.Drawing.Point(159, 25);
            this.btnDesligar1.Name = "btnDesligar1";
            this.btnDesligar1.Size = new System.Drawing.Size(69, 61);
            this.btnDesligar1.TabIndex = 1;
            this.btnDesligar1.Text = "OFF";
            this.btnDesligar1.UseVisualStyleBackColor = false;
            this.btnDesligar1.Click += new System.EventHandler(this.btnDesligar1_Click);
            // 
            // btnLigar1
            // 
            this.btnLigar1.BackColor = System.Drawing.SystemColors.Control;
            this.btnLigar1.Location = new System.Drawing.Point(6, 25);
            this.btnLigar1.Name = "btnLigar1";
            this.btnLigar1.Size = new System.Drawing.Size(69, 61);
            this.btnLigar1.TabIndex = 0;
            this.btnLigar1.Text = "ON";
            this.btnLigar1.UseVisualStyleBackColor = false;
            this.btnLigar1.Click += new System.EventHandler(this.btnLigar1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.btnDesligar2);
            this.groupBox2.Controls.Add(this.btnLigar2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channel 2";
            // 
            // btnDesligar2
            // 
            this.btnDesligar2.Location = new System.Drawing.Point(159, 25);
            this.btnDesligar2.Name = "btnDesligar2";
            this.btnDesligar2.Size = new System.Drawing.Size(69, 61);
            this.btnDesligar2.TabIndex = 1;
            this.btnDesligar2.Text = "OFF";
            this.btnDesligar2.UseVisualStyleBackColor = true;
            this.btnDesligar2.Click += new System.EventHandler(this.btnDesligar2_Click);
            // 
            // btnLigar2
            // 
            this.btnLigar2.Location = new System.Drawing.Point(6, 25);
            this.btnLigar2.Name = "btnLigar2";
            this.btnLigar2.Size = new System.Drawing.Size(69, 61);
            this.btnLigar2.TabIndex = 0;
            this.btnLigar2.Text = "ON";
            this.btnLigar2.UseVisualStyleBackColor = true;
            this.btnLigar2.Click += new System.EventHandler(this.btnLigar2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.btnDesligar3);
            this.groupBox3.Controls.Add(this.btnLigar3);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 92);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Channel 3";
            // 
            // btnDesligar3
            // 
            this.btnDesligar3.Location = new System.Drawing.Point(159, 25);
            this.btnDesligar3.Name = "btnDesligar3";
            this.btnDesligar3.Size = new System.Drawing.Size(69, 61);
            this.btnDesligar3.TabIndex = 1;
            this.btnDesligar3.Text = "OFF";
            this.btnDesligar3.UseVisualStyleBackColor = true;
            this.btnDesligar3.Click += new System.EventHandler(this.btnDesligar3_Click);
            // 
            // btnLigar3
            // 
            this.btnLigar3.Location = new System.Drawing.Point(6, 25);
            this.btnLigar3.Name = "btnLigar3";
            this.btnLigar3.Size = new System.Drawing.Size(69, 61);
            this.btnLigar3.TabIndex = 0;
            this.btnLigar3.Text = "ON";
            this.btnLigar3.UseVisualStyleBackColor = true;
            this.btnLigar3.Click += new System.EventHandler(this.btnLigar3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox4.Controls.Add(this.btnDesligar4);
            this.groupBox4.Controls.Add(this.btnLigar4);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 92);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Channel 4";
            // 
            // btnDesligar4
            // 
            this.btnDesligar4.Location = new System.Drawing.Point(159, 25);
            this.btnDesligar4.Name = "btnDesligar4";
            this.btnDesligar4.Size = new System.Drawing.Size(69, 61);
            this.btnDesligar4.TabIndex = 1;
            this.btnDesligar4.Text = "OFF";
            this.btnDesligar4.UseVisualStyleBackColor = true;
            this.btnDesligar4.Click += new System.EventHandler(this.btnDesligar4_Click);
            // 
            // btnLigar4
            // 
            this.btnLigar4.Location = new System.Drawing.Point(6, 25);
            this.btnLigar4.Name = "btnLigar4";
            this.btnLigar4.Size = new System.Drawing.Size(69, 61);
            this.btnLigar4.TabIndex = 0;
            this.btnLigar4.Text = "ON";
            this.btnLigar4.UseVisualStyleBackColor = true;
            this.btnLigar4.Click += new System.EventHandler(this.btnLigar4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox5.Controls.Add(this.btnDesligar8);
            this.groupBox5.Controls.Add(this.btnLigar8);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(267, 413);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 92);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Channel 8";
            // 
            // btnDesligar8
            // 
            this.btnDesligar8.Location = new System.Drawing.Point(159, 25);
            this.btnDesligar8.Name = "btnDesligar8";
            this.btnDesligar8.Size = new System.Drawing.Size(69, 61);
            this.btnDesligar8.TabIndex = 1;
            this.btnDesligar8.Text = "OFF";
            this.btnDesligar8.UseVisualStyleBackColor = true;
            this.btnDesligar8.Click += new System.EventHandler(this.btnDesligar8_Click);
            // 
            // btnLigar8
            // 
            this.btnLigar8.Location = new System.Drawing.Point(6, 25);
            this.btnLigar8.Name = "btnLigar8";
            this.btnLigar8.Size = new System.Drawing.Size(69, 61);
            this.btnLigar8.TabIndex = 0;
            this.btnLigar8.Text = "ON";
            this.btnLigar8.UseVisualStyleBackColor = true;
            this.btnLigar8.Click += new System.EventHandler(this.btnLigar8_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox6.Controls.Add(this.btnDesligar7);
            this.groupBox6.Controls.Add(this.btnLigar7);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(267, 307);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(234, 92);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Channel 7";
            // 
            // btnDesligar7
            // 
            this.btnDesligar7.Location = new System.Drawing.Point(159, 25);
            this.btnDesligar7.Name = "btnDesligar7";
            this.btnDesligar7.Size = new System.Drawing.Size(69, 61);
            this.btnDesligar7.TabIndex = 1;
            this.btnDesligar7.Text = "OFF";
            this.btnDesligar7.UseVisualStyleBackColor = true;
            this.btnDesligar7.Click += new System.EventHandler(this.btnDesligar7_Click);
            // 
            // btnLigar7
            // 
            this.btnLigar7.Location = new System.Drawing.Point(6, 25);
            this.btnLigar7.Name = "btnLigar7";
            this.btnLigar7.Size = new System.Drawing.Size(69, 61);
            this.btnLigar7.TabIndex = 0;
            this.btnLigar7.Text = "ON";
            this.btnLigar7.UseVisualStyleBackColor = true;
            this.btnLigar7.Click += new System.EventHandler(this.btnLigar7_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox7.Controls.Add(this.btnDesligar6);
            this.groupBox7.Controls.Add(this.btnLigar6);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(267, 209);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(234, 92);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Channel 6";
            // 
            // btnDesligar6
            // 
            this.btnDesligar6.Location = new System.Drawing.Point(159, 25);
            this.btnDesligar6.Name = "btnDesligar6";
            this.btnDesligar6.Size = new System.Drawing.Size(69, 61);
            this.btnDesligar6.TabIndex = 1;
            this.btnDesligar6.Text = "OFF";
            this.btnDesligar6.UseVisualStyleBackColor = true;
            this.btnDesligar6.Click += new System.EventHandler(this.btnDesligar6_Click);
            // 
            // btnLigar6
            // 
            this.btnLigar6.Location = new System.Drawing.Point(6, 25);
            this.btnLigar6.Name = "btnLigar6";
            this.btnLigar6.Size = new System.Drawing.Size(69, 61);
            this.btnLigar6.TabIndex = 0;
            this.btnLigar6.Text = "ON";
            this.btnLigar6.UseVisualStyleBackColor = true;
            this.btnLigar6.Click += new System.EventHandler(this.btnLigar6_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox8.Controls.Add(this.btnDesligar5);
            this.groupBox8.Controls.Add(this.btnLigar5);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(267, 111);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(234, 92);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Channel 5";
            // 
            // btnDesligar5
            // 
            this.btnDesligar5.Location = new System.Drawing.Point(159, 25);
            this.btnDesligar5.Name = "btnDesligar5";
            this.btnDesligar5.Size = new System.Drawing.Size(69, 61);
            this.btnDesligar5.TabIndex = 1;
            this.btnDesligar5.Text = "OFF";
            this.btnDesligar5.UseVisualStyleBackColor = true;
            this.btnDesligar5.Click += new System.EventHandler(this.btnDesligar5_Click);
            // 
            // btnLigar5
            // 
            this.btnLigar5.Location = new System.Drawing.Point(6, 25);
            this.btnLigar5.Name = "btnLigar5";
            this.btnLigar5.Size = new System.Drawing.Size(69, 61);
            this.btnLigar5.TabIndex = 0;
            this.btnLigar5.Text = "ON";
            this.btnLigar5.UseVisualStyleBackColor = true;
            this.btnLigar5.Click += new System.EventHandler(this.btnLigar5_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Silver;
            this.groupBox9.Controls.Add(this.btnAllOff);
            this.groupBox9.Controls.Add(this.btnAllOn);
            this.groupBox9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(267, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(235, 93);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "All Channels";
            // 
            // btnAllOn
            // 
            this.btnAllOn.Location = new System.Drawing.Point(6, 33);
            this.btnAllOn.Name = "btnAllOn";
            this.btnAllOn.Size = new System.Drawing.Size(100, 54);
            this.btnAllOn.TabIndex = 0;
            this.btnAllOn.Text = "ALL ON";
            this.btnAllOn.UseVisualStyleBackColor = true;
            this.btnAllOn.Click += new System.EventHandler(this.btnAllOn_Click);
            // 
            // btnAllOff
            // 
            this.btnAllOff.Location = new System.Drawing.Point(128, 33);
            this.btnAllOff.Name = "btnAllOff";
            this.btnAllOff.Size = new System.Drawing.Size(100, 54);
            this.btnAllOff.TabIndex = 1;
            this.btnAllOff.Text = "ALL OFF";
            this.btnAllOff.UseVisualStyleBackColor = true;
            this.btnAllOff.Click += new System.EventHandler(this.btnAllOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 513);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnConectar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Relé 8 CH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDesligar1;
        private System.Windows.Forms.Button btnLigar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDesligar2;
        private System.Windows.Forms.Button btnLigar2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDesligar3;
        private System.Windows.Forms.Button btnLigar3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDesligar4;
        private System.Windows.Forms.Button btnLigar4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDesligar8;
        private System.Windows.Forms.Button btnLigar8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDesligar7;
        private System.Windows.Forms.Button btnLigar7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnDesligar6;
        private System.Windows.Forms.Button btnLigar6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnDesligar5;
        private System.Windows.Forms.Button btnLigar5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnAllOff;
        private System.Windows.Forms.Button btnAllOn;
    }
}

