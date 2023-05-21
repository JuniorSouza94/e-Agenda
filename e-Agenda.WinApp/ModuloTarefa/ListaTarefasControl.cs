using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListaTarefasControl : UserControl
    {
        List<Tarefas> tarefas = new List<Tarefas>();
        public ListaTarefasControl()
        {
            InitializeComponent();

            tarefas.Add(new Tarefas(1,"Implementação Forms", "Máxima!"));

            foreach (Tarefas item in tarefas)
            {
                listTarefas.Items.Add(item);
            }
        }
    }
}
