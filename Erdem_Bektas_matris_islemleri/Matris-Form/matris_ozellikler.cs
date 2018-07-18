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
using System.Threading;

namespace Matris_Form
{
    public partial class matris_ozellikler : Form
    {
        public static int satir2, sutun2;
        int satir, sutun;
        int[,] matris = new int[10, 10];
        public static int[,] gecicimatris;
        Boolean karemi;
        Boolean sifirmi;
        Boolean satirmi;
        Boolean sutunmu;
        Boolean kosegenmi;
        Boolean skalermi;
        Boolean birimmi;
        Boolean simetrikmi;
        Boolean terssimetrikmi;
        Boolean altucgensel;
        Boolean ustucgensel;
        int koseelemani, boyut;

        public matris_ozellikler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//işlem yapılacak matrisi alma
        {
            textBox2.Clear();
            satir = int.Parse(Interaction.InputBox("Satır Sayısını Giriniz:"));
            sutun = int.Parse(Interaction.InputBox("Sütun Sayısını Giriniz:"));

            //girdiler boşken hata vermemeli-> o indexteki değeri yeniden istemeli -> bunu diğer yerlerde de yapmalı 

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matris[i, j] = int.Parse(Interaction.InputBox((i + 1) + "x" + (j + 1) + " Elemanını Giriniz= "));//matris elemanlarını alır
                }
            }
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    textBox2.Text = textBox2.Text + " " + matris[i, j].ToString();//alınan matrisi yazar
                }
                textBox2.Text = textBox2.Text + "\r\n";
            }
            return;
        }

        private void button1_Click_3(object sender, EventArgs e)//transpoze işlemi
        {
            txtsonuc.Clear();
            groupBox1.Visible = true;
            int[,] transpoze = new int[satir, sutun];
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    transpoze[i, j] = matris[j, i];// i ve j elemanları yerlerini değiştirir
                }
            }


            for (int i = 0; i < satir; i++)//yazdırma döngüsü
            {
                for (int j = 0; j < sutun; j++)
                {
                    txtsonuc.Text = txtsonuc.Text + " " + transpoze[i, j].ToString();
                }
                txtsonuc.Text = txtsonuc.Text + "\r\n";
            }


        }

        private void rank_Click(object sender, EventArgs e)//rank bulma işlemi yapar
        {
            int sayac = 0;
            for (int i = 0; i < satir; i++)
            {
                if (matris[i, i] != 0)//köşegen üzerindeki elemanın 0 olmadığını doğrular
                {
                    sayac++;//köşegen üzerindeki elemanları sayar
                }
            }
            MessageBox.Show("Girilen Matrisin Rankı=" + sayac);
        }

        void kareMiF(int row, int column)
        {
            if (boyut != 0)
            {
                if (row == column)
                {
                    karemi = true;
                }
            }
        }
        void sifirMiF(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (matris[i, j] != 0)
                    {
                        sifirmi = false;
                    }
                    else { sifirmi = true; }
                }
            }
        }
        void kosegenF(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (matris[i, i] != 0)
                    {
                        if (matris[i, j] == 0) { kosegenmi = true; }
                    }
                }
            }
        }
        void skalerMiF(int row)
        {
            int value = matris[0, 0];
            bool d1 = false, d2 = false;// d1 durumunda asal köşegen üzerindeki elemanlar aynı - d2 diğer elemanlar 0 
            for (int i = 0; i < row; i++)
            {
                if (matris[i, i] != value)
                {
                    d1 = false;
                }
                else { d1 = true; }
                for (int j = 0; j < row; j++)
                {
                    if (i == j) { continue; }
                    else
                    {
                        if (matris[i, j] != 0)
                        {
                            d2 = false;
                        }
                        else
                        {
                            d1 = true;
                        }
                    }
                }
            }

            if (d1 && d2) { skalermi = true; }
            else { skalermi = false; }
        }
        void simetrikMiF(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (matris[i, j] != matris[j, i])
                    {
                        simetrikmi = false;
                    }
                    else { simetrikmi = true; }
                }
            }
        }
        void ustUcgenselMiF(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (j < i)
                    {
                        if (matris[i, j] != 0) { ustucgensel = false; }
                        else { ustucgensel = true; }
                    }
                }
            }
        }
        void altUcgenselMiF(int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (i < j)
                    {
                        if (matris[i, j] != 0) { altucgensel = false; }
                        else { altucgensel = true; }
                    }
                }
            }



        }
        void birimMi(int row)
        {
            bool d1 = false, d2 = false;//d1- asal üzerindekiler 0 dan farklı - d2 diğerleri 0 kontrolü
            for (int i = 0; i < row; i++)
            {
                if (matris[i, i] == 0)
                {
                    d1 = false;
                }
                else { d1 = true; }
                for (int j = 0; j < row; j++)
                {
                    if (i == j) { continue; }
                    else
                    {
                        if (matris[i, j] != 0)
                        {
                            d2 = false;
                        }
                        else { d2 = true; }
                    }
                }
            }
            if (d1 && d2) { birimmi = true; }
            else { birimmi = false; }
        }

        private void tipbelirle_Click(object sender, EventArgs e)//matrisin tipini belirleme
        {
            if (textBox2.Text == "") { MessageBox.Show("Lütfen Matris Giriniz."); }
            if (satir == 1) { satirmi = true; }
            if (sutun == 1) { sutunmu = true; }
            boyut = Convert.ToInt32(Math.Sqrt(matris.Length));
            kareMiF(satir, sutun);
            if (karemi)
            {
                sifirMiF(satir);
                kosegenF(satir);
                skalerMiF(satir);
                simetrikMiF(satir);
                if (satir > 1)
                {
                    ustUcgenselMiF(satir);
                    altUcgenselMiF(satir);
                }
            }
            if (karemi) { if (sifirmi) { MessageBox.Show("Girilen Matris Hem Sıfır Hem de Kare Matristir."); } }
            else if (sifirmi) { MessageBox.Show("Girilen Matris Sıfır Matristir."); }
            else if (karemi) { MessageBox.Show("Girilen Matris Bir Kare Matristir."); }
            if (simetrikmi) { MessageBox.Show("Girilen Matris Simetrik Bir Matristir."); }
            if (birimmi) { MessageBox.Show("Girilen Matris Birim Matristir."); }
            else if (skalermi) { MessageBox.Show("Girilen Matris Skaler Bir Matristir."); }
            if (satirmi) { MessageBox.Show("Girilen Matris Satır Matristir."); }
            if (sutunmu) { MessageBox.Show("Girilen Matris Sütun Matristir."); }
            if (altucgensel) { MessageBox.Show("Girilen Matris Alt Üçgensel Matristir."); }
            else if (ustucgensel) { MessageBox.Show("Girilen Matris Üst Üçgensel Matristir."); }
            if (satirmi) { MessageBox.Show("Girilen Matris Bir Satır Matristir."); }
            else if (sutunmu) { MessageBox.Show("Girilen Matris Bir Sütun Matristir."); }
        }


    }
}