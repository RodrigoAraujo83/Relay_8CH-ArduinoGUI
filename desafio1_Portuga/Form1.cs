using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio1_Portuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_conectar.Enabled = false; // Inicia com o botão inativo
        }

        private void text_textChanged(object sender, EventArgs e)
        {
            // Ativa o botão, somente havendo textos nos campos senha e usuario
            btn_conectar.Enabled = text_usuario.Text != "" && text_senha.Text != "" ? true : false;

        }

        private void text_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                text_senha.Focus();
                e.Handled = true; 
                e.SuppressKeyPress = true;  // Elimina o som de advertencia
            }
        }

        private void text_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_conectar_Click(this, EventArgs.Empty); // Ao precionar Enter no campo senha, o foco saltará para o botão.
                e.Handled = true;
                e.SuppressKeyPress = true;  // Elimina o som de advertencia
            }
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (!btn_conectar.Enabled) return;      // Só permite executar a mensagem,
            MessageBox.Show("Cadastro Realizado!"); //se o botão estiver ativo(com os campos preenchidos)
        }
    }
}
