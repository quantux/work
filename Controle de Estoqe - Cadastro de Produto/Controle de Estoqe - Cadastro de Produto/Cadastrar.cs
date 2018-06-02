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

namespace Controle_de_Estoqe___Cadastro_de_Produto
{
    public class Produto
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public double preco { get; set; }
        public double qtd { get; set; }
        public int minReposicao { get; set; }
        public string todayDate;

        public Produto(string codigo, string nome, string categoria, 
                       double preco, double qtd, int minReposicao, string todayDate)
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

    public partial class Cadastrar : Form
    {
        DataGridView dt;
        ArrayList listaProdutos = new ArrayList();

        public Cadastrar(DataGridView dt)
        {
            InitializeComponent();
            this.dt = dt;
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
            double qtd = 0.0;
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
                qtd = double.Parse(Quantidade_box.Text);
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

            foreach (Produto p in listaProdutos)
            {
                if (p.codigo == codigo)
                {
                    MessageBox.Show("Já existe um item com esse código.");
                    return;
                }
            }

            string todayDate = DateTime.Now.ToString("dd/MM/yyyy");

            Produto produto = new Produto(codigo, nome, categoria, preco, qtd, minReposicao, todayDate);

            listaProdutos.Add(produto);
            this.dt.Rows.Add(codigo, nome, categoria, preco, qtd, todayDate);
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
