namespace Controle_de_Estoqe___Cadastro_de_Produto
{
    partial class Cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Categoria_box = new System.Windows.Forms.ComboBox();
            this.Código_box = new System.Windows.Forms.TextBox();
            this.Nome_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecoUni_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantidade_box = new System.Windows.Forms.TextBox();
            this.MinReposi_box = new System.Windows.Forms.TextBox();
            this.CadastrarConfir = new System.Windows.Forms.Button();
            this.modoEdicao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // Categoria_box
            // 
            this.Categoria_box.FormattingEnabled = true;
            this.Categoria_box.Location = new System.Drawing.Point(108, 70);
            this.Categoria_box.Name = "Categoria_box";
            this.Categoria_box.Size = new System.Drawing.Size(121, 21);
            this.Categoria_box.TabIndex = 3;
            // 
            // Código_box
            // 
            this.Código_box.Location = new System.Drawing.Point(108, 18);
            this.Código_box.Name = "Código_box";
            this.Código_box.Size = new System.Drawing.Size(121, 20);
            this.Código_box.TabIndex = 4;
            this.Código_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nome_box
            // 
            this.Nome_box.Location = new System.Drawing.Point(108, 44);
            this.Nome_box.Name = "Nome_box";
            this.Nome_box.Size = new System.Drawing.Size(121, 20);
            this.Nome_box.TabIndex = 4;
            this.Nome_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço unitário";
            // 
            // PrecoUni_box
            // 
            this.PrecoUni_box.Location = new System.Drawing.Point(108, 97);
            this.PrecoUni_box.Name = "PrecoUni_box";
            this.PrecoUni_box.Size = new System.Drawing.Size(121, 20);
            this.PrecoUni_box.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Min Reposição";
            // 
            // Quantidade_box
            // 
            this.Quantidade_box.Location = new System.Drawing.Point(108, 123);
            this.Quantidade_box.Name = "Quantidade_box";
            this.Quantidade_box.Size = new System.Drawing.Size(121, 20);
            this.Quantidade_box.TabIndex = 10;
            // 
            // MinReposi_box
            // 
            this.MinReposi_box.Location = new System.Drawing.Point(108, 149);
            this.MinReposi_box.Name = "MinReposi_box";
            this.MinReposi_box.Size = new System.Drawing.Size(121, 20);
            this.MinReposi_box.TabIndex = 11;
            // 
            // CadastrarConfir
            // 
            this.CadastrarConfir.Location = new System.Drawing.Point(108, 278);
            this.CadastrarConfir.Name = "CadastrarConfir";
            this.CadastrarConfir.Size = new System.Drawing.Size(75, 23);
            this.CadastrarConfir.TabIndex = 0;
            this.CadastrarConfir.Text = ",,,";
            this.CadastrarConfir.UseVisualStyleBackColor = true;
            this.CadastrarConfir.Click += new System.EventHandler(this.CadastrarConfir_Click);
            // 
            // modoEdicao
            // 
            this.modoEdicao.Location = new System.Drawing.Point(108, 175);
            this.modoEdicao.Name = "modoEdicao";
            this.modoEdicao.Size = new System.Drawing.Size(121, 20);
            this.modoEdicao.TabIndex = 12;
            this.modoEdicao.Visible = false;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 313);
            this.Controls.Add(this.modoEdicao);
            this.Controls.Add(this.MinReposi_box);
            this.Controls.Add(this.Quantidade_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrecoUni_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nome_box);
            this.Controls.Add(this.Código_box);
            this.Controls.Add(this.Categoria_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CadastrarConfir);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Categoria_box;
        private System.Windows.Forms.TextBox Código_box;
        private System.Windows.Forms.TextBox Nome_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecoUni_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Quantidade_box;
        private System.Windows.Forms.TextBox MinReposi_box;
        private System.Windows.Forms.Button CadastrarConfir;
        private System.Windows.Forms.TextBox modoEdicao;
    }
}