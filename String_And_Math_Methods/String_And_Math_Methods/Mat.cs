using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_And_Math_Methods
{
    public class Mat
    {
        #region ABS
        //Mutlak Değer
        public static int Mabs(int sayi)
        {
            int sonuc = 0;
            if (sayi < 0)
            {
                for (int i = 0; i >= sayi; i--)
                {
                    sonuc = i * -1;
                }
            }
            else
            {
                for (int i = 0; i <= sayi; i++)
                {
                    sonuc = i;
                }
            }
            return sonuc;

        }
        #endregion
        #region MAX
        //MAX Metodu
        public static int Mmax(int sayi1, int sayi2)
        {
            int buyukSayi;

            if (sayi1 > sayi2)
            {
                buyukSayi = sayi1;
            }
            else if (sayi1 == sayi2)
            {
                buyukSayi = sayi1;
            }
            else
            {
                buyukSayi = sayi2;
            }
            return buyukSayi;
        }
        #endregion
        #region MIN 
        //MIN Motodu
        public static int Mmin(int sayi1, int sayi2)
        {
            int kucukSayi;

            if (sayi1 < sayi2)
            {
                kucukSayi = sayi1;
            }
            else if (sayi1 == sayi2)
            {
                kucukSayi = sayi1;
            }
            else
            {
                kucukSayi = sayi2;
            }
            return kucukSayi;

        }
        #endregion
        #region POW
        //Kuvvet Alma Metodu
        public static int Mpow(double sayi, double kuvvet)
        {
            double sonuc = 1;
            for (int i = 1; i <= kuvvet; i++)
            {
                sonuc = sonuc * sayi;
            }
            return (int)sonuc;
        }
        #endregion
        #region SIGN
        //SIGN Metodu
        public static int Msign(int sayi)
        {
            int sonuc = 0;
            if (sayi == 0)
                sonuc = 0;
            else if (sayi > 0)
                sonuc = 1;
            else
                sonuc = -1;
            return sonuc;
        }
        #endregion
        #region PI
        //PIsayisi       
        public static decimal PIsayisi()
        {
            decimal pi = 3.14159265358979M;
            return pi;
        }
        #endregion
        #region Floor
        //Ondalıklı sayıyı bir alt sayıya yuvarlama Metodu
        public static double Mfloor(double sayi)
        {
            int sonuc = 0;
            sonuc = (int)sayi;
            return sonuc;
        }
        #endregion
        #region Ceiling
        //Ondalıklı sayıyı bir üst sayıya yuvarlama Metodu
        public static double Mceiling(double sayi)
        {
            int sonuc = 0;
            sonuc = (int)sayi + 1;
            return sonuc;
        }
        #endregion
        #region Round
        //(Metot sayının yarısından fazlasını bir üste yarısından azını bir alta sayı .50, sayi çift ise bir alta tek ise bir üste yuvarlar)
        public static double Mround(double sayi)
        {
            int sonuc = 0;
            double modIslem;
            modIslem = sayi % 2;
            if (modIslem == 0)
                sonuc = (int)sayi - (int)0.50;
            else if (modIslem == 1)
                sonuc = (int)sayi + 1;
            else if (sayi < 11)
            {
                if (modIslem <= 0.50)
                {
                    sonuc = (int)sayi - (int)0.50;
                }
                else if (modIslem >= 1.50)
                {
                    sonuc = (int)sayi + 1;
                }
                else
                {
                    sonuc = (int)sayi + (int)1;
                }
            }
            else if (sayi >= 11)
            {
                if (modIslem <= 0.50)
                {
                    sonuc = (int)sayi - (int)0.50;
                }
                else if (modIslem >= 1.50)
                {
                    sonuc = (int)sayi + 1;
                }
                else
                {
                    sonuc = (int)sayi + (int)1;
                }
            }
            return sonuc;
        }
        #endregion
        #region Truncate
        //Sayının ondalıklı kısmına bakmaksızın size tam kısmını teslim eder.
        public static double Mtruncate(double sayi)
        {
            int sonuc = 0;
            sonuc = (int)sayi;
            return sonuc;
        }
        #endregion
        #region SQRT
        //Kuvvet alma metodu
        public static double Msqrt(double sayi)
        {
            double kok = 1;
            for (int i = 0; i < sayi + 1; i = i + 1)
            {
                kok = (sayi / kok + kok) / 2;
            }
            return kok;
        }
        #endregion
    }
}
