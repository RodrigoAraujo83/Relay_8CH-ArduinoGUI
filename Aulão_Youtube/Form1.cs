using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Aulão_Youtube
{
    public partial class Form1 : Form
    {
        string recDados;
        public Form1() 
        {
            InitializeComponent();
            btnLedOff.BackColor = Color.Gray;
            btnLedOn.BackColor = Color.Gray;
            serialPort1.Open();
            valorSlider.Text = "0";
            lblBT.Text = "OFF";
            lblBT.BackColor = Color.LimeGreen;
            progressBar1.Value = 0;
            valorPot.Text = "0";
            recDados = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            serialPort1.Write("POT");
            serialPort1.Write("\r");
            serialPort1.Write("D");
            serialPort1.Write("\r");
            progressBar1.Value = 0;
            valorPot.Text = "0";
            serialPort1.Close();
            recDados = "";
            Close();
        }

        private void btnLedOn_Click(object sender, EventArgs e)
        {
            serialPort1.Write("L");
            serialPort1.Write("\r");
            serialPort1.Write("\n");
            btnLedOn.BackColor = Color.Red;
            btnLedOff.BackColor = Color.Gray;
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
            serialPort1.Write("\r");
            serialPort1.Write("\n");
            btnLedOff.BackColor = Color.Green;
            btnLedOn.BackColor = Color.Gray;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int slider = hScrollBar1.Value;
            string sliderStr = slider.ToString();
            serialPort1.Write("P" + sliderStr);
            serialPort1.Write("\r");
            serialPort1.Write("\n");
            valorSlider.Text = sliderStr;
            Thread.Sleep(10); // Um atraso em milisegundos para o arduino ler na Serial
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            recDados = serialPort1.ReadTo("\n");
            // Quando algum dado for recebido na serial, será invocado um novo objeto, nesse caso
            // um evento que chama uma função para tratar os dados.
            this.Invoke(new EventHandler(tratarDadosRecebidos));
        }

        private void tratarDadosRecebidos(object sender, EventArgs e)
        {
            if(recDados == "ON")
            {
                lblBT.Text = "ON";
                lblBT.BackColor = Color.Red;
                recDados = "";
            }
            if (recDados == "OFF")
            {
                lblBT.Text = "OFF";
                lblBT.BackColor = Color.LimeGreen;
                recDados = "";
            }
            if (recDados.Contains("P"))
            {
                char[] removeChar = { 'P' };
                valorPot.Text = recDados.Trim(removeChar);
                progressBar1.Value = Int32.Parse(valorPot.Text);
                recDados = "";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
