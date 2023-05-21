using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class ListaContatosControl : UserControl
    {
        public ListaContatosControl()
        {
            InitializeComponent();           
        }
        public void AtualizarRegistros(List<Contato> contatos)
        {
            listContatos.Items.Clear();

            foreach (Contato item in contatos)
            {
                listContatos.Items.Add(item);
            }
        }
        public Contato ObterContatoSelecionado()
        {
            return (Contato)listContatos.SelectedItem;
        }
    }
}
