namespace Desafio02
{
    partial class PrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.devDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateDevDataGridViewDataTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoDevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.devDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // devDataGridView
            // 
            this.devDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.devDataGridView.AllowUserToAddRows = false;
            this.devDataGridView.AllowUserToDeleteRows = false;
            this.devDataGridView.AllowUserToOrderColumns = true;
            this.devDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devDataGridView.AutoGenerateColumns = false;
            this.devDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devDataGridView.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.devDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.devDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.squadDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataDeCriacaoDataGridViewTextBoxColumn});
            this.devDataGridView.DataSource = this.devBindingSource;
            this.devDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.devDataGridView.Location = new System.Drawing.Point(12, 40);
            this.devDataGridView.MultiSelect = false;
            this.devDataGridView.Name = "devDataGridView";
            this.devDataGridView.ReadOnly = true;
            this.devDataGridView.RowTemplate.Height = 25;
            this.devDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devDataGridView.Size = new System.Drawing.Size(1037, 592);
            this.devDataGridView.TabIndex = 0;
            this.devDataGridView.DoubleClick += new System.EventHandler(this.devDataGridView_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // squadDataGridViewTextBoxColumn
            // 
            this.squadDataGridViewTextBoxColumn.DataPropertyName = "Squad";
            this.squadDataGridViewTextBoxColumn.HeaderText = "Squad";
            this.squadDataGridViewTextBoxColumn.Name = "squadDataGridViewTextBoxColumn";
            this.squadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDeCriacaoDataGridViewTextBoxColumn
            // 
            this.dataDeCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataDeCriacao";
            this.dataDeCriacaoDataGridViewTextBoxColumn.HeaderText = "Data de Criação";
            this.dataDeCriacaoDataGridViewTextBoxColumn.Name = "dataDeCriacaoDataGridViewTextBoxColumn";
            this.dataDeCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devBindingSource
            // 
            this.devBindingSource.DataSource = typeof(Desafio02Library.Dev);
            // 
            // updateDevDataGridViewDataTimer
            // 
            this.updateDevDataGridViewDataTimer.Enabled = true;
            this.updateDevDataGridViewDataTimer.Interval = 20000;
            this.updateDevDataGridViewDataTimer.Tick += new System.EventHandler(this.updateDevDataGridViewDataTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoDevToolStripMenuItem,
            this.squadsToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.arquivoToolStripMenuItem.Text = "Dev";
            // 
            // novoDevToolStripMenuItem
            // 
            this.novoDevToolStripMenuItem.Name = "novoDevToolStripMenuItem";
            this.novoDevToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.novoDevToolStripMenuItem.Text = "Novo";
            this.novoDevToolStripMenuItem.Click += new System.EventHandler(this.novoDevToolStripMenuItem_Click);
            // 
            // squadsToolStripMenuItem
            // 
            this.squadsToolStripMenuItem.Name = "squadsToolStripMenuItem";
            this.squadsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.squadsToolStripMenuItem.Text = "Squads";
            this.squadsToolStripMenuItem.Click += new System.EventHandler(this.squadsToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem,
            this.exceçõesToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.sobreToolStripMenuItem.Text = "Logs";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            this.operaçõesToolStripMenuItem.Click += new System.EventHandler(this.operaçõesToolStripMenuItem_Click);
            // 
            // exceçõesToolStripMenuItem
            // 
            this.exceçõesToolStripMenuItem.Name = "exceçõesToolStripMenuItem";
            this.exceçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exceçõesToolStripMenuItem.Text = "Exceções";
            this.exceçõesToolStripMenuItem.Click += new System.EventHandler(this.exceçõesToolStripMenuItem_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 644);
            this.Controls.Add(this.devDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.Text = "Cadastro de Dev";
            ((System.ComponentModel.ISupportInitialize)(this.devDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView devDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn squadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeCriacaoDataGridViewTextBoxColumn;
        private BindingSource devBindingSource;
        private System.Windows.Forms.Timer updateDevDataGridViewDataTimer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoDevToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem squadsToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem exceçõesToolStripMenuItem;
    }
}