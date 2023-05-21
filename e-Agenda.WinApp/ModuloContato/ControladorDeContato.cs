using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorDeContato : ControladorBase
    {
        private readonly RepositorioContato repositorioContato;
        private ListaContatosControl listaContatos;
        public ControladorDeContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }
      
        public override string ToolTipInserir {get { return "Inserir um novo Contato"; }}

        public override string ToolTipEditar  {get {return "Editar um Contato existente"; }}

        public override string ToolTipExcluir {get {return "Excluir um Contato existente"; }}


        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Inserir(contato);
                CarregarContatos();
            }
        }
        public override void Editar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.Contato = listaContatos.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Editar(contato);

                CarregarContatos();
            }
        }
        public override void Excluir()
        {
            Contato contato = listaContatos.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?",
            "Exclusão de Contatos", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Excluir(contato);

                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listaContatos.AtualizarRegistros(contatos);
        }

        public override string ObterTipoCadastro() 
        { return "Cadastro de Contatos"; }

        public override UserControl ObterListagem()
        {
            if (listaContatos == null)
            {
                listaContatos = new ListaContatosControl();
            }

            CarregarContatos();

            return listaContatos;
        }

    }
}
