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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // butons menu tela
        private void button1_Click(object sender, EventArgs e)
        {
            label_Ret_add.Text = "Operação - Retirar produto";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label_Ret_add.Text = "Operação - Pesquisar produto";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label_Ret_add.Text = "Operação - Adicionar produto";
        }
        // Butons do menu
        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_Ret_add.Text = "Operação - Adicionar produto";
        }
        private void retirarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_Ret_add.Text = "Operação - Retirar produto";
        }
        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_Ret_add.Text = "Operação - Pesquisar produto";
        }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.BackColor = Color.FromArgb(169, 169, 169);
            cadastrar.atualiza();
            cadastrar.ShowDialog();
        }
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.BackColor = Color.FromArgb(180, 180, 180);
            cadastrar.atualiza();
            cadastrar.ShowDialog();
        }
        private void cadastrar_produto_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.BackColor = Color.FromArgb(169, 169, 169);
            cadastrar.atualiza();
            cadastrar.ShowDialog();
        }
        // Alterar cadastro - abre o mesmo menu mas deve abrir já com os dados
        private void button4_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.BackColor = Color.FromArgb(180, 180, 180);
            cadastrar.atualiza();
            cadastrar.ShowDialog();
            
        }
        private void label_Ret_add_Click(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    
    }
}
