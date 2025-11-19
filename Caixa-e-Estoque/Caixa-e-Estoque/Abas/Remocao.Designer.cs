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
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 461);
            panel1.TabIndex = 2;
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
            // Remocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Remocao";
            Text = "Remocao";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox Logo2;
        private Label label1;
    }
}