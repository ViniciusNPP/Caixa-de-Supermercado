using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using static Caixa_e_Estoque.Utilidades.Utils;

namespace Caixa_e_Estoque
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();

            //Faz o comboBox receber os nome dos labels do painel
            AddPanelItensToComboBox(CoBoxCtg, PanelColunaEstoque, SortWay.reverse, "Label");

        }

        private void BntPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
