using Cseresznye.Data;
using Cseresznye.Models;
using Cseresznye.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdatbazisRuntime
{
    public partial class NewUserForm : Form
    {
        public Ugyfel ujugyfel;
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ujugyfel = new Ugyfel()
            {
                Nev = nevTextBox.Text,
                Email = emailTextBox.Text,
                Telefonszam = telTextBox.Text,
                LakcimId = Convert.ToInt32(lakcimIDTextBox.Text)
            };
        }
    }
}
