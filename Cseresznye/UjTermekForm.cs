using Cseresznye.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cseresznye
{
    public partial class UjTermekForm : Form
    {
        AlkatreszDbContext context;
        public Termek ujtermek;
        public UjTermekForm(Termek termek)
        {
            InitializeComponent();
            context = new AlkatreszDbContext();
            var kategoriak = (from x in context.TermekKategoria
                              select x).ToList();
            termekBindingSource.DataSource = termek;
            termekKategoriaBindingSource.DataSource = kategoriak;
        }
        public UjTermekForm()
        {
            InitializeComponent();
            context = new AlkatreszDbContext();
            var kategoriak = (from x in context.TermekKategoria
                              select x).ToList();
            termekKategoriaBindingSource.DataSource = kategoriak;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ujtermek = new Termek();
            ujtermek.Nev = nevTextBox.Text;
            ujtermek.Leiras = leirasTextBox.Text;
            ujtermek.AktualisAr = Convert.ToDecimal(arTextBox.Text);
            ujtermek.Keszlet = Convert.ToInt32(keszletTextBox.Text);
            ujtermek.KategoriaId = Convert.ToInt32(kategoriaComboBox.SelectedValue);
        }
    }
}
