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

namespace Serial_Exercicio
{
    public partial class Form1 : Form
    {
        string RxString;
        public Form1()
        {
            InitializeComponent();
            timerCom.Enabled = true;
        }
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; // Para sinalizar que a porta mudou.
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
            // Se não foi detectado diferença.
            if(quantDiferente == false)
            {
                return;
            }
            // Limpa ComboBox
            comboBox1.Items.Clear();
            // Adiciona todas as COMs disponíveis na lista
            foreach(string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            // Adiciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void timerCom_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == false)
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
                if(serialPort1.IsOpen == true)
                {
                    btnConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btnConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true) // Se houver porta aberta, Fechar!
            {
                serialPort1.Close();
            }
            Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)               // Se a Porta de comunicação estiver aberta, 
                                                    
            {
                serialPort1.Write(textBoxEnviar.Text);  // eviar o que houver noTextBox
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();            // Lê o dado disponível na Porta serial
            this.Invoke(new EventHandler(trataDadoRecebido)); // Chama outra thread para escrever o dado no  text box
        }
        private void trataDadoRecebido(object sender, EventArgs e)
        {
            textBoxReceber.AppendText(RxString);
        }
    }
    

}
