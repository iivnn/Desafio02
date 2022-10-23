using Desafio02Library;
using Desafio02Library.Classes;
using Desafio02Library.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio02.Forms
{
    public partial class SquadsForm : Form
    {
        public SquadsForm()
        {
            InitializeComponent();
            AdjustControls();
        }

        private void AdjustControls()
        {
            squadBindingSource.DataSource = SquadController.GetAllSquads();
        }

        private void squadDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var squad = (Squad)e.Row.DataBoundItem;
            SquadController.RemoveSquad(squad.Id);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SquadController.AddSquad(nomeTextBox.Text);
            squadBindingSource.DataSource = SquadController.GetAllSquads();
        }
    }
}
