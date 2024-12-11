namespace Cseresznye
{
    partial class UgyfelekUC
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
            nevTextBox = new TextBox();
            ugyfelListBox = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            cimComboBox = new ComboBox();
            newUserButton = new Button();
            label1 = new Label();
            saveButton = new Button();
            cimEgybenDTOBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nevTextBox
            // 
            nevTextBox.Location = new Point(12, 14);
            nevTextBox.Name = "nevTextBox";
            nevTextBox.PlaceholderText = "Szűrés...";
            nevTextBox.Size = new Size(175, 23);
            nevTextBox.TabIndex = 0;
            nevTextBox.TextChanged += textBox1_TextChanged;
            // 
            // ugyfelListBox
            // 
            ugyfelListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ugyfelListBox.DataSource = ugyfelBindingSource;
            ugyfelListBox.DisplayMember = "Nev";
            ugyfelListBox.FormattingEnabled = true;
            ugyfelListBox.ItemHeight = 15;
            ugyfelListBox.Location = new Point(12, 43);
            ugyfelListBox.Name = "ugyfelListBox";
            ugyfelListBox.Size = new Size(175, 349);
            ugyfelListBox.TabIndex = 1;
            ugyfelListBox.ValueMember = "UgyfelID";
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // cimComboBox
            // 
            cimComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cimComboBox.DataBindings.Add(new Binding("SelectedValue", ugyfelBindingSource, "Ugyfelid", true, DataSourceUpdateMode.OnPropertyChanged));
            cimComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cimComboBox.FormattingEnabled = true;
            cimComboBox.Location = new Point(193, 61);
            cimComboBox.Name = "cimComboBox";
            cimComboBox.Size = new Size(413, 23);
            cimComboBox.TabIndex = 2;
            // 
            // newUserButton
            // 
            newUserButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            newUserButton.BackColor = Color.Lime;
            newUserButton.Location = new Point(12, 398);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(175, 23);
            newUserButton.TabIndex = 3;
            newUserButton.Text = "Új Ügyfél hozzáadása";
            newUserButton.UseVisualStyleBackColor = false;
            newUserButton.Click += newUserButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 43);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 4;
            label1.Text = "Jelenlegi lakcím:";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveButton.Location = new Point(612, 61);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(102, 23);
            saveButton.TabIndex = 5;
            saveButton.Text = "Mentés";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cimEgybenDTOBindingSource
            // 
            cimEgybenDTOBindingSource.DataSource = typeof(AdatbazisRuntime.CimEgybenDTO);
            // 
            // UgyfelekUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(newUserButton);
            Controls.Add(cimComboBox);
            Controls.Add(ugyfelListBox);
            Controls.Add(nevTextBox);
            Name = "UgyfelekUC";
            Size = new Size(726, 449);
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimEgybenDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nevTextBox;
        private ListBox ugyfelListBox;
        private ComboBox cimComboBox;
        private Button newUserButton;
        private Label label1;
        private BindingSource ugyfelBindingSource;
        private Button saveButton;
        private BindingSource cimEgybenDTOBindingSource;
    }
}
