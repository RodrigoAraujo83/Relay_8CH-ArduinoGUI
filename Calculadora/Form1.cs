using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            // Esse botão é de DIVIDIR

            string dividir = this.screen.Text;
            this.screen.Text = dividir + "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Esse botão é de Vezes

            string vezes = this.screen.Text;
            this.screen.Text = vezes + "X";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            string zero = this.screen.Text;
            this.screen.Text = zero + "0";

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            this.screen.Clear();
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            
            

            
              
        }
    }
}
