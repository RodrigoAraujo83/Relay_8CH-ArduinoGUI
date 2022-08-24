using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio4_Portuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void text_letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se há apenas letras no text box e impede caracteres numéricos
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void text_numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se há apenas números no text box e impede caracteres letras
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
