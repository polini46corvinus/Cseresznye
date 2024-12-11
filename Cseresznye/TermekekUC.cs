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

namespace Cseresznye
{
    public partial class TermekekUC : UserControl
    {
        AlkatreszDbContext context;
        public TermekekUC()
        {
            InitializeComponent();
            context = new AlkatreszDbContext();
            LoadTermekek();
        }

        private void LoadTermekek()
        {
            var termekek = (from x in context.Termek
                            select x).ToList();
            termekBindingSource.DataSource = termekek;
            dataGridView1.DataSource = termekBindingSource;

            var kat = (from x in context.TermekKategoria
                       select x).ToList();
            termekKategoriaBindingSource.DataSource = kat;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                UjTermekForm utc = new UjTermekForm();
                if (utc.ShowDialog() == DialogResult.OK)
                {
                    context.Termek.Add(utc.ujtermek);
                    context.SaveChanges();
                    LoadTermekek();
                };
            }
            catch (Exception ex)
            {
                throw;
                MessageBox.Show(ex.Message);
            }
        }
        private void szerkesztesButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                UjTermekForm utc = new UjTermekForm((Termek)dataGridView1.SelectedRows[0].DataBoundItem);
                if (utc.ShowDialog() == DialogResult.OK)
                {
                    context.SaveChanges();
                    LoadTermekek();
                }
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                if (MessageBox.Show("Biztosan törlöd?", "Termék törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var elem = (Termek)dataGridView1.SelectedRows[0].DataBoundItem;
                    var torlendo = (from x in context.Termek
                                    where x.TermekId == elem.TermekId
                                    select x).FirstOrDefault();
                    context.Termek.Remove(torlendo);
                    context.SaveChanges();
                    LoadTermekek();
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            context.SaveChanges();
        }
    }
}
