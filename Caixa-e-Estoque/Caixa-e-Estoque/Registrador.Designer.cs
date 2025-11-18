namespace Caixa_e_Estoque
{
    partial class Registrador
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
            panel1 = new Panel();
            DescricaoInput = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Descricao = new Label();
            UnidadeDeMedida = new Label();
            Fornecedor = new Label();
            Quantidade = new Label();
            Preço = new Label();
            Categoria = new Label();
            Nome = new Label();
            Código = new Label();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(DescricaoInput);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Descricao);
            panel1.Controls.Add(UnidadeDeMedida);
            panel1.Controls.Add(Fornecedor);
            panel1.Controls.Add(Quantidade);
            panel1.Controls.Add(Preço);
            panel1.Controls.Add(Categoria);
            panel1.Controls.Add(Nome);
            panel1.Controls.Add(Código);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 458);
            panel1.TabIndex = 0;
            // 
            // DescricaoInput
            // 
            DescricaoInput.Location = new Point(13, 310);
            DescricaoInput.Multiline = true;
            DescricaoInput.Name = "DescricaoInput";
            DescricaoInput.Size = new Size(341, 130);
            DescricaoInput.TabIndex = 23;
            DescricaoInput.TextChanged += textBox8_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(442, 214);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(145, 23);
            textBox7.TabIndex = 22;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(302, 214);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(91, 23);
            textBox6.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(84, 23);
            textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(84, 23);
            textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(501, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 16;
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Font = new Font("Segoe UI", 12F);
            Descricao.ForeColor = SystemColors.ControlLightLight;
            Descricao.Location = new Point(13, 286);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(77, 21);
            Descricao.TabIndex = 15;
            Descricao.Text = "Descrição";
            // 
            // UnidadeDeMedida
            // 
            UnidadeDeMedida.AutoSize = true;
            UnidadeDeMedida.Font = new Font("Segoe UI", 12F);
            UnidadeDeMedida.ForeColor = SystemColors.ControlLightLight;
            UnidadeDeMedida.Location = new Point(442, 190);
            UnidadeDeMedida.Name = "UnidadeDeMedida";
            UnidadeDeMedida.Size = new Size(145, 21);
            UnidadeDeMedida.TabIndex = 14;
            UnidadeDeMedida.Text = "Unidade de Medida";
            // 
            // Fornecedor
            // 
            Fornecedor.AutoSize = true;
            Fornecedor.Font = new Font("Segoe UI", 12F);
            Fornecedor.ForeColor = SystemColors.ControlLightLight;
            Fornecedor.Location = new Point(501, 104);
            Fornecedor.Name = "Fornecedor";
            Fornecedor.Size = new Size(89, 21);
            Fornecedor.TabIndex = 13;
            Fornecedor.Text = "Fornecedor";
            // 
            // Quantidade
            // 
            Quantidade.AutoSize = true;
            Quantidade.Font = new Font("Segoe UI", 12F);
            Quantidade.ForeColor = SystemColors.ControlLightLight;
            Quantidade.Location = new Point(302, 190);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(91, 21);
            Quantidade.TabIndex = 12;
            Quantidade.Text = "Quantidade";
            // 
            // Preço
            // 
            Preço.AutoSize = true;
            Preço.Font = new Font("Segoe UI", 12F);
            Preço.ForeColor = SystemColors.ControlLightLight;
            Preço.Location = new Point(155, 190);
            Preço.Name = "Preço";
            Preço.Size = new Size(49, 21);
            Preço.TabIndex = 11;
            Preço.Text = "Preço";
            // 
            // Categoria
            // 
            Categoria.AutoSize = true;
            Categoria.Font = new Font("Segoe UI", 12F);
            Categoria.ForeColor = SystemColors.ControlLightLight;
            Categoria.Location = new Point(250, 104);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(77, 21);
            Categoria.TabIndex = 10;
            Categoria.Text = "Categoria";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Segoe UI", 12F);
            Nome.ForeColor = SystemColors.ControlLightLight;
            Nome.Location = new Point(13, 104);
            Nome.Name = "Nome";
            Nome.Size = new Size(53, 21);
            Nome.TabIndex = 9;
            Nome.Text = "Nome";
            // 
            // Código
            // 
            Código.AutoSize = true;
            Código.Font = new Font("Segoe UI", 12F);
            Código.ForeColor = SystemColors.ControlLightLight;
            Código.Location = new Point(13, 190);
            Código.Name = "Código";
            Código.Size = new Size(60, 21);
            Código.TabIndex = 8;
            Código.Text = "Código";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 62);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(330, 8);
            label1.Name = "label1";
            label1.Size = new Size(148, 33);
            label1.TabIndex = 6;
            label1.Text = "Registrador";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(442, 358);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 24;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Registrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Registrador";
            Text = "Registrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Categoria;
        private Label Nome;
        private Label Código;
        private Label Descricao;
        private Label UnidadeDeMedida;
        private Label Fornecedor;
        private Label Quantidade;
        private Label Preço;
        private TextBox DescricaoInput;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}