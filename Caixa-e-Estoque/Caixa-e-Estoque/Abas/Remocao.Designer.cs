namespace Caixa_e_Estoque
{
    partial class Remocao
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
            BntRmvProduto = new Button();
            CoBoxCtg = new ComboBox();
            BntPqsRmv = new Button();
            InputPqsRmv = new TextBox();
            panel2 = new Panel();
            Logo2 = new PictureBox();
            label1 = new Label();
            PanelRemover = new Panel();
            TxtDscRmv = new Label();
            TxtCtgRmv = new Label();
            TxtUmRmv = new Label();
            TxtCodigoRmv = new Label();
            TxtNomeRmv = new Label();
            TxtVldRmv = new Label();
            TxtQtdRmv = new Label();
            TxtPrecoRmv = new Label();
            TxtFncdRmv = new Label();
            LabelDscUpd = new Label();
            LabelFncdUpd = new Label();
            LabelPrecoUpd = new Label();
            LabelVldUpd = new Label();
            LabelCtgUpd = new Label();
            LabelUmUpd = new Label();
            LabelQtdUpd = new Label();
            LabelCodigoUpd = new Label();
            LabelNomeUpd = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).BeginInit();
            PanelRemover.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(PanelRemover);
            panel1.Controls.Add(BntRmvProduto);
            panel1.Controls.Add(CoBoxCtg);
            panel1.Controls.Add(BntPqsRmv);
            panel1.Controls.Add(InputPqsRmv);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 461);
            panel1.TabIndex = 2;
            // 
            // BntRmvProduto
            // 
            BntRmvProduto.BackColor = Color.Red;
            BntRmvProduto.FlatStyle = FlatStyle.Popup;
            BntRmvProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BntRmvProduto.Location = new Point(600, 106);
            BntRmvProduto.Name = "BntRmvProduto";
            BntRmvProduto.Size = new Size(88, 35);
            BntRmvProduto.TabIndex = 30;
            BntRmvProduto.Text = "Remover";
            BntRmvProduto.UseVisualStyleBackColor = false;
            // 
            // CoBoxCtg
            // 
            CoBoxCtg.DropDownStyle = ComboBoxStyle.DropDownList;
            CoBoxCtg.FormattingEnabled = true;
            CoBoxCtg.Location = new Point(214, 119);
            CoBoxCtg.Name = "CoBoxCtg";
            CoBoxCtg.Size = new Size(91, 23);
            CoBoxCtg.TabIndex = 29;
            CoBoxCtg.SelectedIndexChanged += CoBoxCtg_SelectedIndexChanged;
            // 
            // BntPqsRmv
            // 
            BntPqsRmv.BackColor = Color.RoyalBlue;
            BntPqsRmv.FlatStyle = FlatStyle.Popup;
            BntPqsRmv.Font = new Font("Segoe UI", 9F);
            BntPqsRmv.ForeColor = SystemColors.ControlLightLight;
            BntPqsRmv.Location = new Point(133, 119);
            BntPqsRmv.Name = "BntPqsRmv";
            BntPqsRmv.Size = new Size(75, 23);
            BntPqsRmv.TabIndex = 28;
            BntPqsRmv.Text = "Pesquisar";
            BntPqsRmv.UseVisualStyleBackColor = false;
            // 
            // InputPqsRmv
            // 
            InputPqsRmv.Location = new Point(311, 118);
            InputPqsRmv.Name = "InputPqsRmv";
            InputPqsRmv.Size = new Size(84, 23);
            InputPqsRmv.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(Logo2);
            panel2.Controls.Add(label1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(330, 8);
            label1.Name = "label1";
            label1.Size = new Size(119, 33);
            label1.TabIndex = 6;
            label1.Text = "Remoção";
            // 
            // PanelRemover
            // 
            PanelRemover.AutoScroll = true;
            PanelRemover.BackColor = Color.SkyBlue;
            PanelRemover.Controls.Add(TxtDscRmv);
            PanelRemover.Controls.Add(TxtCtgRmv);
            PanelRemover.Controls.Add(TxtUmRmv);
            PanelRemover.Controls.Add(TxtCodigoRmv);
            PanelRemover.Controls.Add(TxtNomeRmv);
            PanelRemover.Controls.Add(TxtVldRmv);
            PanelRemover.Controls.Add(TxtQtdRmv);
            PanelRemover.Controls.Add(TxtPrecoRmv);
            PanelRemover.Controls.Add(TxtFncdRmv);
            PanelRemover.Controls.Add(LabelDscUpd);
            PanelRemover.Controls.Add(LabelFncdUpd);
            PanelRemover.Controls.Add(LabelPrecoUpd);
            PanelRemover.Controls.Add(LabelVldUpd);
            PanelRemover.Controls.Add(LabelCtgUpd);
            PanelRemover.Controls.Add(LabelUmUpd);
            PanelRemover.Controls.Add(LabelQtdUpd);
            PanelRemover.Controls.Add(LabelCodigoUpd);
            PanelRemover.Controls.Add(LabelNomeUpd);
            PanelRemover.Location = new Point(133, 148);
            PanelRemover.Name = "PanelRemover";
            PanelRemover.Size = new Size(563, 295);
            PanelRemover.TabIndex = 31;
            // 
            // TxtDscRmv
            // 
            TxtDscRmv.BackColor = SystemColors.ControlLightLight;
            TxtDscRmv.FlatStyle = FlatStyle.Popup;
            TxtDscRmv.Location = new Point(86, 194);
            TxtDscRmv.Name = "TxtDscRmv";
            TxtDscRmv.Size = new Size(330, 70);
            TxtDscRmv.TabIndex = 36;
            // 
            // TxtCtgRmv
            // 
            TxtCtgRmv.BackColor = SystemColors.ControlLightLight;
            TxtCtgRmv.FlatStyle = FlatStyle.Popup;
            TxtCtgRmv.Location = new Point(86, 117);
            TxtCtgRmv.Name = "TxtCtgRmv";
            TxtCtgRmv.Size = new Size(158, 23);
            TxtCtgRmv.TabIndex = 35;
            // 
            // TxtUmRmv
            // 
            TxtUmRmv.BackColor = SystemColors.ControlLightLight;
            TxtUmRmv.FlatStyle = FlatStyle.Popup;
            TxtUmRmv.Location = new Point(154, 81);
            TxtUmRmv.Name = "TxtUmRmv";
            TxtUmRmv.Size = new Size(76, 23);
            TxtUmRmv.TabIndex = 34;
            // 
            // TxtCodigoRmv
            // 
            TxtCodigoRmv.BackColor = SystemColors.ControlLightLight;
            TxtCodigoRmv.FlatStyle = FlatStyle.Popup;
            TxtCodigoRmv.Location = new Point(62, 49);
            TxtCodigoRmv.Name = "TxtCodigoRmv";
            TxtCodigoRmv.Size = new Size(96, 23);
            TxtCodigoRmv.TabIndex = 33;
            // 
            // TxtNomeRmv
            // 
            TxtNomeRmv.BackColor = SystemColors.ControlLightLight;
            TxtNomeRmv.FlatStyle = FlatStyle.Popup;
            TxtNomeRmv.Location = new Point(62, 17);
            TxtNomeRmv.Name = "TxtNomeRmv";
            TxtNomeRmv.Size = new Size(192, 23);
            TxtNomeRmv.TabIndex = 32;
            // 
            // TxtVldRmv
            // 
            TxtVldRmv.BackColor = SystemColors.ControlLightLight;
            TxtVldRmv.FlatStyle = FlatStyle.Popup;
            TxtVldRmv.Location = new Point(396, 114);
            TxtVldRmv.Name = "TxtVldRmv";
            TxtVldRmv.Size = new Size(98, 23);
            TxtVldRmv.TabIndex = 31;
            // 
            // TxtQtdRmv
            // 
            TxtQtdRmv.BackColor = SystemColors.ControlLightLight;
            TxtQtdRmv.FlatStyle = FlatStyle.Popup;
            TxtQtdRmv.Location = new Point(418, 82);
            TxtQtdRmv.Name = "TxtQtdRmv";
            TxtQtdRmv.Size = new Size(76, 23);
            TxtQtdRmv.TabIndex = 30;
            // 
            // TxtPrecoRmv
            // 
            TxtPrecoRmv.BackColor = SystemColors.ControlLightLight;
            TxtPrecoRmv.FlatStyle = FlatStyle.Popup;
            TxtPrecoRmv.Location = new Point(376, 52);
            TxtPrecoRmv.Name = "TxtPrecoRmv";
            TxtPrecoRmv.Size = new Size(76, 23);
            TxtPrecoRmv.TabIndex = 29;
            // 
            // TxtFncdRmv
            // 
            TxtFncdRmv.BackColor = SystemColors.ControlLightLight;
            TxtFncdRmv.FlatStyle = FlatStyle.Popup;
            TxtFncdRmv.Location = new Point(416, 22);
            TxtFncdRmv.Name = "TxtFncdRmv";
            TxtFncdRmv.Size = new Size(144, 23);
            TxtFncdRmv.TabIndex = 28;
            // 
            // LabelDscUpd
            // 
            LabelDscUpd.AutoSize = true;
            LabelDscUpd.Font = new Font("Segoe UI", 12F);
            LabelDscUpd.ForeColor = SystemColors.ActiveCaptionText;
            LabelDscUpd.Location = new Point(208, 173);
            LabelDscUpd.Name = "LabelDscUpd";
            LabelDscUpd.Size = new Size(77, 21);
            LabelDscUpd.TabIndex = 18;
            LabelDscUpd.Text = "Descrição";
            // 
            // LabelFncdUpd
            // 
            LabelFncdUpd.AutoSize = true;
            LabelFncdUpd.Font = new Font("Segoe UI", 12F);
            LabelFncdUpd.ForeColor = SystemColors.ActiveCaptionText;
            LabelFncdUpd.Location = new Point(321, 19);
            LabelFncdUpd.Name = "LabelFncdUpd";
            LabelFncdUpd.Size = new Size(89, 21);
            LabelFncdUpd.TabIndex = 17;
            LabelFncdUpd.Text = "Fornecedor";
            // 
            // LabelPrecoUpd
            // 
            LabelPrecoUpd.AutoSize = true;
            LabelPrecoUpd.Font = new Font("Segoe UI", 12F);
            LabelPrecoUpd.ForeColor = SystemColors.ActiveCaptionText;
            LabelPrecoUpd.Location = new Point(321, 49);
            LabelPrecoUpd.Name = "LabelPrecoUpd";
            LabelPrecoUpd.Size = new Size(49, 21);
            LabelPrecoUpd.TabIndex = 16;
            LabelPrecoUpd.Text = "Preço";
            // 
            // LabelVldUpd
            // 
            LabelVldUpd.AutoSize = true;
            LabelVldUpd.Font = new Font("Segoe UI", 12F);
            LabelVldUpd.ForeColor = SystemColors.ActiveCaptionText;
            LabelVldUpd.Location = new Point(321, 112);
            LabelVldUpd.Name = "LabelVldUpd";
            LabelVldUpd.Size = new Size(69, 21);
            LabelVldUpd.TabIndex = 15;
            LabelVldUpd.Text = "Validade";
            // 
            // LabelCtgUpd
            // 
            LabelCtgUpd.AutoSize = true;
            LabelCtgUpd.Font = new Font("Segoe UI", 12F);
            LabelCtgUpd.ForeColor = SystemColors.ActiveCaptionText;
            LabelCtgUpd.Location = new Point(3, 114);
            LabelCtgUpd.Name = "LabelCtgUpd";
            LabelCtgUpd.Size = new Size(77, 21);
            LabelCtgUpd.TabIndex = 14;
            LabelCtgUpd.Text = "Categoria";
            // 
            // LabelUmUpd
            // 
            LabelUmUpd.AutoSize = true;
            LabelUmUpd.Font = new Font("Segoe UI", 12F);
            LabelUmUpd.ForeColor = SystemColors.ActiveCaptionText;
            LabelUmUpd.Location = new Point(3, 81);
            LabelUmUpd.Name = "LabelUmUpd";
            LabelUmUpd.Size = new Size(145, 21);
            LabelUmUpd.TabIndex = 13;
            LabelUmUpd.Text = "Unidade de Medida";
            // 
            // LabelQtdUpd
            // 
            LabelQtdUpd.AutoSize = true;
            LabelQtdUpd.Font = new Font("Segoe UI", 12F);
            LabelQtdUpd.ForeColor = SystemColors.ActiveCaptionText;
            LabelQtdUpd.Location = new Point(321, 81);
            LabelQtdUpd.Name = "LabelQtdUpd";
            LabelQtdUpd.Size = new Size(91, 21);
            LabelQtdUpd.TabIndex = 12;
            LabelQtdUpd.Text = "Quantidade";
            // 
            // LabelCodigoUpd
            // 
            LabelCodigoUpd.AutoSize = true;
            LabelCodigoUpd.Font = new Font("Segoe UI", 12F);
            LabelCodigoUpd.ForeColor = SystemColors.ActiveCaptionText;
            LabelCodigoUpd.Location = new Point(0, 49);
            LabelCodigoUpd.Name = "LabelCodigoUpd";
            LabelCodigoUpd.Size = new Size(60, 21);
            LabelCodigoUpd.TabIndex = 11;
            LabelCodigoUpd.Text = "Código";
            // 
            // LabelNomeUpd
            // 
            LabelNomeUpd.AutoSize = true;
            LabelNomeUpd.Font = new Font("Segoe UI", 12F);
            LabelNomeUpd.ForeColor = SystemColors.ActiveCaptionText;
            LabelNomeUpd.Location = new Point(3, 17);
            LabelNomeUpd.Name = "LabelNomeUpd";
            LabelNomeUpd.Size = new Size(53, 21);
            LabelNomeUpd.TabIndex = 10;
            LabelNomeUpd.Text = "Nome";
            // 
            // Remocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Remocao";
            Text = "Remocao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).EndInit();
            PanelRemover.ResumeLayout(false);
            PanelRemover.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox Logo2;
        private Label label1;
        private Button BntRmvProduto;
        private ComboBox CoBoxCtg;
        private Button BntPqsRmv;
        private TextBox InputPqsRmv;
        private Panel PanelRemover;
        private Label TxtDscRmv;
        private Label TxtCtgRmv;
        private Label TxtUmRmv;
        private Label TxtCodigoRmv;
        private Label TxtNomeRmv;
        private Label TxtVldRmv;
        private Label TxtQtdRmv;
        private Label TxtPrecoRmv;
        private Label TxtFncdRmv;
        private Label LabelDscUpd;
        private Label LabelFncdUpd;
        private Label LabelPrecoUpd;
        private Label LabelVldUpd;
        private Label LabelCtgUpd;
        private Label LabelUmUpd;
        private Label LabelQtdUpd;
        private Label LabelCodigoUpd;
        private Label LabelNomeUpd;
    }
}