using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_e_Estoque.Utilidades
{
    internal static class Utils
    {
        public enum SortWay
        {
            none,
            reverse,
            sort
        }
        
        public static void AddPanelItensToComboBox(ComboBox comboBox, Control panel, SortWay way, string startString = "")
        {
            List<string> lista = [];
            foreach (Control itens in panel.Controls)
            {
                string nomeLabel = itens.Name;

                if (nomeLabel.StartsWith(startString))
                {
                    lista.Add(itens.Text);
                }
            }

            if (way == SortWay.reverse) { lista.Reverse(); }
            else if (way == SortWay.sort) { lista.Sort(); }

            comboBox.Items.AddRange(lista.ToArray());
        }
    }
}
