using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjetoFinalPSI
{
    public partial class FormProdutos : Form
    {
        private double saldo = 1500; // Saldo inicial
        private Dictionary<string, double> precos = new Dictionary<string, double>
       {
           { "Windows 11 Pro   Preço: 640.50€  Código: W11P", 640.50 },
           { "Windows 10 Pro   Preço: 159.00€  Código: W10P", 159.00 },
           { "Linux Ubuntu   Preço: 0.00€  Código: LNU", 0.00 },
           { "Office 2022   Preço: 299.99€ Código: OFF22", 299.99 },
           { "Visual Studio 2022 Enterprise   Preço: 799.99€  Código: VS22E", 799.99 },
           { "Monitor Dell 27 4K   Preço: 699.00€  Código: MD27K", 699.00  },
           { "Impressora HP LaserJet Pro   Preço: 249.99€  Código: HPLJ", 249.99 },
           { "Teclado Mecânico Asus ROG Strix Scope TKL    Preço: 84,90€  Código: KBA_ROG ", 84.90 },
           { "Rato Logitech G Pro   Preço: 99.99€  Código: RAT_LOG", 99.99 }
       };
        public FormProdutos()
        {
            InitializeComponent();
            comboBox1.Items.Add("Software");
            comboBox1.Items.Add("Hardware");
        }

        private void Saldo()
        {
            label6.Text = "Saldo: " + saldo + " €";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "Software")
            {
                listBox1.Items.Add("Windows 11 Pro   Preço: 640.50€  Código: W11P");
                listBox1.Items.Add("Windows 10 Pro   Preço: 159.00€  Código: W10P");
                listBox1.Items.Add("Linux Ubuntu   Preço: 0.00€  Código: LNU");
                listBox1.Items.Add("Office 2022   Preço: 299.99€  Código: OFF22");
                listBox1.Items.Add("Visual Studio 2022 Enterprise   Preço: 799.99€  Código: VS22E");
            }
            else if (comboBox1.SelectedItem.ToString() == "Hardware")
            {
                listBox1.Items.Add("Monitor Dell 27 4K   Preço: 699.00€  Código: MD27K");
                listBox1.Items.Add("Impressora HP LaserJet Pro   Preço: 249.99€  Código: HPLJ");
                listBox1.Items.Add("Teclado Mecânico Asus ROG Strix Scope TKL    Preço: 84,90€  Código: KBA_ROG ");
                listBox1.Items.Add("Rato Logitech G Pro   Preço: 99.99€  Código: RAT_LOG\"");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string produtoSelecionado = listBox1.SelectedItem?.ToString();

            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto da lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obter detalhes do produto
            string codigo = textBox1.Text;
            string nome = textBox2.Text;

            // Verificar se o código e a designação correspondem ao produto selecionado
            if (!produtoSelecionado.Contains(codigo) || !produtoSelecionado.Contains(nome))
            {
                MessageBox.Show("O produto selecionado não corresponde aos dados inseridos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obter o preço do produto
            double preco = precos.ContainsKey(produtoSelecionado) ?
                           precos[produtoSelecionado]:
                           precos[produtoSelecionado];

            // Verificar se há saldo suficiente
            if (preco > saldo)
            {
                MessageBox.Show("Saldo insuficiente para comprar este produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Descontar o preço do saldo
            saldo -= preco;

            // Atualizar o saldo exibido
            label6.Text = $"Saldo: {saldo:C}";

            // Mensagem de sucesso
            MessageBox.Show("Compra realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("É preciso preencher todos os campos para concluir a transação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Compra cancelada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
