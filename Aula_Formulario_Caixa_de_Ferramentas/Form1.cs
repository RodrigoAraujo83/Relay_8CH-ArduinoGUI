using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_Formulario_Caixa_de_Ferramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = this.textBox1.Text;
            string tipo = this.textBox2.Text;

            if ((nome == "") && (tipo == ""))
            {
                MessageBox.Show("Favor Inserir um valor nos campos!");
            }
            else
            {
                
                MessageBox.Show($"Sensor {nome} Cadastrado com Sucesso!");
            }
            
                this.textBox1.Clear();
                this.textBox2.Clear();
            
           
        }

         private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string valor = this.textBox3.Text;

            progressBar1.Value = valor.Length;

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.textBox3.Clear();
        }
    }
}
