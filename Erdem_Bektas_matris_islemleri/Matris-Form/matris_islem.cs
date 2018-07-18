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
    public partial class matris_islem : Form
    {
        public matris_islem()
        {
            InitializeComponent();
        }

        int satir, sutun;
        int[,] matris = new int[10, 10];
        public static int satir2, sutun2;


        private void btnmatris_Click(object sender, EventArgs e)//işlem yapılacak matrisi alır
        {
            textBox2.Clear();

            satir = int.Parse(Interaction.InputBox("Satır Sayısını Giriniz:"));
            sutun = int.Parse(Interaction.InputBox("Sütun Sayısını Giriniz:"));
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matris[i, j] = int.Parse(Interaction.InputBox((i + 1) + "x" + (j + 1) + " Elemanını Giriniz= "));//matristeki elemanları alır
                }
            }
            for (int i = 0; i < satir; i++)//yazdırma döngüsü
            {
                for (int j = 0; j < sutun; j++)
                {
                    textBox2.Text = textBox2.Text + " " + matris[i, j].ToString();
                }
                textBox2.Text = textBox2.Text + "\r\n";
            }
        }

        private void matris_islem_Load(object sender, EventArgs e)
        {

        }

        private void toplama_Click(object sender, EventArgs e)//toplama
        {

            txtsonuc.Clear();
            int[,] gecicitoplam = new int[satir, sutun];

            satir2 = int.Parse(Interaction.InputBox("Satır Sayısını Giriniz:"));
            sutun2 = int.Parse(Interaction.InputBox("Sütun Sayısını Giriniz:"));
            int[,] gecicimatris = new int[satir2, sutun2];
            for (int i = 0; i < satir2; i++)
            {
                for (int j = 0; j < sutun2; j++)
                {
                    gecicimatris[i, j] = int.Parse(Interaction.InputBox((i + 1) + "x" + (j + 1) + " Elemanını Giriniz= "));//toplanacak ikinci matrisi alır
                }
            }

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    gecicitoplam[i, j] = gecicimatris[i, j] + matris[i, j];//elemanların toplanması
                }
            }

            for (int i = 0; i < satir; i++)//yazdırma döngüsü
            {
                for (int j = 0; j < sutun; j++)
                {
                    txtmatris2.Text = txtmatris2.Text + " " + gecicimatris[i, j].ToString();
                }
                txtmatris2.Text = txtmatris2.Text + "\r\n";
            }

            for (int i = 0; i < satir; i++)//yazdırma
            {
                for (int j = 0; j < sutun; j++)
                {
                    txtsonuc.Text = txtsonuc.Text + " " + gecicitoplam[i, j].ToString();
                }
                txtsonuc.Text = txtsonuc.Text + "\r\n";
            }

        }

        private void çikarma_Click(object sender, EventArgs e)//çıkarma
        {
            txtsonuc.Clear();
            int[,] gecicicikarma = new int[satir, sutun];
            satir2 = int.Parse(Interaction.InputBox("Satır Sayısını Giriniz:"));
            sutun2 = int.Parse(Interaction.InputBox("Sütun Sayısını Giriniz:"));
            int[,] gecicimatris = new int[satir2, sutun2];
            for (int i = 0; i < satir2; i++)
            {
                for (int j = 0; j < sutun2; j++)
                {
                    gecicimatris[i, j] = int.Parse(Interaction.InputBox((i + 1) + "x" + (j + 1) + " Elemanını Giriniz= "));//elemaları alır

                }
            }
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    gecicicikarma[i, j] = matris[i, j] - gecicimatris[i, j];//çıkarma
                }
            }

            for (int i = 0; i < satir; i++)//yazdırma
            {
                for (int j = 0; j < sutun; j++)
                {
                    txtmatris2.Text = txtmatris2.Text + " " + gecicimatris[i, j].ToString();
                }
                txtmatris2.Text = txtmatris2.Text + "\r\n";
            }

            for (int i = 0; i < satir; i++)//yazdırma
            {
                for (int j = 0; j < sutun; j++)
                {
                    txtsonuc.Text = txtsonuc.Text + " " + gecicicikarma[i, j].ToString();
                }
                txtsonuc.Text = txtsonuc.Text + "\r\n";
            }
        }

        private void matrislecarpma_Click(object sender, EventArgs e)//çarpma
        {
            txtsonuc.Clear();
            int[,] carpimsonuc = new int[satir, satir];
            satir2 = int.Parse(Interaction.InputBox("Satır Sayısını Giriniz:"));
            sutun2 = int.Parse(Interaction.InputBox("Sütun Sayısını Giriniz:"));
            int[,] gecicimatris = new int[satir2, sutun2];
            for (int i = 0; i < satir2; i++)
            {
                for (int j = 0; j < sutun2; j++)
                {
                    gecicimatris[i, j] = int.Parse(Interaction.InputBox((i + 1) + "x" + (j + 1) + " Elemanını Giriniz= "));//elemanları alır

                }
            }
            int[,] carpimmatris = new int[satir, sutun2];
            for (int i = 0; i < satir; i++)  
            {
                for (int j = 0; j < sutun2; j++)
                {
                    for (int k = 0; k < satir2; k++)
                    {
                        carpimsonuc[i, j] += matris[i, k] * gecicimatris[k, j]; //satır ve sütun elemanlarını sırayla çarpıp toplama işlemi yapar
                    }
                }
            }
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    txtmatris2.Text = txtmatris2.Text + " " + gecicimatris[i, j].ToString();//yazdırma
                }
                txtmatris2.Text = txtmatris2.Text + "\r\n";
            }

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < satir; j++)
                {
                    txtsonuc.Text = txtsonuc.Text + " " + carpimsonuc[i, j].ToString();//yazdırma
                }
                txtsonuc.Text = txtsonuc.Text + "\r\n";
            }
        }

        private void reellecarpma_Click(object sender, EventArgs e)//skalerle çarpma işlemi
        {
            txtsonuc.Clear();
            int[,] reellecarpim = new int[satir, sutun];

            int sayi = int.Parse(Interaction.InputBox("Matrisle Çarpılacak Reel Sayıyı Giriniz:"));//çarpılacak değeri alır
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    reellecarpim[i, j] = matris[i, j] * sayi;//matristeki tüm elemanları çarpar
                }
            }
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    txtsonuc.Text = txtsonuc.Text + " " + reellecarpim[i, j].ToString();//yazdırma
                }
                txtsonuc.Text = txtsonuc.Text + "\r\n";
            }
        }








    }
}
