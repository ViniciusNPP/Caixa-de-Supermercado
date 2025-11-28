using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Caixa_e_Estoque.Utilidades.Utils;

namespace Caixa_e_Estoque
{
    public partial class Atualizar : Form
    {
        public Atualizar()
        {
            InitializeComponent();

            //Faz o comboBox receber os nome dos labels do painel
            AddPanelItensToComboBox(CoBoxCtg, PanelAtualizar, SortWay.reverse, "Label");
        }

        private void CoBoxCtg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
