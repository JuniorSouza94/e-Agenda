using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    internal class ControladorDeCompromissos : ControladorBase
    {
        private readonly RepositorioCompromisso repositorioCompromisso;
        private ListaCompromissosControl listaCompromissos;
        public ControladorDeCompromissos(RepositorioCompromisso repositorioCompromisso)
        {
            this.repositorioCompromisso = repositorioCompromisso;
        }
        public override string ToolTipInserir { get { return "Inserir um novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Compromisso existente"; } }

        public override void Inserir()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            telaCompromisso.ShowDialog();
        }
       
        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            Compromisso compromisso = listaCompromissos.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o compromisso {compromisso.assunto}?",
            "Exclusão de Compromissos", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listaCompromissos.AtualizarRegistros(compromissos);
        }
        public override UserControl ObterListagem()
        {
            if (listaCompromissos == null)
            {
                listaCompromissos = new ListaCompromissosControl();
            }

            CarregarCompromissos();

            return listaCompromissos;
        }

        public override string ObterTipoCadastro()
        { return "Cadastro de Compromissos"; }
    }
}
