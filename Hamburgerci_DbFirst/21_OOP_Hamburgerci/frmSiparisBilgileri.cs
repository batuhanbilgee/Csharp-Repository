using _21_OOP_Hamburgerci.Helpers;
using _21_OOP_Hamburgerci.Models;
using _21_OOP_Hamburgerci.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _21_OOP_Hamburgerci
{
    public partial class frmSiparisBilgileri : Form
    {
        public frmSiparisBilgileri()
        {
            InitializeComponent();
        }

        DataContext db = new DataContext();
        private void frmSiparisBilgileri_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal extraMalzemeGeliri = 0;
            int satisAdeti = 0;
            int siparisAdeti = 0;

            var data = db.Siparisler.Select(x => new SiparisModel()
            {
                Id = x.Id,
                Boyutu = x.Boyutu,
                Menu = x.Menu,
                ToplamTutar = x.ToplamTutar,
                UrunAdeti = x.UrunAdeti
            }).ToList();

            List<ExtraModel> emd = new List<ExtraModel>();
            var result = from x in db.siparisToExtras
                         group x by x.ExtraMalzemeId into sipex
                         select new ExtraModel()
                         {
                            Id= sipex.Key,
                            Fiyat = sipex.Sum(x=>x.ExtraMalzeme.EkstraMalzemeFiyati)                          
                         };
            emd.AddRange(result.ToList());

            foreach (var item in emd)
            {
                extraMalzemeGeliri += item.Fiyat;
            }

            foreach (var item in data)
            {
                ciro += item.ToplamTutar;
                satisAdeti += item.UrunAdeti;
                siparisAdeti++;
                lstSiparisler.Items.Add(item);
            }
   
            lblToplamSiparisAdeti.Text = siparisAdeti.ToString(); 
            lblCiro.Text = ciro.ToString("C2");
            lblExtra.Text = extraMalzemeGeliri.ToString("C2");
            lblSatilanUrunAdeti.Text = satisAdeti.ToString();
         

        }
    }
}
