using Desafio02Library.Client;
using Desafio02Library.Controllers;

namespace Desafio02
{
    public partial class PrincipalForm : Form
    {
        private System.Timers.Timer _updateDevsTimer;

        public PrincipalForm()
        {            
            InitializeComponent();
        }

        private void updateDevDataGridViewDataTimer_Tick(object sender, EventArgs e)
        {
            UpdateDevDataSource();
        }s

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

    }
}