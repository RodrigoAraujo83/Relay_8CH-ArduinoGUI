using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Telescope_Motor_UI
{
    public partial class Form1 : Form
    {
        string RxString;
        //string dataReceived;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            radioButtonDefault.Checked = true;
            speedRadio20.Checked = true;
        }
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; // Flag para sinalizar que a quantidade de portas mudou.
            i = 0;
            quantDiferente = false;
            // Se a quantidade de portas mudou:
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
            // Se não for detectado diferença.
            if (quantDiferente == false)
            {
                return;
            }
            // Limpa combo Box.
            comboBox1.Items.Clear();
            // Adiciona todas as COMs disponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            // Seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }
        private void btnConect_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();
                    btnConect.BackgroundImage = Properties.Resources.usboffline;
                }
                catch
                {
                    return;
                }
                if (serialPort1.IsOpen)
                {
                    comboBox1.Enabled = false;
                    btnConect.BackgroundImage = Properties.Resources.usboffline;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btnConect.BackgroundImage = Properties.Resources.usbconnected;
                }
                catch
                {
                    return;
                }
            }



        }

        private void btnHomePosition_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("H");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
                boxHome.BorderStyle = BorderStyle.Fixed3D;
                
            }
            else
            {
                MessageBox.Show("Select Correct Port");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen) // Se houver Porta aberta, Fechar!
            {
                serialPort1.Close();
            }
            Close();
        }
        private void btnMoonFollow_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("M");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
                boxMoon.BorderStyle = BorderStyle.Fixed3D;
                btnRacUp.BackgroundImage = Properties.Resources.arrow_bottom_red;
                btnRacDown.BackgroundImage = Properties.Resources.arrow_up_red;
                btnRacUp.Enabled = false;
                btnRacDown.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Select Correct Port");
            }
        }
        private void btnRacUp_Click(object sender, EventArgs e)
        {

            if ((serialPort1.IsOpen) && (speedRadio20.Checked == true) && (speedRadio30.Checked == false) && (speedRadio40.Checked == false) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("U");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == true) && (speedRadio40.Checked == false) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("I");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == false) && (speedRadio40.Checked == true) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("O");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }
            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == false) && (speedRadio40.Checked == false) && (speedRadio50.Checked == true))
            {

                serialPort1.Write("P");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else
            {
                MessageBox.Show("Select Correct Port");
            }
        }

        private void btnRacDown_Click(object sender, EventArgs e)
        {
            if ((serialPort1.IsOpen) && (speedRadio20.Checked == true) && (speedRadio30.Checked == false) && (speedRadio40.Checked == false) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("u");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == true) && (speedRadio40.Checked == false) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("i");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == false) && (speedRadio40.Checked == true) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("o");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }
            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == false) && (speedRadio40.Checked == false) && (speedRadio50.Checked == true))
            {

                serialPort1.Write("p");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else
            {
                MessageBox.Show("Select Correct Port");
            }


        }

        private void btnDecLeft_Click(object sender, EventArgs e)
        {
            if ((serialPort1.IsOpen) && (speedRadio20.Checked == true) && (speedRadio30.Checked == false) && (speedRadio40.Checked == false) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("z");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == true) && (speedRadio40.Checked == false) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("x");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == false) && (speedRadio40.Checked == true) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("c");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }
            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == false) && (speedRadio40.Checked == false) && (speedRadio50.Checked == true))
            {

                serialPort1.Write("v");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else
            {
                MessageBox.Show("Select Correct Port");
            }
        }

        private void btnDecRight_Click(object sender, EventArgs e)
        {
            if ((serialPort1.IsOpen) && (speedRadio20.Checked == true) && (speedRadio30.Checked == false) && (speedRadio40.Checked == false) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("Z");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == true) && (speedRadio40.Checked == false) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("X");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == false) && (speedRadio40.Checked == true) && (speedRadio50.Checked == false))
            {
                serialPort1.Write("C");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }
            else if ((serialPort1.IsOpen) && (speedRadio20.Checked == false) && (speedRadio30.Checked == false) && (speedRadio40.Checked == false) && (speedRadio50.Checked == true))
            {

                serialPort1.Write("V");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else
            {
                MessageBox.Show("Select Correct Port");
            }
        }

        private void btnFocusPlus_Click(object sender, EventArgs e)
        {
            if((serialPort1.IsOpen) && (radioButtonDefault.Checked == true)&&(radioButton30.Checked == false) && (radioButton60.Checked == false) && (radioButton100.Checked == false))
            {
                serialPort1.Write("J");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (radioButtonDefault.Checked == false) && (radioButton30.Checked == true) && (radioButton60.Checked == false) && (radioButton100.Checked == false))
            {
                serialPort1.Write("N");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (radioButtonDefault.Checked == false) && (radioButton30.Checked == false) && (radioButton60.Checked == true) && (radioButton100.Checked == false))
            {
                serialPort1.Write("K");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }
            else if ((serialPort1.IsOpen) && (radioButtonDefault.Checked == false) && (radioButton30.Checked == false) && (radioButton60.Checked == false) && (radioButton100.Checked == true))
            {

                serialPort1.Write("B");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }
           
            else
            {
                MessageBox.Show("Select Correct Port");
            }
        }
        private void btnFocusLess_Click(object sender, EventArgs e)
        {
            if ((serialPort1.IsOpen) && (radioButtonDefault.Checked == true) && (radioButton30.Checked == false) && (radioButton60.Checked == false) && (radioButton100.Checked == false))
            {
                serialPort1.Write("j");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (radioButtonDefault.Checked == false) && (radioButton30.Checked == true) && (radioButton60.Checked == false) && (radioButton100.Checked == false))
            {
                serialPort1.Write("n");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else if ((serialPort1.IsOpen) && (radioButtonDefault.Checked == false) && (radioButton30.Checked == false) && (radioButton60.Checked == true) && (radioButton100.Checked == false))
            {
                serialPort1.Write("k");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }
            else if ((serialPort1.IsOpen) && (radioButtonDefault.Checked == false) && (radioButton30.Checked == false) && (radioButton60.Checked == false) && (radioButton100.Checked == true))
            {

                serialPort1.Write("b");
                serialPort1.Write("\r");
                serialPort1.Write("\n");
            }

            else
            {
                MessageBox.Show("Select Correct Port");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));//chama outra thread para escrever o dado no text box
        }

        private void trataDadoRecebido(object sender, EventArgs e)
        {
          

        }


    }
}

      

        
        

    




