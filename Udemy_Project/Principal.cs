using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy_Project
{
    public partial class Principal : Form
    {
        private ToolStripMenuItem portaDefault;
        private ToolStripMenuItem velocidadeDafault;
        private SerialPort conectorSerial;
        public Principal()
        {
            this.habilitarControles(false);
            InitializeComponent();

            List<int> baudRates = new List<int>();
            baudRates.Add(4800);
            baudRates.Add(9600);
            baudRates.Add(19200);
            baudRates.Add(38400);
            baudRates.Add(57600);
            baudRates.Add(115200);
            baudRates.Add(115200);
            baudRates.Add(230400);

            for(int i = 0; i < baudRates.Count; i++)
            {
                string baudRate = baudRates[i].ToString();
                ToolStripMenuItem vel = new ToolStripMenuItem(baudRate, null, onClickVelocidade, baudRate);
                itemVelocidade.DropDownItems.Add(vel);
                if(baudRate == "9600")
                {
                    this.velocidadeDafault = vel;
                    vel.Checked = true;
                }
            }

            this.conectorSerial = new SerialPort();
            this.conectorSerial.DataReceived += onDadoRecebido;
            string[] portas = SerialPort.GetPortNames();
            for (int i = 0; i < portas.Length; i++)
            {
                ToolStripMenuItem porta = new ToolStripMenuItem(portas[i], null, onClickPorta, portas[i]); 
                itemAbrirPorta.DropDownItems.Add(porta);
            }

        }

        public delegate void SerialDelegate(string value);

        private void onDadoRecebido(object sender, SerialDataReceivedEventArgs e)
        {
            string dadoRecebido = this.conectorSerial.ReadLine();
            SerialDelegate delegar = new SerialDelegate(this.mostrarDados);
            object[] parametros = new object[1];
            parametros[0] = dadoRecebido;
            this.BeginInvoke(delegar, parametros);
            
        }
        private void mostrarDados(string value)
        {
            this.txtLog.AppendText(value);
        }

        private void onClickPorta(object sender, EventArgs e)
        {
            if (this.portaDefault != null)
            {
                this.portaDefault.Checked = false;
            }
            this.portaDefault = (ToolStripMenuItem)sender;
            this.portaDefault.Checked = true;

            if(this.conectorSerial.IsOpen == false)
            {
                this.conectorSerial.PortName = this.portaDefault.Name;
                this.conectorSerial.BaudRate = int.Parse(this.velocidadeDafault.Name);
                //MessageBox.Show(this.conectorSerial.BaudRate.ToString());
                this.conectorSerial.Open();
                this.Text = "Monito Serial_Udemy - " + this.conectorSerial.PortName; // Titulo ao conectar
            }
        }

        private void onClickVelocidade(object sender, EventArgs e)
        {
            this.velocidadeDafault.Checked = false;
            this.velocidadeDafault = (ToolStripMenuItem)sender;
            this.velocidadeDafault.Checked = true;
        }

        private void itemFecharPorta_Click(object sender, EventArgs e)
        {
            if (conectorSerial.IsOpen)
            {
                conectorSerial.Close();
            }
        }
        private void habilitarControles(bool ativo)
        {
            this.txtEnviar.Enabled = ativo;
            this.btnEnviar.Enabled = ativo;
        }
    }
}
