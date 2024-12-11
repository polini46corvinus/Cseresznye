namespace Cseresznye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan kilépsz?", "Ablak bezárása", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void termekekButton_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                TermekekUC termekekUC = new TermekekUC();
                termekekUC.Dock = DockStyle.Fill;
                panel1.Controls.Add(termekekUC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ugyfelekButton_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                UgyfelekUC vevokUC = new UgyfelekUC();
                vevokUC.Dock = DockStyle.Fill;
                panel1.Controls.Add(vevokUC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rendelesekButton_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                RendelesekUC rendelesekUC = new RendelesekUC();
                rendelesekUC.Dock = DockStyle.Fill;
                panel1.Controls.Add(rendelesekUC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}