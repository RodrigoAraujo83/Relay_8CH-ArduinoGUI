using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio3_Portuga
{
    public partial class Form1 : Form
    {
        int num_senhas = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            if(checkMaiuscula.Checked)
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (checkAlgarismo.Checked)
                chars += "0123456789";
            if (checkSimbolo.Checked)
                chars += "#@$%*&!?/+=";

            listaSenhas.Items.Clear();
            Random rnd = new Random(); // Cria um range aleatório

            for(int n = 0; n <= num_senhas; n++)
            {
                StringBuilder str = new StringBuilder(); // Cria uma string vazia
                for(int i = 0; i < count.Value; i++)
                {
                    int pos = rnd.Next(0, chars.Length); // define a posição dos caracteres de 0 ao tamanho de chars
                    str.Append(chars[pos].ToString()); // Adiciona caracteres na string vazia, criando a senha 
                }
                listaSenhas.Items.Add(str.ToString()); // Adiciona na lista, a string criada 
            }
        }
    }
}
