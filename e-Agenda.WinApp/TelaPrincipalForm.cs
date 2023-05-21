using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioContato repositorioContato = new RepositorioContato();
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }
        //                          [MENU CLICK]
        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDeContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }
        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDeTarefa();

            ConfigurarTelaPrincipal(controlador);
        }
        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDeCompromissos();

            ConfigurarTelaPrincipal(controlador);
        }
        //                         [CONFIGURAÇÕES]
        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }
        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText =  controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }
        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }
        
        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
    }
}