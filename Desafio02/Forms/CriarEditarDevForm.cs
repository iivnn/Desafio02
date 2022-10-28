using Desafio02Library;
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
    public partial class CriarEditarDevForm : Form
    {
        private Dev _dev;
        private int _selectedAvatarIndex = 1;

        public CriarEditarDevForm(Dev dev)
        {
            InitializeComponent();
            _dev = dev != null ? dev : new Dev();
            AdjustControls();
        }

        private void AdjustControls()
        {
            try
            {
                devBindingSource.DataSource = _dev;

                this.Text = _dev.Id == 0 ? "Novo Dev" : "Editar Dev";

                dataCriacaoLabel.Visible = _dev.Id > 0;

                if (_dev.Id > 0)
                {
                    dataCriacaoLabel.Text = dataCriacaoLabel.Text + " " + _dev.DataDeCriacao.ToString();
                    criarEditarButton.Text = "Editar";
                }
                else
                {
                    _dev.SetAvatar(_selectedAvatarIndex);
                }

                previousAvatar.Enabled = false;

                squadComboBox.DataSource = SquadController.GetAllSquads();

            }
            catch (Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "AdjustControls");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void nomeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(!_dev.IsNomeValid(out string message))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, message);
            }
        }

        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!_dev.IsLoginValid(out string message))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, message);
            }
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!_dev.IsEmailValid(out string message))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, message);
            }
        }

        private void squadComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (!_dev.IsSquadValid(out string message))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, message);
            }
        }

        private void Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void criarEditarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_dev.IsNomeValid(out string message))
                {
                    errorProvider.SetError(nomeTextBox, message);
                    nomeTextBox.Focus();
                    return;
                }

                if (!_dev.IsLoginValid(out message))
                {
                    errorProvider.SetError(loginTextBox, message);
                    loginTextBox.Focus();
                    return;
                }

                if (!_dev.IsEmailValid(out message))
                {
                    errorProvider.SetError(emailTextBox, message);
                    squadComboBox.Focus();
                    return;
                }

                if (!_dev.IsSquadValid(out message))
                {
                    errorProvider.SetError(squadComboBox, message);
                    emailTextBox.Focus();
                    return;
                }

                if (_dev.Id == null)
                {
                    DevController.AddDev(_dev);
                }
                else
                {
                    DevController.UpdateDev(_dev);
                }
            }
            catch (Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "criarEditarButton_Click");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            this.Close();
        }

        private void previousAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedAvatarIndex--;
                nextAvatar.Enabled = true;
                if (_selectedAvatarIndex == 1)
                {
                    previousAvatar.Enabled = false;
                }
                _dev.SetAvatar(_selectedAvatarIndex);
                avatarPictureBox.ImageLocation = _dev.Avatar;
                avatarPictureBox.Load();
            }
            catch(Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "previousAvatar_Click");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nextAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedAvatarIndex++;
                previousAvatar.Enabled = true;
                if (_selectedAvatarIndex == 500)
                {
                    nextAvatar.Enabled = false;
                }
                _dev.SetAvatar(_selectedAvatarIndex);
                avatarPictureBox.ImageLocation = _dev.Avatar;
                avatarPictureBox.Load();
            }
            catch(Exception ex)
            {
                LogController.Logexception(ex, this.GetType().FullName, "nextAvatar_Click");
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
