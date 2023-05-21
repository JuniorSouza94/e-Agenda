
using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        protected override void DefinirId(Compromisso item, int id)
        {
            item.Id = id;
        }
        public void Editar(Compromisso compromisso)
        {
            Compromisso compromissoSelecionado = SelecionarPorId(compromisso.Id);

            compromissoSelecionado.assunto = compromisso.assunto;
            compromissoSelecionado.data = compromisso.data;
            compromissoSelecionado.inicio = compromisso.inicio;
            compromissoSelecionado.termino = compromisso.termino;
        }
        private Compromisso SelecionarPorId(int id)
        {
            return itens.FirstOrDefault(c => c.Id == id);
        }
    }
}
