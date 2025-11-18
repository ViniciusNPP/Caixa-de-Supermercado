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
    }
}
