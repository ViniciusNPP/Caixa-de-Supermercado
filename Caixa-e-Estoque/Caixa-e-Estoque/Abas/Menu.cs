using Caixa_e_Estoque.Data;

namespace Caixa_e_Estoque
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirFormBnt<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Registrador_Click(object sender, EventArgs e)
        {
            AbrirFormBnt<Registrador>();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            AbrirFormBnt<Atualizar>();
        }
        private void Estoque_Click(object sender, EventArgs e)
        {
            AbrirFormBnt<Estoque>();
        }
        private void Remocao_Click(object sender, EventArgs e)
        {
            AbrirFormBnt<Remocao>();
        }

        private void Título_Click(object sender, EventArgs e)
        {

        }

        private void BntBancoDeDados_Click(object sender, EventArgs e)
        {
            DataBase db = new();
            List<string> itens = db.Select("");

            foreach (var item in itens)
            {
                RespostaSql.Text = item;
            }
        }
    }
}
