namespace Telescope_Motor_UI
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConect = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHomePosition = new System.Windows.Forms.Button();
            this.boxHome = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMoonFollow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxMoon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.speedRadio50 = new System.Windows.Forms.RadioButton();
            this.speedRadio40 = new System.Windows.Forms.RadioButton();
            this.speedRadio30 = new System.Windows.Forms.RadioButton();
            this.speedRadio20 = new System.Windows.Forms.RadioButton();
            this.btnDecRight = new System.Windows.Forms.Button();
            this.btnDecLeft = new System.Windows.Forms.Button();
            this.btnRacDown = new System.Windows.Forms.Button();
            this.btnRacUp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.radioButton100 = new System.Windows.Forms.RadioButton();
            this.radioButton60 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.btnFocusLess = new System.Windows.Forms.Button();
            this.btnFocusPlus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMoon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM10";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.arduino_22429;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.microsoft_visual_studio_macos_bigsur_icon_189958;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnConect);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnConect
            // 
            this.btnConect.BackColor = System.Drawing.Color.LightGray;
            this.btnConect.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.usbconnected;
            resources.ApplyResources(this.btnConect, "btnConect");
            this.btnConect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConect.FlatAppearance.BorderSize = 0;
            this.btnConect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConect.ForeColor = System.Drawing.Color.Transparent;
            this.btnConect.Name = "btnConect";
            this.btnConect.UseVisualStyleBackColor = false;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.comboBox1);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("comboBox1.AutoCompleteCustomSource"),
            resources.GetString("comboBox1.AutoCompleteCustomSource1"),
            resources.GetString("comboBox1.AutoCompleteCustomSource2"),
            resources.GetString("comboBox1.AutoCompleteCustomSource3"),
            resources.GetString("comboBox1.AutoCompleteCustomSource4"),
            resources.GetString("comboBox1.AutoCompleteCustomSource5"),
            resources.GetString("comboBox1.AutoCompleteCustomSource6"),
            resources.GetString("comboBox1.AutoCompleteCustomSource7")});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btnExit);
            this.panel6.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.exit_closethesession_close_6317;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.btnHomePosition);
            this.groupBox3.Controls.Add(this.boxHome);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnMoonFollow);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.boxMoon);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnHomePosition
            // 
            this.btnHomePosition.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.spacefm_103907;
            resources.ApplyResources(this.btnHomePosition, "btnHomePosition");
            this.btnHomePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePosition.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnHomePosition.FlatAppearance.BorderSize = 0;
            this.btnHomePosition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHomePosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHomePosition.Name = "btnHomePosition";
            this.btnHomePosition.UseVisualStyleBackColor = true;
            this.btnHomePosition.MarginChanged += new System.EventHandler(this.btnHomePosition_Click);
            this.btnHomePosition.Click += new System.EventHandler(this.btnHomePosition_Click);
            // 
            // boxHome
            // 
            resources.ApplyResources(this.boxHome, "boxHome");
            this.boxHome.Name = "boxHome";
            this.boxHome.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btnMoonFollow
            // 
            this.btnMoonFollow.BackColor = System.Drawing.Color.Transparent;
            this.btnMoonFollow.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.moon_worldtime_luna_1465;
            resources.ApplyResources(this.btnMoonFollow, "btnMoonFollow");
            this.btnMoonFollow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoonFollow.FlatAppearance.BorderSize = 0;
            this.btnMoonFollow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMoonFollow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMoonFollow.Name = "btnMoonFollow";
            this.btnMoonFollow.UseVisualStyleBackColor = false;
            this.btnMoonFollow.Click += new System.EventHandler(this.btnMoonFollow_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // boxMoon
            // 
            this.boxMoon.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.boxMoon, "boxMoon");
            this.boxMoon.Name = "boxMoon";
            this.boxMoon.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.night_sky;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.btnDecRight);
            this.panel1.Controls.Add(this.btnDecLeft);
            this.panel1.Controls.Add(this.btnRacDown);
            this.panel1.Controls.Add(this.btnRacUp);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.speedRadio50);
            this.groupBox5.Controls.Add(this.speedRadio40);
            this.groupBox5.Controls.Add(this.speedRadio30);
            this.groupBox5.Controls.Add(this.speedRadio20);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // speedRadio50
            // 
            resources.ApplyResources(this.speedRadio50, "speedRadio50");
            this.speedRadio50.ForeColor = System.Drawing.Color.Navy;
            this.speedRadio50.Name = "speedRadio50";
            this.speedRadio50.TabStop = true;
            this.speedRadio50.UseVisualStyleBackColor = true;
            // 
            // speedRadio40
            // 
            resources.ApplyResources(this.speedRadio40, "speedRadio40");
            this.speedRadio40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.speedRadio40.Name = "speedRadio40";
            this.speedRadio40.TabStop = true;
            this.speedRadio40.UseVisualStyleBackColor = true;
            // 
            // speedRadio30
            // 
            resources.ApplyResources(this.speedRadio30, "speedRadio30");
            this.speedRadio30.ForeColor = System.Drawing.Color.Blue;
            this.speedRadio30.Name = "speedRadio30";
            this.speedRadio30.TabStop = true;
            this.speedRadio30.UseVisualStyleBackColor = true;
            // 
            // speedRadio20
            // 
            resources.ApplyResources(this.speedRadio20, "speedRadio20");
            this.speedRadio20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.speedRadio20.Name = "speedRadio20";
            this.speedRadio20.TabStop = true;
            this.speedRadio20.UseVisualStyleBackColor = true;
            // 
            // btnDecRight
            // 
            this.btnDecRight.BackColor = System.Drawing.Color.Transparent;
            this.btnDecRight.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.arrow_right_15600;
            resources.ApplyResources(this.btnDecRight, "btnDecRight");
            this.btnDecRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecRight.FlatAppearance.BorderSize = 0;
            this.btnDecRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDecRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDecRight.ForeColor = System.Drawing.Color.Transparent;
            this.btnDecRight.Name = "btnDecRight";
            this.btnDecRight.UseVisualStyleBackColor = false;
            this.btnDecRight.Click += new System.EventHandler(this.btnDecRight_Click);
            // 
            // btnDecLeft
            // 
            this.btnDecLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnDecLeft.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.arrow_left_15601;
            resources.ApplyResources(this.btnDecLeft, "btnDecLeft");
            this.btnDecLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecLeft.FlatAppearance.BorderSize = 0;
            this.btnDecLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDecLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDecLeft.ForeColor = System.Drawing.Color.Transparent;
            this.btnDecLeft.Name = "btnDecLeft";
            this.btnDecLeft.UseVisualStyleBackColor = false;
            this.btnDecLeft.Click += new System.EventHandler(this.btnDecLeft_Click);
            // 
            // btnRacDown
            // 
            this.btnRacDown.BackColor = System.Drawing.Color.Transparent;
            this.btnRacDown.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.arrow_dw_15603;
            resources.ApplyResources(this.btnRacDown, "btnRacDown");
            this.btnRacDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRacDown.FlatAppearance.BorderSize = 0;
            this.btnRacDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRacDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRacDown.ForeColor = System.Drawing.Color.Transparent;
            this.btnRacDown.Name = "btnRacDown";
            this.btnRacDown.UseVisualStyleBackColor = false;
            this.btnRacDown.Click += new System.EventHandler(this.btnRacDown_Click);
            // 
            // btnRacUp
            // 
            this.btnRacUp.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnRacUp.BackColor = System.Drawing.Color.Transparent;
            this.btnRacUp.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.arrow_top_15603;
            resources.ApplyResources(this.btnRacUp, "btnRacUp");
            this.btnRacUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRacUp.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnRacUp.FlatAppearance.BorderSize = 0;
            this.btnRacUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRacUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRacUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnRacUp.Name = "btnRacUp";
            this.btnRacUp.UseVisualStyleBackColor = false;
            this.btnRacUp.Click += new System.EventHandler(this.btnRacUp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.night_sky;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.btnFocusLess);
            this.panel2.Controls.Add(this.btnFocusPlus);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonDefault);
            this.groupBox4.Controls.Add(this.radioButton100);
            this.groupBox4.Controls.Add(this.radioButton60);
            this.groupBox4.Controls.Add(this.radioButton30);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // radioButtonDefault
            // 
            resources.ApplyResources(this.radioButtonDefault, "radioButtonDefault");
            this.radioButtonDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            // 
            // radioButton100
            // 
            resources.ApplyResources(this.radioButton100, "radioButton100");
            this.radioButton100.ForeColor = System.Drawing.Color.Navy;
            this.radioButton100.Name = "radioButton100";
            this.radioButton100.TabStop = true;
            this.radioButton100.UseVisualStyleBackColor = true;
            // 
            // radioButton60
            // 
            resources.ApplyResources(this.radioButton60, "radioButton60");
            this.radioButton60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButton60.Name = "radioButton60";
            this.radioButton60.TabStop = true;
            this.radioButton60.UseVisualStyleBackColor = true;
            // 
            // radioButton30
            // 
            resources.ApplyResources(this.radioButton30, "radioButton30");
            this.radioButton30.ForeColor = System.Drawing.Color.Blue;
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.TabStop = true;
            this.radioButton30.UseVisualStyleBackColor = true;
            // 
            // btnFocusLess
            // 
            this.btnFocusLess.BackColor = System.Drawing.Color.Transparent;
            this.btnFocusLess.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.Minus_36877;
            resources.ApplyResources(this.btnFocusLess, "btnFocusLess");
            this.btnFocusLess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFocusLess.FlatAppearance.BorderSize = 0;
            this.btnFocusLess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFocusLess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFocusLess.ForeColor = System.Drawing.Color.Transparent;
            this.btnFocusLess.Name = "btnFocusLess";
            this.btnFocusLess.UseVisualStyleBackColor = false;
            this.btnFocusLess.Click += new System.EventHandler(this.btnFocusLess_Click);
            // 
            // btnFocusPlus
            // 
            this.btnFocusPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnFocusPlus.BackgroundImage = global::Telescope_Motor_UI.Properties.Resources.Plus_36851;
            resources.ApplyResources(this.btnFocusPlus, "btnFocusPlus");
            this.btnFocusPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFocusPlus.FlatAppearance.BorderSize = 0;
            this.btnFocusPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFocusPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFocusPlus.ForeColor = System.Drawing.Color.Transparent;
            this.btnFocusPlus.Name = "btnFocusPlus";
            this.btnFocusPlus.UseVisualStyleBackColor = false;
            this.btnFocusPlus.Click += new System.EventHandler(this.btnFocusPlus_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMoon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRacUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFocusLess;
        private System.Windows.Forms.Button btnFocusPlus;
        private System.Windows.Forms.Button btnDecRight;
        private System.Windows.Forms.Button btnDecLeft;
        private System.Windows.Forms.Button btnRacDown;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnHomePosition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMoonFollow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox boxMoon;
        private System.Windows.Forms.PictureBox boxHome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton100;
        private System.Windows.Forms.RadioButton radioButton60;
        private System.Windows.Forms.RadioButton radioButton30;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton speedRadio50;
        private System.Windows.Forms.RadioButton speedRadio40;
        private System.Windows.Forms.RadioButton speedRadio30;
        private System.Windows.Forms.RadioButton speedRadio20;
    }
}

