using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

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

            // decrementa a quantidade do(s) produto(s)
            foreach (DataGridViewRow row in this.gridView.SelectedRows)
            {
                string codigo = row.Cells[0].Value.ToString();
                int qtd = int.Parse(row.Cells[4].Value.ToString());
                string nome = "";

                int minimoReposicao = 0;

                foreach (Produto p in Cadastrar.listaProdutos)
                {
                    if (p.codigo == codigo)
                    {
                        minimoReposicao = p.minReposicao;
                        nome = p.nome;
                        p.qtd--;
                    }
                }

                qtd--;
                row.Cells[4].Value = qtd;

                if (qtd <= minimoReposicao)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    MessageBox.Show("O estoque de " + nome + " está acabando!");
                    this.gridView.ClearSelection();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string codigo = Código_box.Text;
            string nome = Nome_box.Text;
            string categoria = Categoria_box.Text;
            string preco = PrecoUni_box.Text;
            string qtd = Quantidade_box.Text;

            if (codigo == "" && nome == "" && categoria == "" && preco == "" && qtd == "")
            {
                MessageBox.Show("Por favor, forneça os dados necessários para a pesquisa.");
                return;
            }

            label_Ret_add.Text = "Operação - Pesquisar produto";

            if (button3.Text != "Voltar à tabela")
            {
                ArrayList listaPesquisa = new ArrayList();

                foreach (Produto p in Cadastrar.listaProdutos)
                {
                    if (p.codigo == codigo || p.nome == nome || p.categoria == categoria
                        || p.preco.ToString() == preco || p.qtd.ToString() == qtd)
                    {
                        listaPesquisa.Add(p);
                    }
                }

                if (listaPesquisa.Count != 0)
                {
                    gridView.Rows.Clear();
                    foreach (Produto p in listaPesquisa)
                    {
                        gridView.Rows.Add(p.codigo, p.nome, p.categoria, p.preco, p.qtd, p.todayDate);
                    }

                    button3.Text = "Voltar à tabela";
                }
                else
                {
                    MessageBox.Show("Sua pesquisa não retornou resultados.");
                }
            }
            else
            {
                button3.Text = "Pesquisar produto";
                gridView.Rows.Clear();

                foreach (Produto p in Cadastrar.listaProdutos)
                {
                    gridView.Rows.Add(p.codigo, p.nome, p.categoria, p.preco, p.qtd, p.todayDate);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_Ret_add.Text = "Operação - Adicionar produto";

            // incrementa a quantidade do(s) produto(s)
            foreach (DataGridViewRow row in this.gridView.SelectedRows)
            {
                string codigo = row.Cells[0].Value.ToString();
                int qtd = int.Parse(row.Cells[4].Value.ToString());

                int minimoReposicao = 0;

                // pega o valor mínimo de reposição
                foreach (Produto p in Cadastrar.listaProdutos)
                {
                    if (p.codigo == codigo)
                    {
                        minimoReposicao = p.minReposicao;
                        p.qtd++;
                    }
                }

                qtd++;
                row.Cells[4].Value = qtd;

                if (qtd > minimoReposicao)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
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
            Cadastrar cadastrar = new Cadastrar(this.gridView);
            cadastrar.BackColor = Color.FromArgb(169, 169, 169);
            cadastrar.atualiza();
            cadastrar.ShowDialog();
        }
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar(this.gridView);
            cadastrar.BackColor = Color.FromArgb(180, 180, 180);
            cadastrar.atualiza();
            cadastrar.ShowDialog();
        }
        private void cadastrar_produto_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar(this.gridView);
            cadastrar.BackColor = Color.FromArgb(169, 169, 169);
            cadastrar.atualiza();
            cadastrar.ShowDialog();
        }
        // Alterar cadastro - abre o mesmo menu mas deve abrir já com os dados
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Você deve selecionar um item.");
                return;
            }

            if (this.gridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione somente um item.");
                return;
            }

            string codigo = this.gridView.SelectedRows[0].Cells[0].Value.ToString();

            foreach (Produto produto in Cadastrar.listaProdutos)
            {
                if (produto.codigo == codigo)
                {
                    string nome = produto.nome;
                    string categoria = produto.categoria;
                    double preco = produto.preco;
                    int qtd = produto.qtd;
                    int minReposicao = produto.minReposicao;
                    string todayDate = produto.todayDate;

                    Produto p = new Produto(codigo, nome, categoria, preco, qtd, minReposicao, todayDate);

                    Cadastrar cadastrar = new Cadastrar(this.gridView, p);
                    cadastrar.BackColor = Color.FromArgb(180, 180, 180);
                    cadastrar.atualiza();
                    cadastrar.ShowDialog();

                    return;
                }
            }
        }
        private void label_Ret_add_Click(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Código_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GravaXML("Estoque.xml");
            MessageBox.Show("Lista de produtos salva com sucesso!");
        }

        public void GravaXML(string filename)
        {
            // Cria um array de produtos temporário para serializar
            Produto[] produtos = new Produto[ Cadastrar.listaProdutos.Count ];

            int iterator_num = 0;
            foreach (Produto p in Cadastrar.listaProdutos)
            {
                produtos[iterator_num] = p;
                iterator_num++;
            }

            // Serializa o Array de Produtos
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Produto[]));
                XML.Serialize(stream, produtos);
            }
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Deserializa o Array de Produtos
            FileStream stream = new FileStream("Estoque.xml", FileMode.Open);
            XmlReader reader = new XmlTextReader(stream);
            XmlSerializer deserializer = new XmlSerializer(typeof(Produto[]));
            Produto[] produtos = (Produto[])deserializer.Deserialize(reader);

            Cadastrar.listaProdutos.Clear();

            foreach (Produto p in produtos)
            {
                Cadastrar.listaProdutos.Add(p);
            }

            gridView.Rows.Clear();

            // Adiciona os produtos no Grid
            foreach (Produto p in Cadastrar.listaProdutos)
            {
                gridView.Rows.Add(p.codigo, p.nome, p.categoria, p.preco, p.qtd, p.todayDate);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
