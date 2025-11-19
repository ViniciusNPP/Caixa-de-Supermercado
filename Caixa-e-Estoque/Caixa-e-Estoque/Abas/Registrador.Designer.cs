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
            label2 = new Label();
            InputValidadeRG = new TextBox();
            LabelValidadeRegistrador = new Label();
            BntRegistrarProduto = new Button();
            InputDescricaoRG = new TextBox();
            InputUmRG = new TextBox();
            InputQuantidadeRG = new TextBox();
            InputPrecoRG = new TextBox();
            InputCodigoRG = new TextBox();
            InputFornecedorRG = new TextBox();
            InputCategoriaRG = new TextBox();
            InputNomeRG = new TextBox();
            LabelDescricaoRegistrador = new Label();
            LabelUMRegistrador = new Label();
            LabelFornecedorRegistrador = new Label();
            LabelQuantidadeRegistrador = new Label();
            LabelPreçoRegistrador = new Label();
            LabelCategoriaRegistrador = new Label();
            LabelNomeRegistrador = new Label();
            LabelCodigoRegistrador = new Label();
            panel2 = new Panel();
            Logo2 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(InputValidadeRG);
            panel1.Controls.Add(LabelValidadeRegistrador);
            panel1.Controls.Add(BntRegistrarProduto);
            panel1.Controls.Add(InputDescricaoRG);
            panel1.Controls.Add(InputUmRG);
            panel1.Controls.Add(InputQuantidadeRG);
            panel1.Controls.Add(InputPrecoRG);
            panel1.Controls.Add(InputCodigoRG);
            panel1.Controls.Add(InputFornecedorRG);
            panel1.Controls.Add(InputCategoriaRG);
            panel1.Controls.Add(InputNomeRG);
            panel1.Controls.Add(LabelDescricaoRegistrador);
            panel1.Controls.Add(LabelUMRegistrador);
            panel1.Controls.Add(LabelFornecedorRegistrador);
            panel1.Controls.Add(LabelQuantidadeRegistrador);
            panel1.Controls.Add(LabelPreçoRegistrador);
            panel1.Controls.Add(LabelCategoriaRegistrador);
            panel1.Controls.Add(LabelNomeRegistrador);
            panel1.Controls.Add(LabelCodigoRegistrador);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 458);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(442, 402);
            label2.Name = "label2";
            label2.Size = new Size(320, 38);
            label2.TabIndex = 27;
            label2.Text = "Todos as células em seus nomes com *  na frente \r\nsão obrigados a serem preenchidas";
            // 
            // InputValidadeRG
            // 
            InputValidadeRG.Location = new Point(633, 214);
            InputValidadeRG.Name = "InputValidadeRG";
            InputValidadeRG.PlaceholderText = "01/02/2025";
            InputValidadeRG.Size = new Size(84, 23);
            InputValidadeRG.TabIndex = 26;
            // 
            // LabelValidadeRegistrador
            // 
            LabelValidadeRegistrador.AutoSize = true;
            LabelValidadeRegistrador.Font = new Font("Segoe UI", 12F);
            LabelValidadeRegistrador.ForeColor = SystemColors.ControlLightLight;
            LabelValidadeRegistrador.Location = new Point(633, 190);
            LabelValidadeRegistrador.Name = "LabelValidadeRegistrador";
            LabelValidadeRegistrador.Size = new Size(69, 21);
            LabelValidadeRegistrador.TabIndex = 25;
            LabelValidadeRegistrador.Text = "Validade";
            // 
            // BntRegistrarProduto
            // 
            BntRegistrarProduto.BackColor = Color.ForestGreen;
            BntRegistrarProduto.FlatStyle = FlatStyle.Popup;
            BntRegistrarProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BntRegistrarProduto.Location = new Point(544, 336);
            BntRegistrarProduto.Name = "BntRegistrarProduto";
            BntRegistrarProduto.Size = new Size(88, 35);
            BntRegistrarProduto.TabIndex = 24;
            BntRegistrarProduto.Text = "Registrar";
            BntRegistrarProduto.UseVisualStyleBackColor = false;
            // 
            // InputDescricaoRG
            // 
            InputDescricaoRG.Location = new Point(13, 310);
            InputDescricaoRG.Multiline = true;
            InputDescricaoRG.Name = "InputDescricaoRG";
            InputDescricaoRG.Size = new Size(341, 130);
            InputDescricaoRG.TabIndex = 23;
            InputDescricaoRG.TextChanged += textBox8_TextChanged;
            // 
            // InputUmRG
            // 
            InputUmRG.Location = new Point(442, 214);
            InputUmRG.Name = "InputUmRG";
            InputUmRG.Size = new Size(145, 23);
            InputUmRG.TabIndex = 22;
            // 
            // InputQuantidadeRG
            // 
            InputQuantidadeRG.Location = new Point(302, 214);
            InputQuantidadeRG.Name = "InputQuantidadeRG";
            InputQuantidadeRG.Size = new Size(91, 23);
            InputQuantidadeRG.TabIndex = 21;
            // 
            // InputPrecoRG
            // 
            InputPrecoRG.Location = new Point(155, 214);
            InputPrecoRG.Name = "InputPrecoRG";
            InputPrecoRG.Size = new Size(84, 23);
            InputPrecoRG.TabIndex = 20;
            // 
            // InputCodigoRG
            // 
            InputCodigoRG.Location = new Point(13, 214);
            InputCodigoRG.Name = "InputCodigoRG";
            InputCodigoRG.Size = new Size(84, 23);
            InputCodigoRG.TabIndex = 19;
            // 
            // InputFornecedorRG
            // 
            InputFornecedorRG.Location = new Point(501, 128);
            InputFornecedorRG.Name = "InputFornecedorRG";
            InputFornecedorRG.Size = new Size(165, 23);
            InputFornecedorRG.TabIndex = 18;
            // 
            // InputCategoriaRG
            // 
            InputCategoriaRG.Location = new Point(250, 128);
            InputCategoriaRG.Name = "InputCategoriaRG";
            InputCategoriaRG.Size = new Size(165, 23);
            InputCategoriaRG.TabIndex = 17;
            // 
            // InputNomeRG
            // 
            InputNomeRG.Location = new Point(13, 128);
            InputNomeRG.Name = "InputNomeRG";
            InputNomeRG.Size = new Size(165, 23);
            InputNomeRG.TabIndex = 16;
            // 
            // LabelDescricaoRegistrador
            // 
            LabelDescricaoRegistrador.AutoSize = true;
            LabelDescricaoRegistrador.Font = new Font("Segoe UI", 12F);
            LabelDescricaoRegistrador.ForeColor = SystemColors.ControlLightLight;
            LabelDescricaoRegistrador.Location = new Point(13, 286);
            LabelDescricaoRegistrador.Name = "LabelDescricaoRegistrador";
            LabelDescricaoRegistrador.Size = new Size(77, 21);
            LabelDescricaoRegistrador.TabIndex = 15;
            LabelDescricaoRegistrador.Text = "Descrição";
            // 
            // LabelUMRegistrador
            // 
            LabelUMRegistrador.AutoSize = true;
            LabelUMRegistrador.Font = new Font("Segoe UI", 12F);
            LabelUMRegistrador.ForeColor = SystemColors.ControlLightLight;
            LabelUMRegistrador.Location = new Point(442, 190);
            LabelUMRegistrador.Name = "LabelUMRegistrador";
            LabelUMRegistrador.Size = new Size(145, 21);
            LabelUMRegistrador.TabIndex = 14;
            LabelUMRegistrador.Text = "Unidade de Medida";
            // 
            // LabelFornecedorRegistrador
            // 
            LabelFornecedorRegistrador.AutoSize = true;
            LabelFornecedorRegistrador.Font = new Font("Segoe UI", 12F);
            LabelFornecedorRegistrador.ForeColor = SystemColors.ControlLightLight;
            LabelFornecedorRegistrador.Location = new Point(501, 104);
            LabelFornecedorRegistrador.Name = "LabelFornecedorRegistrador";
            LabelFornecedorRegistrador.Size = new Size(96, 21);
            LabelFornecedorRegistrador.TabIndex = 13;
            LabelFornecedorRegistrador.Text = "Fornecedor*";
            // 
            // LabelQuantidadeRegistrador
            // 
            LabelQuantidadeRegistrador.AutoSize = true;
            LabelQuantidadeRegistrador.Font = new Font("Segoe UI", 12F);
            LabelQuantidadeRegistrador.ForeColor = SystemColors.ControlLightLight;
            LabelQuantidadeRegistrador.Location = new Point(302, 190);
            LabelQuantidadeRegistrador.Name = "LabelQuantidadeRegistrador";
            LabelQuantidadeRegistrador.Size = new Size(98, 21);
            LabelQuantidadeRegistrador.TabIndex = 12;
            LabelQuantidadeRegistrador.Text = "Quantidade*";
            // 
            // LabelPreçoRegistrador
            // 
            LabelPreçoRegistrador.AutoSize = true;
            LabelPreçoRegistrador.Font = new Font("Segoe UI", 12F);
            LabelPreçoRegistrador.ForeColor = SystemColors.ControlLightLight;
            LabelPreçoRegistrador.Location = new Point(155, 190);
            LabelPreçoRegistrador.Name = "LabelPreçoRegistrador";
            LabelPreçoRegistrador.Size = new Size(56, 21);
            LabelPreçoRegistrador.TabIndex = 11;
            LabelPreçoRegistrador.Text = "Preço*";
            // 
            // LabelCategoriaRegistrador
            // 
            LabelCategoriaRegistrador.AutoSize = true;
            LabelCategoriaRegistrador.Font = new Font("Segoe UI", 12F);
            LabelCategoriaRegistrador.ForeColor = SystemColors.ControlLightLight;
            LabelCategoriaRegistrador.Location = new Point(250, 104);
            LabelCategoriaRegistrador.Name = "LabelCategoriaRegistrador";
            LabelCategoriaRegistrador.Size = new Size(84, 21);
            LabelCategoriaRegistrador.TabIndex = 10;
            LabelCategoriaRegistrador.Text = "Categoria*";
            // 
            // LabelNomeRegistrador
            // 
            LabelNomeRegistrador.AutoSize = true;
            LabelNomeRegistrador.Font = new Font("Segoe UI", 12F);
            LabelNomeRegistrador.ForeColor = SystemColors.ControlLightLight;
            LabelNomeRegistrador.Location = new Point(13, 104);
            LabelNomeRegistrador.Name = "LabelNomeRegistrador";
            LabelNomeRegistrador.Size = new Size(60, 21);
            LabelNomeRegistrador.TabIndex = 9;
            LabelNomeRegistrador.Text = "Nome*";
            // 
            // LabelCodigoRegistrador
            // 
            LabelCodigoRegistrador.AutoSize = true;
            LabelCodigoRegistrador.Font = new Font("Segoe UI", 12F);
            LabelCodigoRegistrador.ForeColor = SystemColors.ControlLightLight;
            LabelCodigoRegistrador.Location = new Point(13, 190);
            LabelCodigoRegistrador.Name = "LabelCodigoRegistrador";
            LabelCodigoRegistrador.Size = new Size(67, 21);
            LabelCodigoRegistrador.TabIndex = 8;
            LabelCodigoRegistrador.Text = "Código*";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(Logo2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 62);
            panel2.TabIndex = 6;
            // 
            // Logo2
            // 
            Logo2.Image = Properties.Resources.Carrinho_de_Compra;
            Logo2.Location = new Point(261, -3);
            Logo2.Name = "Logo2";
            Logo2.Size = new Size(62, 65);
            Logo2.TabIndex = 7;
            Logo2.TabStop = false;
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
            // Registrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Registrador";
            Text = "Registrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LabelCategoriaRegistrador;
        private Label LabelNomeRegistrador;
        private Label LabelCodigoRegistrador;
        private Label LabelDescricaoRegistrador;
        private Label LabelUMRegistrador;
        private Label LabelFornecedorRegistrador;
        private Label LabelQuantidadeRegistrador;
        private Label LabelPreçoRegistrador;
        private TextBox InputDescricaoRG;
        private TextBox InputUmRG;
        private TextBox InputQuantidadeRG;
        private TextBox InputPrecoRG;
        private TextBox InputCodigoRG;
        private TextBox InputFornecedorRG;
        private TextBox InputCategoriaRG;
        private TextBox InputNomeRG;
        private Label label1;
        private Button BntRegistrarProduto;
        private PictureBox Logo2;
        private TextBox InputValidadeRG;
        private Label LabelValidadeRegistrador;
        private Label label2;
    }
}