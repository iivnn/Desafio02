using Desafio02.Forms;
using Desafio02Library;
using Desafio02Library.Controllers;

namespace Desafio02
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {            
            InitializeComponent();
            UpdateDevDataSource();
        }

        private void updateDevDataGridViewDataTimer_Tick(object sender, EventArgs e)
        {
            updateDevDataGridViewDataTimer.Stop();
            UpdateDevDataSource();
            updateDevDataGridViewDataTimer.Start();
        }

        private void UpdateDevDataSource()
        {
            try
            {
                devDataGridView.Enabled = false;
                var devs = DevController.GetDevs();
                devBindingSource.DataSource = devs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                devDataGridView.Enabled = true;
            }
        }

        private void novoDevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novoForm = new CriarEditarDevForm(null);
            novoForm.ShowDialog();
        }

        private void devDataGridView_DoubleClick(object sender, EventArgs e)
        {
            var devGrid = (DataGridView)sender;
            if(devGrid.SelectedRows.Count > 0)
            {
                var dev = (Dev)((Dev)devGrid.SelectedRows[0].DataBoundItem).Clone();
                var novoForm = new CriarEditarDevForm(dev);
                novoForm.ShowDialog();
            }            
        }

        private void squadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novoForm = new SquadsForm();
            novoForm.ShowDialog();
        }
    }
}