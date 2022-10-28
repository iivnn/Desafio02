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
                var devs = DevController.GetDevs();
                devBindingSource.DataSource = devs;
            }
            catch(Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "UpdateDevDataSource");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void novoDevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var novoForm = new CriarEditarDevForm(null);
                novoForm.FormClosed += (s, e) => { UpdateDevDataSource(); };
                novoForm.ShowDialog();
            }
            catch(Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "novoDevToolStripMenuItem_Click");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void devDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var devGrid = (DataGridView)sender;
                if (devGrid.SelectedRows.Count > 0)
                {
                    var dev = (Dev)((Dev)devGrid.SelectedRows[0].DataBoundItem).Clone();
                    var novoForm = new CriarEditarDevForm(dev);
                    novoForm.FormClosed += (s, e) => { UpdateDevDataSource(); };
                    novoForm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "devDataGridView_DoubleClick");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void squadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var novoForm = new SquadsForm();
                novoForm.ShowDialog();
            }
            catch(Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "squadsToolStripMenuItem_Click");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var novoForm = new LogForm();
                novoForm.ShowDialog();
            }
            catch (Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "operaçõesToolStripMenuItem_Click");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exceçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var novoForm = new ExceptionLogForm();
                novoForm.ShowDialog();
            }
            catch (Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "exceçõesToolStripMenuItem_Click");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}