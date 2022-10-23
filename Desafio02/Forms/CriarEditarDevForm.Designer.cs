namespace Desafio02.Forms
{
    partial class CriarEditarDevForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.devBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeLabel = new System.Windows.Forms.Label();
            this.dadosDevGroupBox = new System.Windows.Forms.GroupBox();
            this.criarEditarButton = new System.Windows.Forms.Button();
            this.previousAvatar = new System.Windows.Forms.Button();
            this.nextAvatar = new System.Windows.Forms.Button();
            this.squadLabel = new System.Windows.Forms.Label();
            this.squadComboBox = new System.Windows.Forms.ComboBox();
            this.squadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataCriacaoLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.devBindingSource)).BeginInit();
            this.dadosDevGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devBindingSource, "Nome", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomeTextBox.Location = new System.Drawing.Point(71, 243);
            this.nomeTextBox.MaxLength = 255;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(392, 23);
            this.nomeTextBox.TabIndex = 0;
            this.nomeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nomeTextBox_Validating);
            this.nomeTextBox.Validated += new System.EventHandler(this.Validated);
            // 
            // devBindingSource
            // 
            this.devBindingSource.DataSource = typeof(Desafio02Library.Dev);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(22, 246);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(43, 15);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            // 
            // dadosDevGroupBox
            // 
            this.dadosDevGroupBox.Controls.Add(this.criarEditarButton);
            this.dadosDevGroupBox.Controls.Add(this.previousAvatar);
            this.dadosDevGroupBox.Controls.Add(this.nextAvatar);
            this.dadosDevGroupBox.Controls.Add(this.squadLabel);
            this.dadosDevGroupBox.Controls.Add(this.squadComboBox);
            this.dadosDevGroupBox.Controls.Add(this.dataCriacaoLabel);
            this.dadosDevGroupBox.Controls.Add(this.emailTextBox);
            this.dadosDevGroupBox.Controls.Add(this.emailLabel);
            this.dadosDevGroupBox.Controls.Add(this.loginTextBox);
            this.dadosDevGroupBox.Controls.Add(this.loginLabel);
            this.dadosDevGroupBox.Controls.Add(this.avatarPictureBox);
            this.dadosDevGroupBox.Controls.Add(this.nomeLabel);
            this.dadosDevGroupBox.Controls.Add(this.nomeTextBox);
            this.dadosDevGroupBox.Location = new System.Drawing.Point(12, 12);
            this.dadosDevGroupBox.Name = "dadosDevGroupBox";
            this.dadosDevGroupBox.Size = new System.Drawing.Size(494, 536);
            this.dadosDevGroupBox.TabIndex = 2;
            this.dadosDevGroupBox.TabStop = false;
            this.dadosDevGroupBox.Text = "Dados do Dev";
            // 
            // criarEditarButton
            // 
            this.criarEditarButton.Location = new System.Drawing.Point(212, 507);
            this.criarEditarButton.Name = "criarEditarButton";
            this.criarEditarButton.Size = new System.Drawing.Size(75, 23);
            this.criarEditarButton.TabIndex = 3;
            this.criarEditarButton.Text = "Adicionar";
            this.criarEditarButton.UseVisualStyleBackColor = true;
            this.criarEditarButton.Click += new System.EventHandler(this.criarEditarButton_Click);
            // 
            // previousAvatar
            // 
            this.previousAvatar.CausesValidation = false;
            this.previousAvatar.Location = new System.Drawing.Point(135, 95);
            this.previousAvatar.Name = "previousAvatar";
            this.previousAvatar.Size = new System.Drawing.Size(32, 24);
            this.previousAvatar.TabIndex = 15;
            this.previousAvatar.Text = "<";
            this.previousAvatar.UseVisualStyleBackColor = true;
            this.previousAvatar.Click += new System.EventHandler(this.previousAvatar_Click);
            // 
            // nextAvatar
            // 
            this.nextAvatar.CausesValidation = false;
            this.nextAvatar.Location = new System.Drawing.Point(342, 95);
            this.nextAvatar.Name = "nextAvatar";
            this.nextAvatar.Size = new System.Drawing.Size(32, 24);
            this.nextAvatar.TabIndex = 13;
            this.nextAvatar.Text = ">";
            this.nextAvatar.UseVisualStyleBackColor = true;
            this.nextAvatar.Click += new System.EventHandler(this.nextAvatar_Click);
            // 
            // squadLabel
            // 
            this.squadLabel.AutoSize = true;
            this.squadLabel.Location = new System.Drawing.Point(22, 332);
            this.squadLabel.Name = "squadLabel";
            this.squadLabel.Size = new System.Drawing.Size(43, 15);
            this.squadLabel.TabIndex = 12;
            this.squadLabel.Text = "Squad:";
            // 
            // squadComboBox
            // 
            this.squadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.devBindingSource, "Squad", true));
            this.squadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devBindingSource, "Squad", true));
            this.squadComboBox.DataSource = this.squadBindingSource;
            this.squadComboBox.DisplayMember = "Nome";
            this.squadComboBox.FormattingEnabled = true;
            this.squadComboBox.Location = new System.Drawing.Point(71, 329);
            this.squadComboBox.Name = "squadComboBox";
            this.squadComboBox.Size = new System.Drawing.Size(179, 23);
            this.squadComboBox.TabIndex = 11;
            this.squadComboBox.ValueMember = "Nome";
            this.squadComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.squadComboBox_Validating);
            this.squadComboBox.Validated += new System.EventHandler(this.Validated);
            // 
            // squadBindingSource
            // 
            this.squadBindingSource.DataSource = typeof(Desafio02Library.Classes.Squad);
            // 
            // dataCriacaoLabel
            // 
            this.dataCriacaoLabel.AutoSize = true;
            this.dataCriacaoLabel.Location = new System.Drawing.Point(157, 225);
            this.dataCriacaoLabel.Name = "dataCriacaoLabel";
            this.dataCriacaoLabel.Size = new System.Drawing.Size(93, 15);
            this.dataCriacaoLabel.TabIndex = 8;
            this.dataCriacaoLabel.Text = "Data de Criação:";
            this.dataCriacaoLabel.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.emailTextBox.Location = new System.Drawing.Point(71, 300);
            this.emailTextBox.MaxLength = 320;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(392, 23);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            this.emailTextBox.Validated += new System.EventHandler(this.Validated);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(26, 303);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 15);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devBindingSource, "Login", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.loginTextBox.Location = new System.Drawing.Point(71, 271);
            this.loginTextBox.MaxLength = 50;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(392, 23);
            this.loginTextBox.TabIndex = 5;
            this.loginTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.loginTextBox_Validating);
            this.loginTextBox.Validated += new System.EventHandler(this.Validated);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(25, 274);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(40, 15);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login:";
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.avatarPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.devBindingSource, "Avatar", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.avatarPictureBox.Location = new System.Drawing.Point(173, 22);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(163, 152);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.avatarPictureBox.TabIndex = 2;
            this.avatarPictureBox.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CriarEditarDevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 560);
            this.Controls.Add(this.dadosDevGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CriarEditarDevForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.devBindingSource)).EndInit();
            this.dadosDevGroupBox.ResumeLayout(false);
            this.dadosDevGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox nomeTextBox;
        private Label nomeLabel;
        private GroupBox dadosDevGroupBox;
        private PictureBox avatarPictureBox;
        private Label dataCriacaoLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox loginTextBox;
        private Label loginLabel;
        private Label squadLabel;
        private ComboBox squadComboBox;
        private BindingSource devBindingSource;
        private Button previousAvatar;
        private Button nextAvatar;
        private ErrorProvider errorProvider;
        private BindingSource squadBindingSource;
        private Button criarEditarButton;
    }
}