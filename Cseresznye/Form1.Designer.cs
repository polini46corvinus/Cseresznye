namespace Cseresznye
{
    partial class Form1
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
            termekekButton = new Button();
            ugyfelekButton = new Button();
            rendelesekButton = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // termekekButton
            // 
            termekekButton.Location = new Point(12, 17);
            termekekButton.Name = "termekekButton";
            termekekButton.Size = new Size(75, 23);
            termekekButton.TabIndex = 0;
            termekekButton.Text = "Termékek";
            termekekButton.UseVisualStyleBackColor = true;
            termekekButton.Click += termekekButton_Click;
            // 
            // ugyfelekButton
            // 
            ugyfelekButton.Location = new Point(12, 46);
            ugyfelekButton.Name = "ugyfelekButton";
            ugyfelekButton.Size = new Size(75, 23);
            ugyfelekButton.TabIndex = 1;
            ugyfelekButton.Text = "Ügyfelek";
            ugyfelekButton.UseVisualStyleBackColor = true;
            ugyfelekButton.Click += ugyfelekButton_Click;
            // 
            // rendelesekButton
            // 
            rendelesekButton.Location = new Point(12, 75);
            rendelesekButton.Name = "rendelesekButton";
            rendelesekButton.Size = new Size(75, 23);
            rendelesekButton.TabIndex = 2;
            rendelesekButton.Text = "Rendelések";
            rendelesekButton.UseVisualStyleBackColor = true;
            rendelesekButton.Click += rendelesekButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(102, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 566);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 595);
            Controls.Add(panel1);
            Controls.Add(rendelesekButton);
            Controls.Add(ugyfelekButton);
            Controls.Add(termekekButton);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button termekekButton;
        private Button ugyfelekButton;
        private Button rendelesekButton;
        private Panel panel1;
    }
}