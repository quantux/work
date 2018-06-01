using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoqe___Cadastro_de_Produto
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarConfir_Click(object sender, EventArgs e)
        {

        }
        public void atualiza() // altera o nome da tecla
        {
            if (BackColor == Color.FromArgb(180, 180, 180))
            {
                this.CadastrarConfir.Text = "Alterar";
            }
            if (BackColor == Color.FromArgb(169, 169, 169))
            {
                CadastrarConfir.Text = "Cadastrar";
            }
        }

    }
}
