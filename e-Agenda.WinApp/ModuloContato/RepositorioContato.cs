using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        protected override void DefinirId(Contato item, int id)
        {
            item.Id = id;
        }

        public void Editar(Contato contato)
        {
            Contato contatoSelecionado = SelecionarPorId(contato.Id);

            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.telefone = contato.telefone;
            contatoSelecionado.email = contato.email;
            contatoSelecionado.empresa = contato.empresa;
            contatoSelecionado.cargo = contato.cargo;
        }

        private Contato SelecionarPorId(int id)
        {
            return itens.FirstOrDefault(c => c.Id == id);
        }
    }
}
