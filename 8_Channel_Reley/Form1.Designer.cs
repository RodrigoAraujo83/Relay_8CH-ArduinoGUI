namespace _8_Channel_Reley
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_status = new System.Windows.Forms.Label();
            this.btn_ch1OFF = new System.Windows.Forms.Button();
            this.btn_ch1ON = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConect
            // 
            this.btnConect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConect.Location = new System.Drawing.Point(12, 21);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(71, 23);
            this.btnConect.TabIndex = 0;
            this.btnConect.Text = "Conect";
            this.btnConect.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 443);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.btn_ch1OFF);
            this.groupBox1.Controls.Add(this.btn_ch1ON);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel 1";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_status.Location = new System.Drawing.Point(100, 33);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(57, 18);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Status";
            // 
            // btn_ch1OFF
            // 
            this.btn_ch1OFF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ch1OFF.Location = new System.Drawing.Point(186, 21);
            this.btn_ch1OFF.Name = "btn_ch1OFF";
            this.btn_ch1OFF.Size = new System.Drawing.Size(75, 44);
            this.btn_ch1OFF.TabIndex = 1;
            this.btn_ch1OFF.Text = "OFF";
            this.btn_ch1OFF.UseVisualStyleBackColor = true;
            // 
            // btn_ch1ON
            // 
            this.btn_ch1ON.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ch1ON.Location = new System.Drawing.Point(6, 21);
            this.btn_ch1ON.Name = "btn_ch1ON";
            this.btn_ch1ON.Size = new System.Drawing.Size(75, 44);
            this.btn_ch1ON.TabIndex = 0;
            this.btn_ch1ON.Text = "ON";
            this.btn_ch1ON.UseVisualStyleBackColor = true;
            this.btn_ch1ON.Click += new System.EventHandler(this.btn_ch1ON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnConect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConect;
        private ComboBox comboBox1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label_status;
        private Button btn_ch1OFF;
        private Button btn_ch1ON;
    }
}