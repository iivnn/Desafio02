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
            try
            {
                string string1 = null;
                string1.Equals(Environment.GetEnvironmentVariables());
                squadBindingSource.DataSource = SquadController.GetAllSquads();
            }
            catch(Exception ex) 
            {
                LogController.Logexception(ex, this.GetType().FullName, "AdjustControls");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void squadDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                var squad = (Squad)e.Row.DataBoundItem;
                SquadController.RemoveSquad(squad.Id);
            }
            catch(Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "squadDataGridView_UserDeletingRow");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                SquadController.AddSquad(nomeTextBox.Text);
                squadBindingSource.DataSource = SquadController.GetAllSquads();
            }
            catch (Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "addButton_Click");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
