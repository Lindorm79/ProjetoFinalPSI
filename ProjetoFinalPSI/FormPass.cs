using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalPSI
{
    public partial class FormPass : Form
    {
        public FormPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtém o texto da TextBox
            string texto = textBox1.Text;

            // Verifica se o texto não está vazio ou nulo e se é igual a "teste"
            if (!string.IsNullOrEmpty(texto) && texto.Trim().ToLower() == "teste")
            {
                MessageBox.Show("Enviamos um e-mail para recuperar a sua senha!", "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Texto inválido. Por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
