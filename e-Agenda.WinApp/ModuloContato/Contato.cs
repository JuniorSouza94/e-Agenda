using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase
    {
        public string nome;
        public string telefone;
        public string email;
        public string empresa;
        public string cargo;

        public Contato(
            string nome, string telefone, 
            string email, string empresa, string cargo)
        {
             this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.empresa = empresa;
            this.cargo = cargo;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {nome}, Empresa: {empresa}";
        }
    }
}
