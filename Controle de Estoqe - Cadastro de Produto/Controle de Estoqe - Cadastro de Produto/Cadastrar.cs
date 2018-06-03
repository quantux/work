using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Controle_de_Estoqe___Cadastro_de_Produto
{
    public partial class Cadastrar : Form
    {
        DataGridView dt;
        public static Produtos arrayProdutos = new Produtos();
        public static ArrayList listaProdutos = new ArrayList();

        public Cadastrar(DataGridView dt)
        {
            InitializeComponent();
            this.dt = dt;
            modoEdicao.Text = "cadastrar";
        }

        public Cadastrar(DataGridView dt, Produto p)
        {
            InitializeComponent();
            this.dt = dt;

            Código_box.Text = p.codigo;
            Nome_box.Text = p.nome;
            Categoria_box.Text = p.categoria;
            PrecoUni_box.Text = p.preco.ToString();
            Quantidade_box.Text = p.qtd.ToString();
            MinReposi_box.Text = p.minReposicao.ToString();
            modoEdicao.Text = "atualizar";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarConfir_Click(object sender, EventArgs e)
        {
            string codigo = "";
            string nome = "";
            string categoria = "";
            double preco = 0.0;
            int qtd = 0;
            int minReposicao = 0;

            try
            {
                codigo = Código_box.Text;
            }
            catch
            {
                MessageBox.Show("O código está incorreto.");
                return;
            }

            try
            {
                nome = Nome_box.Text;
            }
            catch
            {
                MessageBox.Show("O nome está incorreto.");
                return;
            }

            try
            {
                categoria = Categoria_box.Text;
            }
            catch
            {
                MessageBox.Show("A categoria está incorreta.");
                return;
            }

            try
            {
                preco = double.Parse(PrecoUni_box.Text);
            }
            catch
            {
                MessageBox.Show("O preço está incorreto.");
                return;
            }

            try
            {
                qtd = int.Parse(Quantidade_box.Text);
            }
            catch
            {
                MessageBox.Show("A quantidade está incorreta.");
                return;
            }

            try
            {
                minReposicao = int.Parse(MinReposi_box.Text);
            }
            catch
            {
                MessageBox.Show("O mínimo para reposição está incorreto.");
                return;
            }

            string todayDate = DateTime.Now.ToString("dd/MM/yyyy");

            if (modoEdicao.Text == "cadastrar")
            {

                foreach (Produto p in listaProdutos)
                {
                    if (p.codigo == codigo)
                    {
                        MessageBox.Show("Já existe um item com esse código.");
                        return;
                    }
                }

                Produto produto = new Produto(codigo, nome, categoria, preco, qtd, minReposicao, todayDate);
                listaProdutos.Add(produto);
                this.dt.Rows.Add(codigo, nome, categoria, preco, qtd, todayDate);
            }
            else
            {
                foreach (Produto produto in listaProdutos)
                {
                    if (produto.codigo == codigo)
                    {
                        // atualiza os dados do produto no ArrayList
                        produto.nome = nome;
                        produto.categoria = categoria;
                        produto.preco = preco;
                        produto.qtd = qtd;
                        produto.todayDate = todayDate;

                        // atualiza os dados do Grid
                        foreach (DataGridViewRow row in this.dt.SelectedRows)
                        {
                            string codigo_row = row.Cells[0].Value.ToString();

                            if (codigo_row == codigo)
                            {
                                row.Cells[1].Value = nome;
                                row.Cells[2].Value = categoria;
                                row.Cells[3].Value = preco;
                                row.Cells[4].Value = qtd;
                                row.Cells[5].Value = todayDate;
                            }
                        }

                        this.Close();
                        return;
                    }
                }
            }

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

    [Serializable]
    [XmlType(TypeName = "Produto")]
    public class Produto
    {
        [System.Xml.Serialization.XmlElementAttribute("codigo")]
        public string codigo { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("nome")]
        public string nome { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("categoria")]
        public string categoria { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("preco")]
        public double preco { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("qtd")]
        public int qtd { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("minReposicao")]
        public int minReposicao { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("todayDate")]
        public string todayDate { get; set; }
        
        public Produto(){}

        public Produto(string codigo, string nome, string categoria,
                       double preco, int qtd, int minReposicao, string todayDate)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.categoria = categoria;
            this.preco = preco;
            this.qtd = qtd;
            this.minReposicao = minReposicao;
            this.todayDate = todayDate;
        }
    }

    public class Produtos
    {
        [XmlArrayItem(typeof(Produto))]
        public Produto[] Produto { get; set; }
    }
}
