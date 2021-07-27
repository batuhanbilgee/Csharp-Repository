using _21_OOP_Hamburgerci.Helpers;
using _21_OOP_Hamburgerci.ORM.Context;
using _21_OOP_Hamburgerci.ORM.Entity;
using System;
using System.Windows.Forms;

namespace _21_OOP_Hamburgerci
{
    public partial class frmHamburgerEkle : Form
    {
        public frmHamburgerEkle()
        {
            InitializeComponent();
        }
       Menuler menuler = new Menuler();
        DataContext db = new DataContext();


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMenuAdi.Text) && nmFiyat.Value != 0)
            {
                menuler.MenuAdi = txtMenuAdi.Text;
                menuler.MenuFiyati = nmFiyat.Value;
                db.Menus.Add(menuler);
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
