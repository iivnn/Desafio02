namespace Desafio02.Forms
{
    partial class SquadsForm
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
            this.squadsGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.squadDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.squadsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // squadsGroupBox
            // 
            this.squadsGroupBox.Controls.Add(this.addButton);
            this.squadsGroupBox.Controls.Add(this.nomeTextBox);
            this.squadsGroupBox.Controls.Add(this.nomeLabel);
            this.squadsGroupBox.Controls.Add(this.squadDataGridView);
            this.squadsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.squadsGroupBox.Name = "squadsGroupBox";
            this.squadsGroupBox.Size = new System.Drawing.Size(494, 536);
            this.squadsGroupBox.TabIndex = 2;
            this.squadsGroupBox.TabStop = false;
            this.squadsGroupBox.Text = "Squads";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(248, 16);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Adicionar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(55, 16);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(187, 23);
            this.nomeTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(6, 19);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(43, 15);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            // 
            // squadDataGridView
            // 
            this.squadDataGridView.AllowUserToAddRows = false;
            this.squadDataGridView.AllowUserToOrderColumns = true;
            this.squadDataGridView.AutoGenerateColumns = false;
            this.squadDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.squadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.squadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.squadDataGridView.DataSource = this.squadBindingSource;
            this.squadDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.squadDataGridView.Location = new System.Drawing.Point(6, 45);
            this.squadDataGridView.MultiSelect = false;
            this.squadDataGridView.Name = "squadDataGridView";
            this.squadDataGridView.ReadOnly = true;
            this.squadDataGridView.RowTemplate.Height = 25;
            this.squadDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.squadDataGridView.Size = new System.Drawing.Size(482, 485);
            this.squadDataGridView.TabIndex = 0;
            this.squadDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.squadDataGridView_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // squadBindingSource
            // 
            this.squadBindingSource.DataSource = typeof(Desafio02Library.Classes.Squad);
            // 
            // SquadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 560);
            this.Controls.Add(this.squadsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SquadsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.squadsGroupBox.ResumeLayout(false);
            this.squadsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox squadsGroupBox;
        private DataGridView squadDataGridView;
        private BindingSource squadBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private Button addButton;
        private TextBox nomeTextBox;
        private Label nomeLabel;
    }
}