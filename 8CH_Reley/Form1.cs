using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _8CH_Reley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
                   
        }
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }
        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    comboBox1.Enabled = false;
                    btnConectar.Text = "Desconectar";
                    serialPort1.Write("k");
                    this.btnDesligar1.BackColor = Color.Red;
                    this.btnDesligar2.BackColor = Color.Red;
                    this.btnDesligar3.BackColor = Color.Red;
                    this.btnDesligar4.BackColor = Color.Red;
                    this.btnDesligar5.BackColor = Color.Red;
                    this.btnDesligar6.BackColor = Color.Red;
                    this.btnDesligar7.BackColor = Color.Red;
                    this.btnDesligar8.BackColor = Color.Red;
                    this.btnAllOff.BackColor = Color.Red;
                    this.btnLigar1.BackColor = DefaultBackColor;
                    this.btnLigar2.BackColor = DefaultBackColor;
                    this.btnLigar3.BackColor = DefaultBackColor;
                    this.btnLigar4.BackColor = DefaultBackColor;
                    this.btnLigar5.BackColor = DefaultBackColor;
                    this.btnLigar6.BackColor = DefaultBackColor;
                    this.btnLigar7.BackColor = DefaultBackColor;
                    this.btnLigar8.BackColor = DefaultBackColor;
                    this.btnAllOn.BackColor = DefaultBackColor;
                      

                }
            }
            else
            {

                try
                {
                    serialPort1.Write("k");
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btnConectar.Text = "Conectar";
                    this.btnDesligar1.BackColor = DefaultBackColor;
                    this.btnDesligar2.BackColor = DefaultBackColor;
                    this.btnDesligar3.BackColor = DefaultBackColor;
                    this.btnDesligar4.BackColor = DefaultBackColor;
                    this.btnDesligar5.BackColor = DefaultBackColor;
                    this.btnDesligar6.BackColor = DefaultBackColor;
                    this.btnDesligar7.BackColor = DefaultBackColor;
                    this.btnDesligar8.BackColor = DefaultBackColor;
                    this.btnLigar1.BackColor = DefaultBackColor;
                    this.btnLigar2.BackColor = DefaultBackColor;
                    this.btnLigar3.BackColor = DefaultBackColor;
                    this.btnLigar4.BackColor = DefaultBackColor;
                    this.btnLigar5.BackColor = DefaultBackColor;
                    this.btnLigar6.BackColor = DefaultBackColor;
                    this.btnLigar7.BackColor = DefaultBackColor;
                    this.btnLigar8.BackColor = DefaultBackColor;
                    this.btnAllOn.BackColor = DefaultBackColor;
                    this.btnAllOff.BackColor = DefaultBackColor;
                }
                catch
                {
                    return;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
                serialPort1.Close();            //fecha a porta
        }

        private void btnLigar1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("A");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar1.BackColor = Color.LightGreen;
                this.btnDesligar1.BackColor = DefaultBackColor;
                this.btnAllOff.BackColor = DefaultBackColor;
            }
        }
        private void btnDesligar1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("a");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnDesligar1.BackColor = Color.Red;
                this.btnLigar1.BackColor = DefaultBackColor;
                this.btnAllOn.BackColor = DefaultBackColor;

            }
        }

        private void btnLigar2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("B");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar2.BackColor = Color.LightGreen;
                this.btnDesligar2.BackColor = DefaultBackColor;
                this.btnAllOff.BackColor = DefaultBackColor;

            }

        }

        private void btnDesligar2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("b");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar2.BackColor = DefaultBackColor;
                this.btnDesligar2.BackColor = Color.Red;
                this.btnAllOn.BackColor = DefaultBackColor;

            }
        }

        private void btnLigar3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("C");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar3.BackColor = Color.LightGreen;
                this.btnDesligar3.BackColor = DefaultBackColor;
                this.btnAllOff.BackColor = DefaultBackColor;

            }
        }

        private void btnDesligar3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("c");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar3.BackColor = DefaultBackColor;
                this.btnDesligar3.BackColor = Color.Red;
                this.btnAllOn.BackColor = DefaultBackColor;

            }
        }

        private void btnLigar4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("D");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar4.BackColor = Color.LightGreen;
                this.btnDesligar4.BackColor = DefaultBackColor;
                this.btnAllOff.BackColor = DefaultBackColor;

            }
        }

        private void btnDesligar4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("d");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar4.BackColor = DefaultBackColor;
                this.btnDesligar4.BackColor = Color.Red;
                this.btnAllOn.BackColor = DefaultBackColor;

            }
        }

        private void btnLigar5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("E");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar5.BackColor = Color.LightGreen;
                this.btnDesligar5.BackColor = DefaultBackColor;
                this.btnAllOff.BackColor = DefaultBackColor;

            }
        }

        private void btnDesligar5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("e");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar5.BackColor = DefaultBackColor;
                this.btnDesligar5.BackColor = Color.Red;
                this.btnAllOn.BackColor = DefaultBackColor;

            }
        }

        private void btnLigar6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("F");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar6.BackColor = Color.LightGreen;
                this.btnDesligar6.BackColor = DefaultBackColor;
                this.btnAllOff.BackColor = DefaultBackColor;

            }
        }

        private void btnDesligar6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("f");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar6.BackColor = DefaultBackColor;
                this.btnDesligar6.BackColor = Color.Red;
                this.btnAllOn.BackColor = DefaultBackColor;

            }
        }

        private void btnLigar7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("G");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar7.BackColor = Color.LightGreen;
                this.btnDesligar7.BackColor = DefaultBackColor;
                this.btnAllOff.BackColor = DefaultBackColor;

            }
        }

        private void btnDesligar7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("g");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar7.BackColor = DefaultBackColor;
                this.btnDesligar7.BackColor = Color.Red;
                this.btnAllOn.BackColor = DefaultBackColor;

            }
        }

        private void btnLigar8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                
                serialPort1.Write("H");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar8.BackColor = Color.LightGreen;
                this.btnDesligar8.BackColor = DefaultBackColor;
                this.btnAllOff.BackColor = DefaultBackColor;

            }
        }

        private void btnDesligar8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("h");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar8.BackColor = DefaultBackColor;
                this.btnDesligar8.BackColor = Color.Red;
                this.btnAllOn.BackColor = DefaultBackColor;

            }
        }

        private void btnAllOn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {

                serialPort1.Write("K");
                serialPort1.Write("\n");
                serialPort1.Write("\r");
                this.btnLigar8.BackColor = Color.LightGreen;
                this.btnDesligar8.BackColor = DefaultBackColor;
                this.btnLigar7.BackColor = Color.LightGreen;
                this.btnDesligar7.BackColor = DefaultBackColor;
                this.btnLigar6.BackColor = Color.LightGreen;
                this.btnDesligar6.BackColor = DefaultBackColor;
                this.btnLigar5.BackColor = Color.LightGreen;
                this.btnDesligar5.BackColor = DefaultBackColor;
                this.btnLigar4.BackColor = Color.LightGreen;
                this.btnDesligar4.BackColor = DefaultBackColor;
                this.btnLigar3.BackColor = Color.LightGreen;
                this.btnDesligar3.BackColor = DefaultBackColor;
                this.btnLigar2.BackColor = Color.LightGreen;
                this.btnDesligar2.BackColor = DefaultBackColor;
                this.btnLigar1.BackColor = Color.LightGreen;
                this.btnDesligar1.BackColor = DefaultBackColor;
                this.btnAllOn.BackColor = Color.LightGreen;
                this.btnAllOff.BackColor = DefaultBackColor;

            }
            else
            {
                this.btnLigar8.BackColor = DefaultBackColor;
                this.btnDesligar8.BackColor = Color.Red;
                this.btnLigar7.BackColor = DefaultBackColor;
                this.btnDesligar7.BackColor = Color.Red;
                this.btnLigar6.BackColor = DefaultBackColor;
                this.btnDesligar6.BackColor = Color.Red;
                this.btnLigar5.BackColor = DefaultBackColor;
                this.btnDesligar5.BackColor = Color.Red;
                this.btnLigar4.BackColor = DefaultBackColor;
                this.btnDesligar4.BackColor = Color.Red;
                this.btnLigar3.BackColor = DefaultBackColor;
                this.btnDesligar3.BackColor = Color.Red;
                this.btnLigar2.BackColor = DefaultBackColor;
                this.btnDesligar2.BackColor = Color.Red;
                this.btnLigar1.BackColor = DefaultBackColor;
                this.btnDesligar1.BackColor = Color.Red;
                this.btnAllOn.BackColor = DefaultBackColor;
                
            }
        }

        private void btnAllOff_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)
            serialPort1.Write("k");
            serialPort1.Write("\n");
            serialPort1.Write("\r");
            this.btnLigar8.BackColor = DefaultBackColor;
            this.btnDesligar8.BackColor = Color.Red;
            this.btnLigar7.BackColor = DefaultBackColor;
            this.btnDesligar7.BackColor = Color.Red;
            this.btnLigar6.BackColor = DefaultBackColor;
            this.btnDesligar6.BackColor = Color.Red;
            this.btnLigar5.BackColor = DefaultBackColor;
            this.btnDesligar5.BackColor = Color.Red;
            this.btnLigar4.BackColor = DefaultBackColor;
            this.btnDesligar4.BackColor = Color.Red;
            this.btnLigar3.BackColor = DefaultBackColor;
            this.btnDesligar3.BackColor = Color.Red;
            this.btnLigar2.BackColor = DefaultBackColor;
            this.btnDesligar2.BackColor = Color.Red;
            this.btnLigar1.BackColor = DefaultBackColor;
            this.btnDesligar1.BackColor = Color.Red;
            this.btnAllOn.BackColor = DefaultBackColor;
            this.btnAllOff.BackColor = Color.Red;
        }
    }
}


