
namespace _21_OOP_Hamburgerci
{
    partial class FrmMainMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparisYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hamburgerEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraMalzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisYönetimiToolStripMenuItem,
            this.UrunYonetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparisYönetimiToolStripMenuItem
            // 
            this.siparisYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisOlusturToolStripMenuItem,
            this.siparisBilgileriToolStripMenuItem});
            this.siparisYönetimiToolStripMenuItem.Name = "siparisYönetimiToolStripMenuItem";
            this.siparisYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparisYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparisOlusturToolStripMenuItem
            // 
            this.siparisOlusturToolStripMenuItem.Name = "siparisOlusturToolStripMenuItem";
            this.siparisOlusturToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.siparisOlusturToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparisOlusturToolStripMenuItem.Click += new System.EventHandler(this.siparisOlusturToolStripMenuItem_Click);
            // 
            // siparisBilgileriToolStripMenuItem
            // 
            this.siparisBilgileriToolStripMenuItem.Name = "siparisBilgileriToolStripMenuItem";
            this.siparisBilgileriToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.siparisBilgileriToolStripMenuItem.Text = "Sipariş Bilgileri";
            this.siparisBilgileriToolStripMenuItem.Click += new System.EventHandler(this.siparisBilgileriToolStripMenuItem_Click);
            // 
            // UrunYonetimiToolStripMenuItem
            // 
            this.UrunYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hamburgerEkleToolStripMenuItem,
            this.extraMalzemeEkleToolStripMenuItem});
            this.UrunYonetimiToolStripMenuItem.Name = "UrunYonetimiToolStripMenuItem";
            this.UrunYonetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.UrunYonetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // hamburgerEkleToolStripMenuItem
            // 
            this.hamburgerEkleToolStripMenuItem.Name = "hamburgerEkleToolStripMenuItem";
            this.hamburgerEkleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.hamburgerEkleToolStripMenuItem.Text = "Hamburger Ekle";
            this.hamburgerEkleToolStripMenuItem.Click += new System.EventHandler(this.hamburgerEkleToolStripMenuItem_Click);
            // 
            // extraMalzemeEkleToolStripMenuItem
            // 
            this.extraMalzemeEkleToolStripMenuItem.Name = "extraMalzemeEkleToolStripMenuItem";
            this.extraMalzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.extraMalzemeEkleToolStripMenuItem.Text = "Extra Malzeme Ekle";
            this.extraMalzemeEkleToolStripMenuItem.Click += new System.EventHandler(this.extraMalzemeEkleToolStripMenuItem_Click);
            // 
            // FrmMainMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainMdi";
            this.Text = "Form1";
          
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hamburgerEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraMalzemeEkleToolStripMenuItem;
    }
}

