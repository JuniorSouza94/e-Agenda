namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefas
    {
        public int id;
        public string titulo;
        public string prioridade;

        public Tarefas(int id, string titulo, string prioridade)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return $"Id: {id}, Título: {titulo}, Prioridade: {prioridade}";
        }
    }
}
