
namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public TelaContatoForm()
        {
            InitializeComponent();
        }

        public Contato Contato
        { get { return contato; }
          set { txtId.Text = value.Id.ToString();
                txtNome.Text = value.nome;
                txtTelefone.Text = value.telefone;
                txtEmail.Text = value.email;
                txtEmpresa.Text = value.empresa;
                txtCargo.Text = value.cargo; 
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string empresa = txtEmpresa.Text;
            string cargo = txtCargo.Text;

            contato = new Contato(
                nome, telefone, email, empresa, cargo);

            if (txtId.Text != "0")
            {
                contato.Id = Convert.ToInt32(txtId.Text);
            }
        }
    }
}
