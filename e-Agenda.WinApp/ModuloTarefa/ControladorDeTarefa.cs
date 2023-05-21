using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorDeTarefa : ControladorBase
    {
        public override string ToolTipInserir { get { return "Inserir uma nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar uma Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma Tarefa existente"; } }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            telaTarefa.ShowDialog();
        }
        public override string ObterTipoCadastro()
        { return "Cadastro de Tarefas"; }


        public override UserControl ObterListagem()
        {
            return new ListaTarefasControl();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}

