using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_And_Math_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*------------------------MATH METOTLAR---------------------------*/
        private void btnPI_Click(object sender, EventArgs e)
        {
            decimal piSayisi = Mat.PIsayisi();
            MessageBox.Show(piSayisi.ToString());
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            int abs = Mat.Mabs(-45);
            MessageBox.Show(abs.ToString());
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            double floor = Mat.Mfloor(40.99);
            MessageBox.Show(floor.ToString());
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            double ceiling = Mat.Mceiling(12.01);
            MessageBox.Show(ceiling.ToString());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = Mat.Mmax(15, 38);
            MessageBox.Show(max.ToString());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = Mat.Mmin(15, 38);
            MessageBox.Show(min.ToString());
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            int pow = Mat.Mpow(3, 4);
            MessageBox.Show(pow.ToString());
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            double trun = Mat.Mtruncate(13.56);
            MessageBox.Show(trun.ToString());
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            int sign = Mat.Msign(10);
            MessageBox.Show(sign.ToString());
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            double round = Mat.Mround(21.50);
            MessageBox.Show(round.ToString());
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Mat.Msqrt(15);
            MessageBox.Show(sqrt.ToString());
        }
        /*------------------------STRING METOTLAR---------------------------*/
        private void btnCompareTo_Click(object sender, EventArgs e)
        {
            int compare = Str.Mcompareto("bilgeadam", "bilge");
            MessageBox.Show(compare.ToString());
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            bool contains = Str.Mcontains("uhan", "batuhanbilge");
            MessageBox.Show(contains.ToString());
        }

        private void btnStartSwith_Click(object sender, EventArgs e)
        {
            bool start = Str.MstartWith("b", "batuhan");
            MessageBox.Show(start.ToString());
        }

        private void btnEndSwith_Click(object sender, EventArgs e)
        {
            bool end = Str.MendWith("c", "batuhan");
            MessageBox.Show(end.ToString());
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string trim = Str.Mtrim("             batuhan              ");
            MessageBox.Show(trim);
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            int indexOf = Str.MindexOf("ş", "bilgeadam");
            MessageBox.Show(indexOf.ToString());
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            int lastIndexOf = Str.MlastIndexOf("a", "batuhan");
            MessageBox.Show(lastIndexOf.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string remove = Str.Mremove("batuhan", 0, 2);
            MessageBox.Show(remove);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string replace = Str.Mreplace("adambilge", "adam", "ilaç");
            MessageBox.Show(replace);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string[] split = Str.Msplit("batuhan@batu.com;info@info.com.tr;bilge@bilge.com,crn@crn.com", ';', ',');
        
            foreach (var item in split)
            {
                MessageBox.Show($"{item}");
            }
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string insert = Str.Minsert(5, "bilgeadam", "cik");
            MessageBox.Show(insert);
        }

        private void btnToUpToLow_Click(object sender, EventArgs e)
        {
            string upper = Str.MtoUpper("batuhan");
            string lower = Str.MtoLower("BATUHAN");
            MessageBox.Show(upper);
            MessageBox.Show(lower);
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            string substring = Str.MsubString("batuhan", 5, 2);
            MessageBox.Show(substring);
        }

        private void btnToCharArray_Click(object sender, EventArgs e)
        {
            char[] tochararray = Str.MtoCharArray("batuhan");
            string asilMetin = "";
            foreach (var item in tochararray)
            {
                asilMetin += item;
                MessageBox.Show(item.ToString());
            }
            MessageBox.Show(asilMetin);
        }

       
    }
}
