
using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string assunto;
        public DateTime data;
        public DateTime inicio;
        public DateTime termino;

        public Compromisso(string assunto, DateTime data, DateTime inicio, DateTime termino)
        {
            this.assunto = assunto;
            this.data = data;
            this.inicio = inicio;
            this.termino = termino;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Assunto: {assunto}, Data: {data}";
        }
    }
}
