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
    public partial class RendelesekUC : UserControl
    {
        AlkatreszDbContext context;
        public RendelesekUC()
        {
            InitializeComponent();
            context = new AlkatreszDbContext();
            LoadRendelesek();
        }
        private void LoadRendelesek()
        {
            var rendelesek = (from x in context.Rendeles
                              where Convert.ToString(x.RendelesId).Contains(rendelesTextBox.Text)
                              select x).ToList();
            if (rendelesek != null)
            {
                rendelesBindingSource.DataSource = rendelesek;
                LoadRendelesTetelek();
            }
        }

        private void rendelesTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadRendelesek();
        }
        private void LoadRendelesTetelek()
        {
            if (rendelesBindingSource.Current != null)
            {
                var currentitem = (Rendeles)rendelesBindingSource.Current;
                var rt = (from x in context.RendelesTetel
                          where x.RendelesId == currentitem.RendelesId
                          select new RendelesTetelDTO
                          {
                              TermekID = x.TermekId,
                              Mennyiseg = x.Mennyiseg,
                              EgysegAr = x.EgysegAr,
                              Afa = x.Afa,
                              Megrendelo = x.Rendeles.Ugyfel.Nev,
                              CimID = x.Rendeles.SzallitasiCimId
                          }).ToList();
                if (rt != null)
                {
                    rendelesTetelDTOBindingSource.DataSource = rt;
                }
            }
        }

        private void rendelesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesTetelek();
        }
    }
}
