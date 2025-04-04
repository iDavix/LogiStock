namespace SistemaPizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string nome = txtCliente.Text;
            string senha = txtSenha.Text;
            

            if(nome == "admin"  && senha == "admin")
            {
                FormMenu menu = new FormMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválido!");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
