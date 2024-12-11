namespace Cseresznye
{
    partial class RendelesekUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            rendelesTextBox = new TextBox();
            rendelesListBox = new ListBox();
            rendelesBindingSource = new BindingSource(components);
            rendelesekDGV = new DataGridView();
            termekIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egysegArDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            afaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            megrendeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cimIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendelesTetelDTOBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesekDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // rendelesTextBox
            // 
            rendelesTextBox.Location = new Point(12, 16);
            rendelesTextBox.Name = "rendelesTextBox";
            rendelesTextBox.PlaceholderText = "Rendelés száma...";
            rendelesTextBox.Size = new Size(132, 23);
            rendelesTextBox.TabIndex = 0;
            rendelesTextBox.TextChanged += rendelesTextBox_TextChanged;
            // 
            // rendelesListBox
            // 
            rendelesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rendelesListBox.DataSource = rendelesBindingSource;
            rendelesListBox.DisplayMember = "RendelesID";
            rendelesListBox.FormattingEnabled = true;
            rendelesListBox.ItemHeight = 15;
            rendelesListBox.Location = new Point(12, 45);
            rendelesListBox.Name = "rendelesListBox";
            rendelesListBox.Size = new Size(132, 409);
            rendelesListBox.TabIndex = 1;
            rendelesListBox.ValueMember = "RendelesID";
            rendelesListBox.SelectedIndexChanged += rendelesListBox_SelectedIndexChanged;
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // rendelesekDGV
            // 
            rendelesekDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rendelesekDGV.AutoGenerateColumns = false;
            rendelesekDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rendelesekDGV.Columns.AddRange(new DataGridViewColumn[] { termekIDDataGridViewTextBoxColumn, mennyisegDataGridViewTextBoxColumn, egysegArDataGridViewTextBoxColumn, afaDataGridViewTextBoxColumn, megrendeloDataGridViewTextBoxColumn, cimIDDataGridViewTextBoxColumn });
            rendelesekDGV.DataSource = rendelesTetelDTOBindingSource;
            rendelesekDGV.Location = new Point(150, 45);
            rendelesekDGV.Name = "rendelesekDGV";
            rendelesekDGV.RowTemplate.Height = 25;
            rendelesekDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rendelesekDGV.Size = new Size(606, 409);
            rendelesekDGV.TabIndex = 2;
            // 
            // termekIDDataGridViewTextBoxColumn
            // 
            termekIDDataGridViewTextBoxColumn.DataPropertyName = "TermekID";
            termekIDDataGridViewTextBoxColumn.HeaderText = "TermekID";
            termekIDDataGridViewTextBoxColumn.Name = "termekIDDataGridViewTextBoxColumn";
            // 
            // mennyisegDataGridViewTextBoxColumn
            // 
            mennyisegDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg";
            mennyisegDataGridViewTextBoxColumn.HeaderText = "Mennyiseg";
            mennyisegDataGridViewTextBoxColumn.Name = "mennyisegDataGridViewTextBoxColumn";
            // 
            // egysegArDataGridViewTextBoxColumn
            // 
            egysegArDataGridViewTextBoxColumn.DataPropertyName = "EgysegAr";
            egysegArDataGridViewTextBoxColumn.HeaderText = "EgysegAr";
            egysegArDataGridViewTextBoxColumn.Name = "egysegArDataGridViewTextBoxColumn";
            // 
            // afaDataGridViewTextBoxColumn
            // 
            afaDataGridViewTextBoxColumn.DataPropertyName = "Afa";
            afaDataGridViewTextBoxColumn.HeaderText = "Afa";
            afaDataGridViewTextBoxColumn.Name = "afaDataGridViewTextBoxColumn";
            // 
            // megrendeloDataGridViewTextBoxColumn
            // 
            megrendeloDataGridViewTextBoxColumn.DataPropertyName = "Megrendelo";
            megrendeloDataGridViewTextBoxColumn.HeaderText = "Megrendelo";
            megrendeloDataGridViewTextBoxColumn.Name = "megrendeloDataGridViewTextBoxColumn";
            // 
            // cimIDDataGridViewTextBoxColumn
            // 
            cimIDDataGridViewTextBoxColumn.DataPropertyName = "CimID";
            cimIDDataGridViewTextBoxColumn.HeaderText = "CimID";
            cimIDDataGridViewTextBoxColumn.Name = "cimIDDataGridViewTextBoxColumn";
            // 
            // rendelesTetelDTOBindingSource
            // 
            rendelesTetelDTOBindingSource.DataSource = typeof(RendelesTetelDTO);
            // 
            // RendelesekUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(rendelesekDGV);
            Controls.Add(rendelesListBox);
            Controls.Add(rendelesTextBox);
            Name = "RendelesekUC";
            Size = new Size(769, 465);
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesekDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox rendelesTextBox;
        private ListBox rendelesListBox;
        private DataGridView rendelesekDGV;
        private DataGridViewTextBoxColumn termekIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegArDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn afaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn megrendeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cimIDDataGridViewTextBoxColumn;
        private BindingSource rendelesTetelDTOBindingSource;
        private BindingSource rendelesBindingSource;
    }
}
