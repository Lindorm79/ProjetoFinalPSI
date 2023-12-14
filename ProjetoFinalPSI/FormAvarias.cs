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
    public partial class FormAvarias : Form
    {
        public FormAvarias()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
            checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se todas as TextBoxes e RichTextBox estão preenchidas
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos para continuar...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Exibe uma mensagem indicando que a avaria foi registrada
            MessageBox.Show("Avaria registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpa os campos do formulário
            LimparCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
