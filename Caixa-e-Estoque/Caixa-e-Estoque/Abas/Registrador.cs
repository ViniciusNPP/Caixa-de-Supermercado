using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caixa_e_Estoque.Data;

namespace Caixa_e_Estoque
{
    public partial class Registrador : Form
    {
        private readonly List<string> input_itens = [];
        private readonly DataBase db = new();

        public Registrador()
        {
            InitializeComponent();
        }

        private void InputNomeRg_Leave(object sender, EventArgs e)
        {
            input_itens.Add(InputNomeRg.Text);
        }

        private void InputCtgRg_Leave(object sender, EventArgs e)
        {
            input_itens.Add(InputCtgRg.Text);
        }

        private void InputFncdRg_Leave(object sender, EventArgs e)
        {
            input_itens.Add(InputFncdRg.Text);
        }

        private void InputCodigoRg_Leave(object sender, EventArgs e)
        {
            input_itens.Add(InputCodigoRg.Text);
        }

        private void InputPrecoRg_Leave(object sender, EventArgs e)
        {
            input_itens.Add(InputPrecoRg.Text);
        }

        private void InputQtdRg_Leave(object sender, EventArgs e)
        {
            input_itens.Add(InputQtdRg.Text);
        }

        private void InputUmRg_Leave(object sender, EventArgs e)
        {
            input_itens.Add(InputUmRg.Text);
        }

        private void InputVldRg_Leave(object sender, EventArgs e)
        {
            input_itens.Add(InputVldRg.Text);
        }
        
        private void InputDscRg_Leave(object sender, EventArgs e)
        {
            input_itens.Add(InputDscRg.Text);
        }

        private void BntRegistrarProduto_Click(object sender, EventArgs e)
        {
            bool camposValidos = true;
            bool sucesso = false;
            
            if (input_itens.Count < 6)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                camposValidos = false;
            }

            if (camposValidos)
            {
                TextoInput.Text = string.Join(", ", input_itens);
                input_itens[4] = input_itens[4].Replace(".", ",");

                sucesso = db.Create(input_itens);

                if (sucesso)
                {
                    input_itens.Clear();
                    InputNomeRg.Clear();
                    InputCtgRg.Clear();
                    InputFncdRg.Clear();
                    InputCodigoRg.Clear();
                    InputPrecoRg.Clear();
                    InputQtdRg.Clear();
                    InputUmRg.Clear();
                    InputVldRg.Clear();
                    InputDscRg.Clear();
                }
            }
        }
    }
}
