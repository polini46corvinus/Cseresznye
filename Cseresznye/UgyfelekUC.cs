using AdatbazisRuntime;
using Cseresznye.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cseresznye
{
    public partial class UgyfelekUC : UserControl
    {
        AlkatreszDbContext context;
        public UgyfelekUC()
        {
            InitializeComponent();
            context = new AlkatreszDbContext();
            LoadUgyfelek();
        }
        public void LoadUgyfelek()
        {
            var ugyfelek = (from x in context.Ugyfel
                            where x.Nev.Contains(nevTextBox.Text)
                            select x).ToList();
            ugyfelBindingSource.DataSource = ugyfelek;
            if (ugyfelListBox.SelectedItem != null)
            {
                LoadCimek();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }
        public void LoadCimek()
        {
            var cimek = (from x in context.Cim
                         select new CimEgybenDTO
                         {
                             CimID = x.CimId,
                             CimEgyben = $"{x.Orszag} {x.Iranyitoszam} {x.Varos} {x.Utca} {x.Hazszam}"
                         }).ToList();
            cimEgybenDTOBindingSource.DataSource = cimek;
            cimComboBox.DataSource = cimEgybenDTOBindingSource;
            cimComboBox.ValueMember = "CimID";
            cimComboBox.DisplayMember = "CimEgyben";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
                MessageBox.Show("Sikeres mentés!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewUserForm nuf = new NewUserForm();
                if (nuf.ShowDialog() == DialogResult.OK)
                {
                    context.Ugyfel.Add(nuf.ujugyfel);
                    context.SaveChanges();
                    MessageBox.Show("Új Ügyfél hozzáadása sikeres!");
                    LoadUgyfelek();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
