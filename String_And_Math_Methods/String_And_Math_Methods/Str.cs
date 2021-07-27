using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_And_Math_Methods
{
    public class Str
    {

        #region CompareTo-1
        //CompareTo => Metodu kullandığımız string değerler ile metoda verdiğiniz parametredeki string değeri bir sözlük mantığı ile karşılaştırır. Eğer sözlükteki aynı lokasyondaysa 0, önceyse -1, sonraysa 1 değerini döndürür.

        public static int Mcompareto(string metin, string olanMetin)
        {
            int sonuc = 1;
            if (metin == olanMetin)
            {
                sonuc = 0;
            }
            char[] diziMetin = new char[metin.Length];
            for (int i = 0; i < metin.Length; i++)
            {
                diziMetin[i] += metin[i];
            }
            char[] diziOlanMetin = new char[olanMetin.Length];
            for (int i = 0; i < olanMetin.Length; i++)
            {
                diziOlanMetin[i] += olanMetin[i];
            }
            if (metin.Length > olanMetin.Length)
            {
                for (int i = 0; i < olanMetin.Length; i++)
                {
                    if (diziMetin[i] < diziOlanMetin[i])
                    {
                        sonuc = sonuc * -1;
                    }
                    else if (diziMetin[i] > diziOlanMetin[i])
                    {
                        sonuc = sonuc * 1;
                    }
                }
            }
            else if (metin.Length < olanMetin.Length)
            {
                for (int i = 0; i < metin.Length; i++)
                {
                    if (diziMetin[i] > diziOlanMetin[i])
                    {
                        sonuc = sonuc * 1;
                    }
                    else if (diziMetin[i] < diziOlanMetin[i])
                    {
                        sonuc = sonuc * -1;
                    }
                }
            }
            return sonuc;
        }
        #endregion //1
        #region Contains-2
        //Contains => Aradığınız char değer yada string değer, arama yaptığınız metinsel ifade içerisinde geçip geçmediğini size "bool" olarak döner.
        public static bool Mcontains(string ara, string olanMetin)
        {
            bool varMi = default;
            string compareText = "";
            int j = 0; //girilen metin increment
            int bulunanindex = 0;
            for (int i = 0; i < olanMetin.Length; i++)
            {
                if (j < ara.Length && varMi != true)
                {
                    if (olanMetin[i] == ara[j])
                    {
                        compareText += ara[j];

                        j++;
                    }
                }
                else
                {
                    compareText = "";
                    j = 0;
                }
                if (compareText.Length == ara.Length)
                {
                    varMi = true;
                    bulunanindex = i - (j - 1);
                    break;
                }
            }
            int indexofum = bulunanindex;
            return varMi;
        }
        #endregion //2
        #region IndexOf-3
        public static int MindexOf(string ara, string olanMetin)
        {
            bool varMi = default;
            string compareText = "";
            int j = 0;
            int bulunanindex = 0;
            for (int i = 0; i < olanMetin.Length; i++)
            {
                if (j < ara.Length && varMi != true)
                {
                    if (olanMetin[i] == ara[j])
                    {
                        compareText += ara[j];

                        j++;
                    }
                }
                else
                {
                    compareText = "";
                    j = 0;
                }
                if (compareText.Length == ara.Length)
                {
                    varMi = true;
                    bulunanindex = i - (j - 1);
                    break;
                }
            }
            int indexof = -1;
            if (varMi != false)
            {
                indexof = bulunanindex;
            }

            return indexof;
        }
        #endregion
        #region StartWith-4
        //StartsWith => Kelimenizin parametrede gönderdiğinizi değer ile başlayıp başlamadığını size "bool" olarak döndürür.
        public static bool MstartWith(string aranan, string olanMetin)
        {
            bool varMi = default;
            int j = 0;
            string bulunanDeger = "";
            for (int i = 0; i < aranan.Length; i++)
            {
                if (j < aranan.Length)
                {
                    if (olanMetin[i] == aranan[j])
                    {
                        bulunanDeger += aranan[j];
                        j++;
                        if (bulunanDeger.Length == aranan.Length)
                        {
                            varMi = true;
                        }
                    }
                    else
                    {
                        varMi = false;
                        break;
                    }
                }
            }
            return varMi;
        }
        #endregion
        #region EndWith-5
        //EndsWith => Kelimenizin parametrede gönderdiğinizi değer ile bitip bitmediğini size "bool" olarak döndürür.
        public static bool MendWith(string aranan, string olanMetin)
        {
            bool varMi = true;
            string bulunanDeger = "";
            for (int i = olanMetin.Length - aranan.Length; i < olanMetin.Length; i++)
            {
                bulunanDeger += olanMetin[i];
            }
            if (bulunanDeger == aranan)
            {
                varMi = true;
            }
            else
            {
                varMi = false;
            }
            return varMi;
        }
        #endregion
        #region Trim-6
        //Trim => Metninizin sağındaki ve solundaki tüm boşlukları temizlemenize olanak sağlar
        public static string Mtrim(string gelenMetin)
        {
            char[] dizi = new char[gelenMetin.Length];
            string yeniDeger = "";

            for (int i = 0; i < gelenMetin.Length; i++)
            {
                dizi[i] += gelenMetin[i];
            }
            for (int i = 0; i < gelenMetin.Length; i++)
            {
                if (' ' != gelenMetin[i])
                {
                    yeniDeger += gelenMetin[i];
                }
            }
            return yeniDeger;
        }
        #endregion
        #region ToCharArray-7
        //ToCharArray => stringinizi charlarına ayırarak size bir char dizisi olarak teslim eder.
        public static char[] MtoCharArray(string gelenMetin)
        {
            char[] dizi = new char[gelenMetin.Length];
            for (int i = 0; i < gelenMetin.Length; i++)
            {
                dizi[i] = gelenMetin[i];
            }
            return dizi;
        }
        #endregion
        #region ToUpper-ToLower-8

        //ToLower => ilgili metnin tamamını küçük harfe dönüştürmenize olanak sağlar.
        //ToUpper => ilgili metnin tamamını büyük harfe dönüştürmenize olanak sağlar.
        public static string MtoLower(string gelenMetin)
        {
            string kucukHarfYap = "";

            char[] buyukHarf = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'İ', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', ' ' };
            char[] kucukHarf = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'i', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z', ' ' };

            for (int i = 0; i < gelenMetin.Length; i++)
            {
                for (int j = 0; j < buyukHarf.Length; j++)
                {
                    if (gelenMetin[i] == buyukHarf[j])
                    {
                        for (int k = 0; k < kucukHarf.Length; k++)
                        {
                            if (buyukHarf.Length == kucukHarf.Length)
                            {
                                kucukHarfYap += kucukHarf[j];
                                break;
                            }
                        }
                    }
                }
            }
            return kucukHarfYap;
        }

        public static string MtoUpper(string gelenMetin)
        {
            string buyukHarfYap = "";

            char[] buyukHarf = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'İ', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', ' ' };
            char[] kucukHarf = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'i', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z', ' ' };

            for (int i = 0; i < gelenMetin.Length; i++)
            {
                for (int j = 0; j < kucukHarf.Length; j++)
                {
                    if (gelenMetin[i] == kucukHarf[j])
                    {
                        for (int k = 0; k < buyukHarf.Length; k++)
                        {
                            if (buyukHarf.Length == kucukHarf.Length)
                            {
                                buyukHarfYap += buyukHarf[j];
                                break;
                            }
                        }
                    }
                }
            }



            return buyukHarfYap;

        }
        #endregion
        #region Substring-9
        //Substring => (2.Kullanım) Metninizden, ilk parametrede gönderdiğiniz indexten başlayarak, ikinci parametrede verdiğiniz değere kadar olan kısmı çekip almanıza olanak sağlar...
        public static string MsubString(string gelenMetin, int baslangic, int sonuncu)
        {
            string kesilenMetin = "";
            int j = 0;

            for (int i = baslangic; i < gelenMetin.Length; i++)
            {
                if (j != sonuncu)
                {
                    kesilenMetin += gelenMetin[i];
                    j++;
                }
            }




            return kesilenMetin;
        }
        #endregion
        #region Remove-10
        //Remove => (2.Kullanım) Verdiğiniz index numarası dahil, o index'teki elemandan başlayarak, ikinci parametrede verdiğiniz değer kadar eleman siler.
        public static string Mremove(string gelenMetin, int baslangic, int sonuncu)
        {

            string eklenenDeger = "";
            string kesilenMetin = MsubString(gelenMetin, baslangic, sonuncu);
            char[] kesDizi = new char[kesilenMetin.Length];
            for (int k = 0; k < kesilenMetin.Length; k++)
            {
                kesDizi[k] += kesilenMetin[k];
            }
            char[] gelenDizi = new char[gelenMetin.Length];
            for (int y = 0; y < gelenMetin.Length; y++)
            {
                gelenDizi[y] += gelenMetin[y];
            }

            int j = 0;
            for (int i = 0; i < gelenMetin.Length; i++)
            {
                if (gelenDizi[i] == kesDizi[j])
                {
                    if (baslangic == i && gelenDizi[i] == kesDizi[j])
                    {
                        eklenenDeger += " ";
                        j++;
                        if (j == kesDizi.Length)
                        {
                            j = 0;
                        }

                    }
                    else if (gelenDizi[i] == kesDizi[j] && i > baslangic)
                    {

                        eklenenDeger += " ";
                        j = 0;
                    }
                    else
                    {
                        eklenenDeger += gelenMetin[i];
                    }

                }
                else
                {
                    eklenenDeger += gelenMetin[i];

                }
            }
            return Mtrim(eklenenDeger);

        }



        #endregion
        #region Insert-11
        //Insert => Bir metinsel değerin herhangi bir pozisyonuna (index) bir değeri iliştirmek istiyorsanız bu metodu kullanabilirsiniz. İlk parametrede kaçıncı indexten sonra ekleneceğini ,ikinci parametrede ise hangi değeri ekleyeceğini sorar.
        public static string Minsert(int baslangicIndex, string gelenMetin, string eklenecekMetin)
        {
            int u = 0;
            string yeniMetin = "";
            char[] dizigelenMetin = new char[gelenMetin.Length];
            for (int i = 0; i < gelenMetin.Length; i++)
            {
                dizigelenMetin[i] += gelenMetin[i];
            }
            char[] diziEklenecekMetin = new char[eklenecekMetin.Length];
            for (int j = 0; j < eklenecekMetin.Length; j++)
            {
                diziEklenecekMetin[j] += eklenecekMetin[j];
            }
            for (int k = 0; k < gelenMetin.Length; k++)
            {
                if (k < baslangicIndex)
                {
                    yeniMetin += gelenMetin[k];
                }

                else if (k >= baslangicIndex && u != eklenecekMetin.Length)
                {

                    for (int l = 0; l < eklenecekMetin.Length; l++)
                    {
                        yeniMetin += eklenecekMetin[l];
                        u++;
                        if (u == eklenecekMetin.Length)
                        {
                            k--;
                        }

                    }
                }
                else
                {

                    yeniMetin += gelenMetin[k];
                }
            }




            return yeniMetin;
        }
        #endregion
        #region LastIndexOf-12
        //LastIndexOf => Dizilerde gördüğümüz metodun aynı prensibi ile çalışır.... Eğer harf varsa, harfin index'ini yoksa -1, birden fazla varsa son bulduğunun index'ini döndürür.
        public static int MlastIndexOf(string aranan, string gelenMetin)
        {
            int yakalanan = 0;
            char[] arananDizi = new char[aranan.Length];
            for (int i = 0; i < aranan.Length; i++)
            {
                arananDizi[i] += aranan[i];
            }
            char[] gelenDizi = new char[gelenMetin.Length];
            for (int i = 0; i < gelenMetin.Length; i++)
            {
                gelenDizi[i] += gelenMetin[i];
            }

            for (int j = 0; j < gelenDizi.Length; j++)
            {
                if (arananDizi[0] == gelenDizi[j])
                {
                    yakalanan = j;
                }
            }
            if (yakalanan > 0)
            {
                return yakalanan;
            }
            else
            {
                return -1;
            }

        }
        #endregion
        #region Replace-13

        public static string Mreplace(string olanMetin, string degisecekMetin, string yeniMetin)
        {
            string hamMetin = "";
            string ayrilanMetin = "";
            string kalanMetin = "";
            char[] olanDizi = new char[olanMetin.Length];
            for (int i = 0; i < olanMetin.Length; i++)
                olanDizi[i] += olanMetin[i];
            int art = 0;

            for (int i = 0; i < olanMetin.Length-degisecekMetin.Length; i++)
            {
                for (int j = 0; j < degisecekMetin.Length; j++)
                {
                    ayrilanMetin += olanDizi[j + art];
                }
                if (ayrilanMetin==degisecekMetin)
                {
                    for (int k = 0; k < i; k++)
                    {
                        hamMetin += olanDizi[k];
                    }
                    for (int l = i+degisecekMetin.Length; l < olanDizi.Length; l++)
                    {
                        kalanMetin += olanDizi[l];
                    }
                }
                art++;
                ayrilanMetin = "";
            }
            

            
            return hamMetin + yeniMetin + kalanMetin;
        }

        #endregion
        #region Split-14
        //Split => Metninizi özel bir karakterden birden fazla parçaya ayırmanıza olanak sağlayan metottur. Aynı anda birden fazla özel karakter de kullanabilirsiniz...
        public static string[] Msplit(string text, params char[] seperators)
        {
            List<string> values = new List<string>();
            int[] seperatorIndexes = new int[0] { };
            for (int t = 0; t < text.Length; t++)
            {
                for (int i = 0; i < seperators.Length; i++)
                {
                    if (text[t] == seperators[i])
                    {
                        var index = t;
                        if (index > 0)
                        {
                            Array.Resize(ref seperatorIndexes, seperatorIndexes.Length + 1);
                            seperatorIndexes[seperatorIndexes.Length - 1] = index;
                        }
                    }
                }
            }

            for (int i = 0; i < seperatorIndexes.Length; i++)
            {
                if (i == 0)
                {
                    var value = text.Substring(0, seperatorIndexes[i]);
                    values.Add(value);
                }
                else
                {
                    int startIndex = ((seperatorIndexes[i - 1]) + 1);
                    int difference = seperatorIndexes[i] - ((seperatorIndexes[i - 1]) + 1);
                    var value = text.Substring(startIndex, difference);
                    values.Add(value);
                }
            }

            for (int i = 0; i < seperatorIndexes.Length; i++)
            {
                if (i + 1 == seperatorIndexes.Length)
                {
                    int startIndex = ((seperatorIndexes[i]) + 1);
                    int difference = text.Length - ((seperatorIndexes[i]) + 1);
                    var value = MsubString(text, startIndex, difference);
                    values.Add(value);
                }
            }


            return values.ToArray();
        }
        #endregion
    }
}
