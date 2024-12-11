namespace Cseresznye
{
    partial class UjTermekForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            nevTextBox = new TextBox();
            termekBindingSource = new BindingSource(components);
            leirasTextBox = new TextBox();
            arTextBox = new TextBox();
            keszletTextBox = new TextBox();
            kategoriaComboBox = new ComboBox();
            termekKategoriaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekKategoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(176, 19);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Új termék hozzáadása";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Név";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Leírás";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 244);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Aktuális ár";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 299);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Készlet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 365);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 5;
            label6.Text = "Kategória";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(346, 454);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Mégse";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(427, 454);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // nevTextBox
            // 
            nevTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nevTextBox.DataBindings.Add(new Binding("Text", termekBindingSource, "Nev", true));
            nevTextBox.Location = new Point(12, 86);
            nevTextBox.Name = "nevTextBox";
            nevTextBox.Size = new Size(490, 23);
            nevTextBox.TabIndex = 8;
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // leirasTextBox
            // 
            leirasTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            leirasTextBox.DataBindings.Add(new Binding("Text", termekBindingSource, "Leiras", true));
            leirasTextBox.Location = new Point(12, 138);
            leirasTextBox.Multiline = true;
            leirasTextBox.Name = "leirasTextBox";
            leirasTextBox.Size = new Size(490, 91);
            leirasTextBox.TabIndex = 9;
            // 
            // arTextBox
            // 
            arTextBox.DataBindings.Add(new Binding("Text", termekBindingSource, "AktualisAr", true));
            arTextBox.Location = new Point(12, 262);
            arTextBox.Name = "arTextBox";
            arTextBox.Size = new Size(100, 23);
            arTextBox.TabIndex = 10;
            // 
            // keszletTextBox
            // 
            keszletTextBox.DataBindings.Add(new Binding("Text", termekBindingSource, "Keszlet", true));
            keszletTextBox.Location = new Point(12, 317);
            keszletTextBox.Name = "keszletTextBox";
            keszletTextBox.Size = new Size(100, 23);
            keszletTextBox.TabIndex = 11;
            // 
            // kategoriaComboBox
            // 
            kategoriaComboBox.DataSource = termekKategoriaBindingSource;
            kategoriaComboBox.DisplayMember = "Nev";
            kategoriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kategoriaComboBox.FormattingEnabled = true;
            kategoriaComboBox.Location = new Point(12, 383);
            kategoriaComboBox.Name = "kategoriaComboBox";
            kategoriaComboBox.Size = new Size(226, 23);
            kategoriaComboBox.TabIndex = 12;
            kategoriaComboBox.ValueMember = "KategoriaID";
            // 
            // termekKategoriaBindingSource
            // 
            termekKategoriaBindingSource.DataSource = typeof(Models.TermekKategoria);
            // 
            // UjTermekForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 493);
            Controls.Add(kategoriaComboBox);
            Controls.Add(keszletTextBox);
            Controls.Add(arTextBox);
            Controls.Add(leirasTextBox);
            Controls.Add(nevTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UjTermekForm";
            Text = "UjTermekForm";
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekKategoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox nevTextBox;
        private TextBox leirasTextBox;
        private TextBox arTextBox;
        private TextBox keszletTextBox;
        private ComboBox kategoriaComboBox;
        private BindingSource termekBindingSource;
        private BindingSource termekKategoriaBindingSource;
    }
}