namespace AdatbazisRuntime
{
    partial class NewUserForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            okButton = new Button();
            cancelButton = new Button();
            nevTextBox = new TextBox();
            emailTextBox = new TextBox();
            telTextBox = new TextBox();
            lakcimIDTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Új Ügyfél hozzáadása";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 53);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Név:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 104);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 155);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefonszám:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 206);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 4;
            label5.Text = "Lakcím ID:";
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(309, 252);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 5;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(225, 252);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Mégse";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // nevTextBox
            // 
            nevTextBox.Location = new Point(27, 71);
            nevTextBox.Name = "nevTextBox";
            nevTextBox.Size = new Size(357, 23);
            nevTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(27, 122);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(357, 23);
            emailTextBox.TabIndex = 8;
            // 
            // telTextBox
            // 
            telTextBox.Location = new Point(27, 173);
            telTextBox.Name = "telTextBox";
            telTextBox.Size = new Size(161, 23);
            telTextBox.TabIndex = 9;
            // 
            // lakcimIDTextBox
            // 
            lakcimIDTextBox.Location = new Point(27, 224);
            lakcimIDTextBox.Name = "lakcimIDTextBox";
            lakcimIDTextBox.Size = new Size(161, 23);
            lakcimIDTextBox.TabIndex = 10;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 287);
            Controls.Add(lakcimIDTextBox);
            Controls.Add(telTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nevTextBox);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "NewUserForm";
            Text = "NewUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button okButton;
        private Button cancelButton;
        private TextBox nevTextBox;
        private TextBox emailTextBox;
        private TextBox telTextBox;
        private TextBox lakcimIDTextBox;
    }
}