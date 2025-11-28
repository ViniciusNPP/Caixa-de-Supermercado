namespace Caixa_e_Estoque
{
    partial class Estoque
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
            CoBoxCtg = new ComboBox();
            BntPqsStq = new Button();
            InputPqsStq = new TextBox();
            panel2 = new Panel();
            Logo2 = new PictureBox();
            Titulo = new Label();
            PanelColunaEstoque = new Panel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            LabelFncdStq = new Label();
            LabelPrecoStq = new Label();
            LabelVldStq = new Label();
            LabelUmStq = new Label();
            LabelQtdStq = new Label();
            LabelCtgStq = new Label();
            LabelNomeStq = new Label();
            LabelCodigoStq = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).BeginInit();
            PanelColunaEstoque.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(CoBoxCtg);
            panel1.Controls.Add(BntPqsStq);
            panel1.Controls.Add(InputPqsStq);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(PanelColunaEstoque);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-5, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 461);
            panel1.TabIndex = 0;
            // 
            // CoBoxCtg
            // 
            CoBoxCtg.DropDownStyle = ComboBoxStyle.DropDownList;
            CoBoxCtg.FormattingEnabled = true;
            CoBoxCtg.Location = new Point(612, 81);
            CoBoxCtg.Name = "CoBoxCtg";
            CoBoxCtg.Size = new Size(91, 23);
            CoBoxCtg.TabIndex = 11;
            CoBoxCtg.SelectedIndexChanged += comboBoxEstoque_SelectedIndexChanged;
            // 
            // BntPqsStq
            // 
            BntPqsStq.BackColor = Color.RoyalBlue;
            BntPqsStq.FlatStyle = FlatStyle.Popup;
            BntPqsStq.Font = new Font("Segoe UI", 9F);
            BntPqsStq.ForeColor = SystemColors.ControlLightLight;
            BntPqsStq.Location = new Point(531, 81);
            BntPqsStq.Name = "BntPqsStq";
            BntPqsStq.Size = new Size(75, 23);
            BntPqsStq.TabIndex = 9;
            BntPqsStq.Text = "Pesquisar";
            BntPqsStq.UseVisualStyleBackColor = false;
            BntPqsStq.Click += BntPesquisar_Click;
            // 
            // InputPqsStq
            // 
            InputPqsStq.Location = new Point(709, 80);
            InputPqsStq.Name = "InputPqsStq";
            InputPqsStq.Size = new Size(84, 23);
            InputPqsStq.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(Logo2);
            panel2.Controls.Add(Titulo);
            panel2.Location = new Point(5, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 62);
            panel2.TabIndex = 7;
            // 
            // Logo2
            // 
            Logo2.Image = Properties.Resources.Carrinho_de_Compra;
            Logo2.Location = new Point(261, -3);
            Logo2.Name = "Logo2";
            Logo2.Size = new Size(66, 65);
            Logo2.TabIndex = 7;
            Logo2.TabStop = false;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Candara", 20.25F, FontStyle.Bold | FontStyle.Italic);
            Titulo.Location = new Point(330, 8);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(106, 33);
            Titulo.TabIndex = 6;
            Titulo.Text = "Estoque";
            // 
            // PanelColunaEstoque
            // 
            PanelColunaEstoque.BackColor = Color.PowderBlue;
            PanelColunaEstoque.Controls.Add(label15);
            PanelColunaEstoque.Controls.Add(label14);
            PanelColunaEstoque.Controls.Add(label13);
            PanelColunaEstoque.Controls.Add(label12);
            PanelColunaEstoque.Controls.Add(label11);
            PanelColunaEstoque.Controls.Add(label10);
            PanelColunaEstoque.Controls.Add(label9);
            PanelColunaEstoque.Controls.Add(LabelFncdStq);
            PanelColunaEstoque.Controls.Add(LabelPrecoStq);
            PanelColunaEstoque.Controls.Add(LabelVldStq);
            PanelColunaEstoque.Controls.Add(LabelUmStq);
            PanelColunaEstoque.Controls.Add(LabelQtdStq);
            PanelColunaEstoque.Controls.Add(LabelCtgStq);
            PanelColunaEstoque.Controls.Add(LabelNomeStq);
            PanelColunaEstoque.Controls.Add(LabelCodigoStq);
            PanelColunaEstoque.Location = new Point(17, 109);
            PanelColunaEstoque.Name = "PanelColunaEstoque";
            PanelColunaEstoque.Size = new Size(776, 33);
            PanelColunaEstoque.TabIndex = 0;
            // 
            // label15
            // 
            label15.BackColor = Color.DarkCyan;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.FlatStyle = FlatStyle.Popup;
            label15.Location = new Point(77, 0);
            label15.Name = "label15";
            label15.Size = new Size(2, 33);
            label15.TabIndex = 8;
            // 
            // label14
            // 
            label14.BackColor = Color.DarkCyan;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Location = new Point(159, 0);
            label14.Name = "label14";
            label14.Size = new Size(2, 33);
            label14.TabIndex = 7;
            // 
            // label13
            // 
            label13.BackColor = Color.DarkCyan;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.FlatStyle = FlatStyle.Popup;
            label13.Location = new Point(668, 2);
            label13.Name = "label13";
            label13.Size = new Size(2, 33);
            label13.TabIndex = 6;
            // 
            // label12
            // 
            label12.BackColor = Color.DarkCyan;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.FlatStyle = FlatStyle.Popup;
            label12.Location = new Point(571, 2);
            label12.Name = "label12";
            label12.Size = new Size(2, 33);
            label12.TabIndex = 5;
            // 
            // label11
            // 
            label11.BackColor = Color.DarkCyan;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Location = new Point(260, 0);
            label11.Name = "label11";
            label11.Size = new Size(2, 33);
            label11.TabIndex = 4;
            // 
            // label10
            // 
            label10.BackColor = Color.DarkCyan;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Location = new Point(365, 0);
            label10.Name = "label10";
            label10.Size = new Size(2, 33);
            label10.TabIndex = 3;
            // 
            // label9
            // 
            label9.BackColor = Color.DarkCyan;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Location = new Point(443, 0);
            label9.Name = "label9";
            label9.Size = new Size(2, 33);
            label9.TabIndex = 1;
            // 
            // LabelFncdStq
            // 
            LabelFncdStq.AutoSize = true;
            LabelFncdStq.Location = new Point(692, 9);
            LabelFncdStq.Name = "LabelFncdStq";
            LabelFncdStq.Size = new Size(67, 15);
            LabelFncdStq.TabIndex = 1;
            LabelFncdStq.Text = "Fornecedor";
            // 
            // LabelPrecoStq
            // 
            LabelPrecoStq.AutoSize = true;
            LabelPrecoStq.Location = new Point(387, 9);
            LabelPrecoStq.Name = "LabelPrecoStq";
            LabelPrecoStq.Size = new Size(37, 15);
            LabelPrecoStq.TabIndex = 1;
            LabelPrecoStq.Text = "Preço";
            // 
            // LabelVldStq
            // 
            LabelVldStq.AutoSize = true;
            LabelVldStq.Location = new Point(595, 9);
            LabelVldStq.Name = "LabelVldStq";
            LabelVldStq.Size = new Size(51, 15);
            LabelVldStq.TabIndex = 2;
            LabelVldStq.Text = "Validade";
            // 
            // LabelUmStq
            // 
            LabelUmStq.AutoSize = true;
            LabelUmStq.Location = new Point(465, 9);
            LabelUmStq.Name = "LabelUmStq";
            LabelUmStq.Size = new Size(81, 15);
            LabelUmStq.TabIndex = 1;
            LabelUmStq.Text = "Unid. de Med.";
            // 
            // LabelQtdStq
            // 
            LabelQtdStq.AutoSize = true;
            LabelQtdStq.Location = new Point(277, 9);
            LabelQtdStq.Name = "LabelQtdStq";
            LabelQtdStq.Size = new Size(69, 15);
            LabelQtdStq.TabIndex = 1;
            LabelQtdStq.Text = "Quantidade";
            // 
            // LabelCtgStq
            // 
            LabelCtgStq.AutoSize = true;
            LabelCtgStq.Location = new Point(179, 9);
            LabelCtgStq.Name = "LabelCtgStq";
            LabelCtgStq.Size = new Size(58, 15);
            LabelCtgStq.TabIndex = 1;
            LabelCtgStq.Text = "Categoria";
            // 
            // LabelNomeStq
            // 
            LabelNomeStq.AutoSize = true;
            LabelNomeStq.Location = new Point(96, 9);
            LabelNomeStq.Name = "LabelNomeStq";
            LabelNomeStq.Size = new Size(40, 15);
            LabelNomeStq.TabIndex = 1;
            LabelNomeStq.Text = "Nome";
            // 
            // LabelCodigoStq
            // 
            LabelCodigoStq.AutoSize = true;
            LabelCodigoStq.Location = new Point(16, 9);
            LabelCodigoStq.Name = "LabelCodigoStq";
            LabelCodigoStq.Size = new Size(46, 15);
            LabelCodigoStq.TabIndex = 0;
            LabelCodigoStq.Text = "Codigo";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(17, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 373);
            panel3.TabIndex = 10;
            // 
            // label8
            // 
            label8.BackColor = Color.DarkCyan;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Location = new Point(668, 2);
            label8.Name = "label8";
            label8.Size = new Size(2, 350);
            label8.TabIndex = 6;
            // 
            // label7
            // 
            label7.BackColor = Color.DarkCyan;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Location = new Point(571, 0);
            label7.Name = "label7";
            label7.Size = new Size(2, 350);
            label7.TabIndex = 5;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkCyan;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Location = new Point(443, 0);
            label6.Name = "label6";
            label6.Size = new Size(2, 350);
            label6.TabIndex = 4;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkCyan;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Location = new Point(365, 2);
            label5.Name = "label5";
            label5.Size = new Size(2, 350);
            label5.TabIndex = 3;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkCyan;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Location = new Point(260, 0);
            label4.Name = "label4";
            label4.Size = new Size(2, 350);
            label4.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkCyan;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Location = new Point(159, 0);
            label3.Name = "label3";
            label3.Size = new Size(2, 350);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkCyan;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Location = new Point(77, 0);
            label2.Name = "label2";
            label2.Size = new Size(2, 350);
            label2.TabIndex = 0;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Estoque";
            Text = "Estoque";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).EndInit();
            PanelColunaEstoque.ResumeLayout(false);
            PanelColunaEstoque.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox Logo2;
        private Label Titulo;
        private Panel PanelColunaEstoque;
        private Button BntPqsStq;
        private TextBox InputPqsStq;
        private Label LabelCodigoStq;
        private Panel panel3;
        private Label LabelNomeStq;
        private Label LabelPrecoStq;
        private Label LabelFncdStq;
        private Label LabelCtgStq;
        private Label LabelUmStq;
        private Label LabelQtdStq;
        private Label LabelVldStq;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox CoBoxCtg;
    }
}