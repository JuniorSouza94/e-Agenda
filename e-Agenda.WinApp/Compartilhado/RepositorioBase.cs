
namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<T>
    {
        protected List<T> itens = new List<T>();
        private static int contador;

        public void Inserir(T item)
        {
            contador++;
            DefinirId(item, contador);
            itens.Add(item);
        }

        public List<T> SelecionarTodos()
        {
            return itens;
        }

        public void Excluir(T item)
        {
            itens.Remove(item);
        }

        protected abstract void DefinirId(T item, int id);
    }
}
