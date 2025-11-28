namespace Caixa_e_Estoque
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            BntBancoDeDados = new Button();
            Logo2 = new PictureBox();
            Título = new Label();
            BntRemocaoMenu = new Button();
            BntAtualizarMenu = new Button();
            BntEstoqueMenu = new Button();
            BntRegistradorMenu = new Button();
            RespostaSql = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(BntBancoDeDados);
            panel1.Controls.Add(Logo2);
            panel1.Controls.Add(Título);
            panel1.Controls.Add(BntRemocaoMenu);
            panel1.Controls.Add(BntAtualizarMenu);
            panel1.Controls.Add(BntEstoqueMenu);
            panel1.Controls.Add(BntRegistradorMenu);
            panel1.Name = "panel1";
            // 
            // BntBancoDeDados
            // 
            resources.ApplyResources(BntBancoDeDados, "BntBancoDeDados");
            BntBancoDeDados.BackColor = Color.RoyalBlue;
            BntBancoDeDados.Cursor = Cursors.Hand;
            BntBancoDeDados.ForeColor = SystemColors.ControlLightLight;
            BntBancoDeDados.Image = Properties.Resources.banco_de_dados;
            BntBancoDeDados.Name = "BntBancoDeDados";
            BntBancoDeDados.UseVisualStyleBackColor = false;
            BntBancoDeDados.Click += BntBancoDeDados_Click;
            // 
            // Logo2
            // 
            resources.ApplyResources(Logo2, "Logo2");
            Logo2.Image = Properties.Resources.Carrinho_de_Compra;
            Logo2.Name = "Logo2";
            Logo2.TabStop = false;
            // 
            // Título
            // 
            resources.ApplyResources(Título, "Título");
            Título.Name = "Título";
            Título.Click += Título_Click;
            // 
            // BntRemocaoMenu
            // 
            resources.ApplyResources(BntRemocaoMenu, "BntRemocaoMenu");
            BntRemocaoMenu.BackColor = Color.RoyalBlue;
            BntRemocaoMenu.Cursor = Cursors.Hand;
            BntRemocaoMenu.ForeColor = SystemColors.ControlLightLight;
            BntRemocaoMenu.Name = "BntRemocaoMenu";
            BntRemocaoMenu.UseVisualStyleBackColor = false;
            BntRemocaoMenu.Click += Remocao_Click;
            // 
            // BntAtualizarMenu
            // 
            resources.ApplyResources(BntAtualizarMenu, "BntAtualizarMenu");
            BntAtualizarMenu.BackColor = Color.RoyalBlue;
            BntAtualizarMenu.Cursor = Cursors.Hand;
            BntAtualizarMenu.ForeColor = SystemColors.ControlLightLight;
            BntAtualizarMenu.Name = "BntAtualizarMenu";
            BntAtualizarMenu.UseVisualStyleBackColor = false;
            BntAtualizarMenu.Click += Atualizar_Click;
            // 
            // BntEstoqueMenu
            // 
            resources.ApplyResources(BntEstoqueMenu, "BntEstoqueMenu");
            BntEstoqueMenu.BackColor = Color.RoyalBlue;
            BntEstoqueMenu.Cursor = Cursors.Hand;
            BntEstoqueMenu.ForeColor = SystemColors.ControlLightLight;
            BntEstoqueMenu.Name = "BntEstoqueMenu";
            BntEstoqueMenu.UseVisualStyleBackColor = false;
            BntEstoqueMenu.Click += Estoque_Click;
            // 
            // BntRegistradorMenu
            // 
            resources.ApplyResources(BntRegistradorMenu, "BntRegistradorMenu");
            BntRegistradorMenu.BackColor = Color.RoyalBlue;
            BntRegistradorMenu.Cursor = Cursors.Hand;
            BntRegistradorMenu.ForeColor = SystemColors.ControlLightLight;
            BntRegistradorMenu.Name = "BntRegistradorMenu";
            BntRegistradorMenu.UseVisualStyleBackColor = false;
            BntRegistradorMenu.Click += Registrador_Click;
            // 
            // RespostaSql
            // 
            resources.ApplyResources(RespostaSql, "RespostaSql");
            RespostaSql.Name = "RespostaSql";
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(RespostaSql);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Menu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BntRemocaoMenu;
        private Button BntAtualizarMenu;
        private Button BntEstoqueMenu;
        private Button BntRegistradorMenu;
        private Label Título;
        private PictureBox Logo2;
        private Button BntBancoDeDados;
        private TextBox RespostaSql;
    }
}
