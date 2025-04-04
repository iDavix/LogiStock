using MySql.Data.MySqlClient;
using System.Data;


namespace SistemaPizzaria
{
    public partial class FormCliente : Form
    {
        string conexao = "server=localhost;user=root;database=pizzaria;password=senacJBQ;port=3307";
        public FormCliente()
        {
            InitializeComponent();
            ListarCliente();
            Text = "Cadastro de cliente";
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
        private void ListarCliente()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT  * FROM cliente";
                MySqlDataAdapter listar = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                listar.Fill(dataTable);
                //tabelaCliente CamelCase
                //Tabel_Cliente SnackCase

                tabelaCliente.DataSource = dataTable;

            }
        }
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string nome = txtNomeCliente.Text;
                string endereco = txtEnderecoCliente.Text;
                string telefone = txtTelefoneCliente.Text;

                if (string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(endereco) ||
                    string.IsNullOrWhiteSpace(telefone) ||
                    telefone.Length > 11 )
                    {
                    MessageBox.Show("Por favor, verifique os campos que não foram preenchidos e também verifique se o telefone é válido com no máximo 11 dígitos");

                    }
            

                conn.Open();
                string query = "INSERT INTO cliente (nome, endereco, telefone) " +
                    "VALUES (@nome, @endereco, @telefone)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", txtNomeCliente.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEnderecoCliente.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefoneCliente.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Cadastrado com sucesso");
                ListarCliente();




            }
        }

    }
}
