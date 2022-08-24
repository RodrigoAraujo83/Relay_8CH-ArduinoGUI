using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio2_Portuga
{
    public partial class Form1 : Form
    {
        double valor1;
        double valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado.Text = "";
        }

        private void operacao_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(text1.Text); // Adicionando o valor do texto convertido para double, às variaveis
            valor2 = Double.Parse(text2.Text);
            string tipoOperacao = (sender as Button).Text; // Ao clicar, o texto do botão sera adicionado à variavel tipoOperacao
            resultado.Text = String.Format("{0} {1} {2} = {3}", valor1.ToString(), tipoOperacao, valor2.ToString(), operacao(tipoOperacao));
        }

        private string operacao(string tipo)
        {
            double resultado = 0;
            switch (tipo)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    break;
                case ":":
                    resultado = valor1 / valor2;
                    break;

            }


            return resultado.ToString();
        }
    }
}
