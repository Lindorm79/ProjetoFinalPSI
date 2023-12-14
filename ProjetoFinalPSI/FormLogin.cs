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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public class Credenciais
        {
            //atribuição de valores hardcoded
            public string User = "teste";
            public string Pass = "cisco";
            public string Nome = "Ireneu";
        }

        void autenticacao()
        {
            Credenciais Acesso = new Credenciais();

            if (textBox1.Text == Acesso.User && textBox2.Text == Acesso.Pass)
            {
                // Configurar o texto do botão no formulário MDIParent
                MDIParent mdiForm = Application.OpenForms.OfType<MDIParent>().FirstOrDefault();
                mdiForm.ConfigureBemVindoLabel(Acesso.User);

                // Configurar a visibilidade da menuStrip1
                mdiForm.menuStrip.Visible = true;
                mdiForm.label3.Visible = true;
                // Esconde o formulário de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dados incorretos.", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autenticacao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPass f = new FormPass();
            f.ShowDialog();
        }
    }
}
