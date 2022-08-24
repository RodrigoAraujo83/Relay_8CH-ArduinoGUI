using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio5_Portuga
{
    public partial class Form1 : Form
    {
        int minimo = 0;
        int maximo = 100;
        int numero = 0;
        int tentativas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textNumero.Enabled = false;
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numero = rnd.Next(minimo, maximo);

            label1.Text = "Jogo iniciado!" + Environment.NewLine + "Adivinhe o numero entre" + Environment.NewLine +
                string.Format("{0} e {1}", minimo, maximo);
            textNumero.Enabled = true;
            textNumero.Text = "";
            textNumero.Focus();
            btn_Iniciar.Enabled = false;    
                   
        }

        private void textNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Enter) && (textNumero.Text != ""))
            {
                e.SuppressKeyPress = true;
                int.TryParse(textNumero.Text, out int valorInformado);
                if(valorInformado < numero)
                {
                    label1.Text = "O número é maior!";
                    tentativas++;
                }
                else if(valorInformado > numero)
                {
                    label1.Text = "O número é menor!";
                    tentativas++;
                }
                else
                {
                    label1.Text = "Valor Correto!" + Environment.NewLine + "Você Acertou!" 
                        + Environment.NewLine + "O numero de tentaivas foi de : " + tentativas;
                    textNumero.Enabled=false;   
                    btn_Iniciar.Enabled = true;
                    tentativas = 0;
                }
                
            }
        }


    }
}
