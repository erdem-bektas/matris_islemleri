using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Matris_Form
{
    public partial class determinant : Form
    {
        int[,] matris = new int[10, 10];
        int satir, sutun, boyut;
        public determinant()
        {
            InitializeComponent();
        }

        private void btnmatris_Click(object sender, EventArgs e)//işlem yapılacak matrisin alınması 
        {
            satir = int.Parse(Interaction.InputBox("Satır Sayısını Giriniz:"));
            sutun = int.Parse(Interaction.InputBox("Sütun Sayısını Giriniz:"));
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matris[i, j] = int.Parse(Interaction.InputBox((i + 1) + "x" + (j + 1) + " Elemanını Giriniz= "));//tüm matris elemanlarını alır
                }
            }
            for (int i = 0; i < satir; i++)//yazdırma
            {
                for (int j = 0; j < sutun; j++)
                {
                    textBox2.Text = textBox2.Text + " " + matris[i, j].ToString();
                }
                textBox2.Text = textBox2.Text + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Girilen Matrisin Determinantı = " + DeterminantHesap(matris));
        }

        static double DeterminantHesap(int[,] matriss)//determinant hesabı
        {
            int boyutt = Convert.ToInt32(Math.Sqrt(matriss.Length));
            int isaret = 1;
            double toplam = 0;
            if (boyutt == 1)
                return matriss[0, 0];
            for (int i = 0; i < boyutt; i++)
            {
                int[,] altMatris = new int[boyutt - 1, boyutt - 1];//alt matris için yeni dizi
                for (int satir = 1; satir < boyutt; satir++)//satırın sonraki elemanından başlar( satır=1)
                {
                    for (int sutun = 0; sutun < boyutt; sutun++)//alt matrisin belirlenmesi döngüsü
                    {
                        if (sutun < i)
                            altMatris[satir - 1, sutun] = matriss[satir, sutun];
                        else if (sutun > i)
                            altMatris[satir - 1, sutun - 1] = matriss[satir, sutun];
                    }
                }
                if (i % 2 == 0)//işaretin belirlenmesi
                    isaret = 1;
                else
                    isaret = -1;
                toplam += isaret * matriss[0, i]/*satır elemanı*/ * (DeterminantHesap(altMatris)/*her alt matris için işlemin tekrarı*/);
            }
            return toplam;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (satir == sutun)
            {
                if (satir == 3)
                {
                    int sonuc = (matris[0, 0] * matris[1, 1] * matris[2, 2] + matris[1, 0] * matris[2, 1] * matris[0, 2] + matris[2, 0] * matris[0, 1] * matris[1, 2]) - (matris[0, 2] * matris[1, 1] * matris[2, 0] + matris[1, 0] * matris[2, 1] * matris[0, 2] + matris[2, 0] * matris[0, 1] * matris[1, 2]);// = basite kaçmak
                    MessageBox.Show("Determinant= " + sonuc);
                }
                else { MessageBox.Show("Matris 3x3 Tipinde Olmadığından Sarrus Kuralı Uygulanamaz."); return; }
            }
            else { MessageBox.Show("Matris Kare Olmadığından Sarrus Kuralı Uygulanamaz."); return; }

        }




    }
}
