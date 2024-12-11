namespace Cseresznye
{
    partial class TermekekUC
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
            dataGridView1 = new DataGridView();
            termekBindingSource = new BindingSource(components);
            termekKategoriaBindingSource = new BindingSource(components);
            addButton = new Button();
            szerkesztesButton = new Button();
            delButton = new Button();
            termekIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            leirasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aktualisArDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            keszletDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            KategoriaNév = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekKategoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { termekIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, leirasDataGridViewTextBoxColumn, aktualisArDataGridViewTextBoxColumn, keszletDataGridViewTextBoxColumn, KategoriaNév });
            dataGridView1.DataSource = termekBindingSource;
            dataGridView1.Location = new Point(15, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(601, 311);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // termekKategoriaBindingSource
            // 
            termekKategoriaBindingSource.DataSource = typeof(Models.TermekKategoria);
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(15, 334);
            addButton.Name = "addButton";
            addButton.Size = new Size(155, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Új termék hozzáadása";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // szerkesztesButton
            // 
            szerkesztesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            szerkesztesButton.Location = new Point(176, 334);
            szerkesztesButton.Name = "szerkesztesButton";
            szerkesztesButton.Size = new Size(155, 23);
            szerkesztesButton.TabIndex = 2;
            szerkesztesButton.Text = "Termék szerkesztése";
            szerkesztesButton.UseVisualStyleBackColor = true;
            szerkesztesButton.Click += szerkesztesButton_Click;
            // 
            // delButton
            // 
            delButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            delButton.BackColor = Color.Crimson;
            delButton.Location = new Point(490, 334);
            delButton.Name = "delButton";
            delButton.Size = new Size(126, 23);
            delButton.TabIndex = 3;
            delButton.Text = "Termék törlése";
            delButton.UseVisualStyleBackColor = false;
            delButton.Click += delButton_Click;
            // 
            // termekIdDataGridViewTextBoxColumn
            // 
            termekIdDataGridViewTextBoxColumn.DataPropertyName = "TermekId";
            termekIdDataGridViewTextBoxColumn.HeaderText = "TermekId";
            termekIdDataGridViewTextBoxColumn.Name = "termekIdDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // leirasDataGridViewTextBoxColumn
            // 
            leirasDataGridViewTextBoxColumn.DataPropertyName = "Leiras";
            leirasDataGridViewTextBoxColumn.HeaderText = "Leiras";
            leirasDataGridViewTextBoxColumn.Name = "leirasDataGridViewTextBoxColumn";
            // 
            // aktualisArDataGridViewTextBoxColumn
            // 
            aktualisArDataGridViewTextBoxColumn.DataPropertyName = "AktualisAr";
            aktualisArDataGridViewTextBoxColumn.HeaderText = "AktualisAr";
            aktualisArDataGridViewTextBoxColumn.Name = "aktualisArDataGridViewTextBoxColumn";
            // 
            // keszletDataGridViewTextBoxColumn
            // 
            keszletDataGridViewTextBoxColumn.DataPropertyName = "Keszlet";
            keszletDataGridViewTextBoxColumn.HeaderText = "Keszlet";
            keszletDataGridViewTextBoxColumn.Name = "keszletDataGridViewTextBoxColumn";
            // 
            // KategoriaNév
            // 
            KategoriaNév.DataPropertyName = "KategoriaId";
            KategoriaNév.DataSource = termekKategoriaBindingSource;
            KategoriaNév.DisplayMember = "Nev";
            KategoriaNév.HeaderText = "KategoriaId";
            KategoriaNév.Name = "KategoriaNév";
            KategoriaNév.ValueMember = "KategoriaId";
            // 
            // TermekekUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            Controls.Add(delButton);
            Controls.Add(szerkesztesButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Name = "TermekekUC";
            Size = new Size(635, 373);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekKategoriaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addButton;
        private Button szerkesztesButton;
        private Button delButton;
        private BindingSource termekBindingSource;
        private BindingSource termekKategoriaBindingSource;
        private DataGridViewTextBoxColumn termekIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn leirasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aktualisArDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn keszletDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn KategoriaNév;
    }
}
