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
            TextoInput = new TextBox();
            label2 = new Label();
            InputVldRg = new TextBox();
            LabelVldRg = new Label();
            BntRegistrarProduto = new Button();
            InputDscRg = new TextBox();
            InputUmRg = new TextBox();
            InputQtdRg = new TextBox();
            InputPrecoRg = new TextBox();
            InputCodigoRg = new TextBox();
            InputFncdRg = new TextBox();
            InputCtgRg = new TextBox();
            InputNomeRg = new TextBox();
            LabelDscRg = new Label();
            LabelUmRg = new Label();
            LabelFncdRg = new Label();
            LabelQtdRg = new Label();
            LabelPreçoRg = new Label();
            LabelCtgRg = new Label();
            LabelNomeRg = new Label();
            LabelCodigoRg = new Label();
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
            panel1.Controls.Add(TextoInput);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(InputVldRg);
            panel1.Controls.Add(LabelVldRg);
            panel1.Controls.Add(BntRegistrarProduto);
            panel1.Controls.Add(InputDscRg);
            panel1.Controls.Add(InputUmRg);
            panel1.Controls.Add(InputQtdRg);
            panel1.Controls.Add(InputPrecoRg);
            panel1.Controls.Add(InputCodigoRg);
            panel1.Controls.Add(InputFncdRg);
            panel1.Controls.Add(InputCtgRg);
            panel1.Controls.Add(InputNomeRg);
            panel1.Controls.Add(LabelDscRg);
            panel1.Controls.Add(LabelUmRg);
            panel1.Controls.Add(LabelFncdRg);
            panel1.Controls.Add(LabelQtdRg);
            panel1.Controls.Add(LabelPreçoRg);
            panel1.Controls.Add(LabelCtgRg);
            panel1.Controls.Add(LabelNomeRg);
            panel1.Controls.Add(LabelCodigoRg);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 458);
            panel1.TabIndex = 0;
            // 
            // TextoInput
            // 
            TextoInput.Location = new Point(421, 377);
            TextoInput.Multiline = true;
            TextoInput.Name = "TextoInput";
            TextoInput.Size = new Size(341, 72);
            TextoInput.TabIndex = 28;
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
            // InputVldRg
            // 
            InputVldRg.Location = new Point(633, 214);
            InputVldRg.Name = "InputVldRg";
            InputVldRg.PlaceholderText = "01/02/2025";
            InputVldRg.Size = new Size(84, 23);
            InputVldRg.TabIndex = 26;
            InputVldRg.Leave += InputVldRg_Leave;
            // 
            // LabelVldRg
            // 
            LabelVldRg.AutoSize = true;
            LabelVldRg.Font = new Font("Segoe UI", 12F);
            LabelVldRg.ForeColor = SystemColors.ControlLightLight;
            LabelVldRg.Location = new Point(633, 190);
            LabelVldRg.Name = "LabelVldRg";
            LabelVldRg.Size = new Size(69, 21);
            LabelVldRg.TabIndex = 25;
            LabelVldRg.Text = "Validade";
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
            BntRegistrarProduto.Click += BntRegistrarProduto_Click;
            // 
            // InputDscRg
            // 
            InputDscRg.Location = new Point(13, 310);
            InputDscRg.Multiline = true;
            InputDscRg.Name = "InputDscRg";
            InputDscRg.Size = new Size(341, 130);
            InputDscRg.TabIndex = 23;
            InputDscRg.Leave += InputDscRg_Leave;
            // 
            // InputUmRg
            // 
            InputUmRg.Location = new Point(442, 214);
            InputUmRg.Name = "InputUmRg";
            InputUmRg.Size = new Size(145, 23);
            InputUmRg.TabIndex = 22;
            InputUmRg.Leave += InputUmRg_Leave;
            // 
            // InputQtdRg
            // 
            InputQtdRg.Location = new Point(302, 214);
            InputQtdRg.Name = "InputQtdRg";
            InputQtdRg.Size = new Size(91, 23);
            InputQtdRg.TabIndex = 21;
            InputQtdRg.Leave += InputQtdRg_Leave;
            // 
            // InputPrecoRg
            // 
            InputPrecoRg.Location = new Point(155, 214);
            InputPrecoRg.Name = "InputPrecoRg";
            InputPrecoRg.PlaceholderText = "12,3";
            InputPrecoRg.Size = new Size(84, 23);
            InputPrecoRg.TabIndex = 20;
            InputPrecoRg.Leave += InputPrecoRg_Leave;
            // 
            // InputCodigoRg
            // 
            InputCodigoRg.Location = new Point(13, 214);
            InputCodigoRg.Name = "InputCodigoRg";
            InputCodigoRg.Size = new Size(84, 23);
            InputCodigoRg.TabIndex = 19;
            InputCodigoRg.Leave += InputCodigoRg_Leave;
            // 
            // InputFncdRg
            // 
            InputFncdRg.Location = new Point(501, 128);
            InputFncdRg.Name = "InputFncdRg";
            InputFncdRg.Size = new Size(165, 23);
            InputFncdRg.TabIndex = 18;
            InputFncdRg.Leave += InputFncdRg_Leave;
            // 
            // InputCtgRg
            // 
            InputCtgRg.Location = new Point(250, 128);
            InputCtgRg.Name = "InputCtgRg";
            InputCtgRg.Size = new Size(165, 23);
            InputCtgRg.TabIndex = 17;
            InputCtgRg.Leave += InputCtgRg_Leave;
            // 
            // InputNomeRg
            // 
            InputNomeRg.Location = new Point(13, 128);
            InputNomeRg.Name = "InputNomeRg";
            InputNomeRg.Size = new Size(165, 23);
            InputNomeRg.TabIndex = 16;
            InputNomeRg.Leave += InputNomeRg_Leave;
            // 
            // LabelDscRg
            // 
            LabelDscRg.AutoSize = true;
            LabelDscRg.Font = new Font("Segoe UI", 12F);
            LabelDscRg.ForeColor = SystemColors.ControlLightLight;
            LabelDscRg.Location = new Point(13, 286);
            LabelDscRg.Name = "LabelDscRg";
            LabelDscRg.Size = new Size(77, 21);
            LabelDscRg.TabIndex = 15;
            LabelDscRg.Text = "Descrição";
            // 
            // LabelUmRg
            // 
            LabelUmRg.AutoSize = true;
            LabelUmRg.Font = new Font("Segoe UI", 12F);
            LabelUmRg.ForeColor = SystemColors.ControlLightLight;
            LabelUmRg.Location = new Point(442, 190);
            LabelUmRg.Name = "LabelUmRg";
            LabelUmRg.Size = new Size(145, 21);
            LabelUmRg.TabIndex = 14;
            LabelUmRg.Text = "Unidade de Medida";
            // 
            // LabelFncdRg
            // 
            LabelFncdRg.AutoSize = true;
            LabelFncdRg.Font = new Font("Segoe UI", 12F);
            LabelFncdRg.ForeColor = SystemColors.ControlLightLight;
            LabelFncdRg.Location = new Point(501, 104);
            LabelFncdRg.Name = "LabelFncdRg";
            LabelFncdRg.Size = new Size(96, 21);
            LabelFncdRg.TabIndex = 13;
            LabelFncdRg.Text = "Fornecedor*";
            // 
            // LabelQtdRg
            // 
            LabelQtdRg.AutoSize = true;
            LabelQtdRg.Font = new Font("Segoe UI", 12F);
            LabelQtdRg.ForeColor = SystemColors.ControlLightLight;
            LabelQtdRg.Location = new Point(302, 190);
            LabelQtdRg.Name = "LabelQtdRg";
            LabelQtdRg.Size = new Size(98, 21);
            LabelQtdRg.TabIndex = 12;
            LabelQtdRg.Text = "Quantidade*";
            // 
            // LabelPreçoRg
            // 
            LabelPreçoRg.AutoSize = true;
            LabelPreçoRg.Font = new Font("Segoe UI", 12F);
            LabelPreçoRg.ForeColor = SystemColors.ControlLightLight;
            LabelPreçoRg.Location = new Point(155, 190);
            LabelPreçoRg.Name = "LabelPreçoRg";
            LabelPreçoRg.Size = new Size(56, 21);
            LabelPreçoRg.TabIndex = 11;
            LabelPreçoRg.Text = "Preço*";
            // 
            // LabelCtgRg
            // 
            LabelCtgRg.AutoSize = true;
            LabelCtgRg.Font = new Font("Segoe UI", 12F);
            LabelCtgRg.ForeColor = SystemColors.ControlLightLight;
            LabelCtgRg.Location = new Point(250, 104);
            LabelCtgRg.Name = "LabelCtgRg";
            LabelCtgRg.Size = new Size(84, 21);
            LabelCtgRg.TabIndex = 10;
            LabelCtgRg.Text = "Categoria*";
            // 
            // LabelNomeRg
            // 
            LabelNomeRg.AutoSize = true;
            LabelNomeRg.Font = new Font("Segoe UI", 12F);
            LabelNomeRg.ForeColor = SystemColors.ControlLightLight;
            LabelNomeRg.Location = new Point(13, 104);
            LabelNomeRg.Name = "LabelNomeRg";
            LabelNomeRg.Size = new Size(60, 21);
            LabelNomeRg.TabIndex = 9;
            LabelNomeRg.Text = "Nome*";
            // 
            // LabelCodigoRg
            // 
            LabelCodigoRg.AutoSize = true;
            LabelCodigoRg.Font = new Font("Segoe UI", 12F);
            LabelCodigoRg.ForeColor = SystemColors.ControlLightLight;
            LabelCodigoRg.Location = new Point(13, 190);
            LabelCodigoRg.Name = "LabelCodigoRg";
            LabelCodigoRg.Size = new Size(67, 21);
            LabelCodigoRg.TabIndex = 8;
            LabelCodigoRg.Text = "Código*";
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

        private void InputCtgRg_Leave1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LabelCtgRg;
        private Label LabelNomeRg;
        private Label LabelCodigoRg;
        private Label LabelDscRg;
        private Label LabelUmRg;
        private Label LabelFncdRg;
        private Label LabelQtdRg;
        private Label LabelPreçoRg;
        private TextBox InputDscRg;
        private TextBox InputUmRg;
        private TextBox InputQtdRg;
        private TextBox InputPrecoRg;
        private TextBox InputCodigoRg;
        private TextBox InputFncdRg;
        private TextBox InputCtgRg;
        private TextBox InputNomeRg;
        private Label label1;
        private Button BntRegistrarProduto;
        private PictureBox Logo2;
        private TextBox InputVldRg;
        private Label LabelVldRg;
        private Label label2;
        private TextBox TextoInput;
    }
}