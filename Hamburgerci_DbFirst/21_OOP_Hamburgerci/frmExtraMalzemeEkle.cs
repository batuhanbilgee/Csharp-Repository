using _21_OOP_Hamburgerci.Helpers;
using _21_OOP_Hamburgerci.ORM.Context;
using _21_OOP_Hamburgerci.ORM.Entity;
using System;
using System.Windows.Forms;

namespace _21_OOP_Hamburgerci
{
    public partial class frmExtraMalzemeEkle : Form
    {
        public frmExtraMalzemeEkle()
        {
            InitializeComponent();
        }
        ExtraMalzeme extraMalzeme = new ExtraMalzeme();
        DataContext db = new DataContext();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
           

            if (!string.IsNullOrEmpty(txtAdi.Text)&& nmFiyat.Value !=0)
            {
                extraMalzeme.EkstraMalzemeAdi = txtAdi.Text;
                extraMalzeme.EkstraMalzemeFiyati = nmFiyat.Value;
                db.ExtraMalzemes.Add(extraMalzeme);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarılı");
                Tools.Clean(this.Controls);
            }
            else
            {
                MessageBox.Show("Lütfen ÜrünAdı Veya Fiyatı Kontrol Ediniz... ");
            }

        }
    }
}
