using _21_OOP_Hamburgerci.Helpers;
using _21_OOP_Hamburgerci.ORM.Context;
using _21_OOP_Hamburgerci.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _21_OOP_Hamburgerci
{
   
    public partial class frmSiparisOlustur : Form
    {
        public frmSiparisOlustur()
        {
            InitializeComponent();
        }       
        DataContext db = new DataContext();
        private void frmSiparisOlustur_Load(object sender, EventArgs e)
        {
           

            foreach (var item in db.ExtraMalzemes)
            {
                flpExtraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraMalzemeAdi, Tag = item });
            }

            foreach (var item in db.Menus)
            {
                cmbMenuler.Items.Add(item);
                cmbMenuler.DisplayMember = "MenuAdi";
            }
            btnSiparisTamamla.Enabled = false;
           
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (cmbMenuler.SelectedItem != null)
            {
                SiparisModel yeniSiparis = new SiparisModel();
                yeniSiparis.Menu = (Menuler)cmbMenuler.SelectedItem;

                if (rbKucuk.Checked)
                {
                    yeniSiparis.Boyutu = Enums.Boyut.Küçük;
                }
                else if (rbNormal.Checked)
                {
                    yeniSiparis.Boyutu = Enums.Boyut.Normal;
                }
                else
                {
                    yeniSiparis.Boyutu = Enums.Boyut.Büyük;
                }

                foreach (CheckBox item in flpExtraMalzemeler.Controls)
                {
                    if (item.Checked)
                    {
                        yeniSiparis.ExtraMalzemes.Add((ExtraMalzeme)item.Tag);
                    }
                }
                yeniSiparis.UrunAdeti = (int)nmAdet.Value;
                yeniSiparis.Hesapla();
                lstSiparisler.Items.Add(yeniSiparis);
                TutarHesapla();
                Tools.Clean(this.Controls);
                btnSiparisTamamla.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen Menü Seçiniz...");
            }
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                SiparisModel gelenSiparis = lstSiparisler.Items[i] as SiparisModel;
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Toplam Sipariş Ücreti:{TutarHesapla().ToString("C2")},Satın Almayı Tamamlamak İstermisiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            foreach (SiparisModel item in lstSiparisler.Items)
            {

                if (dr == DialogResult.Yes)
                {
                    TutarHesapla();
                    var siparis = new Siparis()
                    {
                        MenuId = item.Menu.Id,                        
                        Boyutu = item.Boyutu,
                        UrunAdeti = item.UrunAdeti,
                        ToplamTutar = item.ToplamTutar
                    };
                    db.Siparisler.Add(siparis);

                    List<SiparisToExtraMalzeme> ste = new List<SiparisToExtraMalzeme>();

                    foreach (var extra in item.ExtraMalzemes)
                    {
                        var siparisToExtra = new SiparisToExtraMalzeme()
                        {
                            SiparisId = siparis.Id,
                            ExtraMalzemeId = extra.Id
                        };
                        ste.Add(siparisToExtra);
                    }
                    db.siparisToExtras.AddRange(ste);
                    db.SaveChanges();
                   
                }
            }
            Tools.Clean(this.Controls);
            lstSiparisler.Items.Clear();
            lblToplamTutar.Text = "0.00 TL";
            MessageBox.Show("Sipariş Tamamlandı!...");
        }
    }
}
