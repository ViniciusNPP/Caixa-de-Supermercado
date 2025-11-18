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
            button3 = new Button();
            button2 = new Button();
            Estoque = new Button();
            Registrador = new Button();
            Título = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(Título);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Estoque);
            panel1.Controls.Add(Registrador);
            panel1.Name = "panel1";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackColor = Color.RoyalBlue;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // Estoque
            // 
            resources.ApplyResources(Estoque, "Estoque");
            Estoque.BackColor = Color.RoyalBlue;
            Estoque.Cursor = Cursors.Hand;
            Estoque.ForeColor = SystemColors.ControlLightLight;
            Estoque.Name = "Estoque";
            Estoque.UseVisualStyleBackColor = false;
            // 
            // Registrador
            // 
            resources.ApplyResources(Registrador, "Registrador");
            Registrador.BackColor = Color.RoyalBlue;
            Registrador.Cursor = Cursors.Hand;
            Registrador.ForeColor = SystemColors.ControlLightLight;
            Registrador.Name = "Registrador";
            Registrador.UseVisualStyleBackColor = false;
            Registrador.Click += Registrador_Click;
            // 
            // Título
            // 
            resources.ApplyResources(Título, "Título");
            Título.Name = "Título";
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Menu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button Estoque;
        private Button Registrador;
        private Label Título;
    }
}
