using e_Agenda.WinApp.ModuloCompromisso;

namespace e_Agenda.WinApp.Compartilhado
{
    public partial class ListaCompromissosControl : UserControl
    {
        public ListaCompromissosControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            listCompromissos.Items.Clear();

            foreach (Compromisso item in compromissos)
            {
                listCompromissos.Items.Add(item);
            }
        }
        public Compromisso ObterContatoSelecionado()
        {
            return (Compromisso)listCompromissos.SelectedItem;
        }
    }
}
