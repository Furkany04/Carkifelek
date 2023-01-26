using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carkıfelekform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] harfler = new char[31] ;
        Random rastgele = new Random();
        
        string[] girilenler = new string[31];
        int sayac = 0;
        int hakgg = 10;
        int puan = 0;
        private void kontrolbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                harfler[i] =Convert.ToChar(rastgele.Next(97, 123));

            }

            harf1txt.Text = harfler[0].ToString();
            harf2txt.Text = harfler[1].ToString();
            harf3txt.Text = harfler[2].ToString();
            harf4txt.Text = harfler[3].ToString();
            harf5txt.Text = harfler[4].ToString();
            harf6txt.Text = harfler[5].ToString();




            harf1txt.Visible = false;
            harf2txt.Visible = false;
            harf3txt.Visible = false;
            harf4txt.Visible = false;
            harf5txt.Visible = false;
            harf6txt.Visible = false;
            kontrolbtn.Text = "Kelime oluştu";
            

        }

        private void kontroletbtn_Click(object sender, EventArgs e)
        {
            
            if(harftxt.Text == harf1txt.Text)
            {
                harf1txt.Visible=true;
                bilgitxt.Text = harftxt.Text + " harfi kelimenin 1. harfidir";
                label8.Visible= false;
                harf1txt.Visible = true;
                puan += 10;
                puantxt.Text = puan.ToString();
            }
            else if (harftxt.Text == harf2txt.Text)
            {
                harf2txt.Visible=true;
                bilgitxt.Text = harftxt.Text + " harfi kelimenin 2. harfidir";
                label7.Visible = false;
                harf2txt.Visible = true;
                puan += 10;
                puantxt.Text = puan.ToString();
            }
            else if (harftxt.Text == harf3txt.Text)
            {
                harf3txt.Visible = true;
                bilgitxt.Text = harftxt.Text + " harfi kelimenin 3. harfidir";
                label6.Visible = false;
                harf3txt.Visible = true;
                puan += 10;
                puantxt.Text = puan.ToString();
            }



            else if (harftxt.Text == harf4txt.Text)
            {
                harf4txt.Visible = true;
                bilgitxt.Text = harftxt.Text + " harfi kelimenin 4. harfidir";
                label5.Visible = false;
                harf4txt.Visible = true;
                puan += 10;
                puantxt.Text = puan.ToString();
            }

            else if (harftxt.Text == harf5txt.Text)
            {
                harf5txt.Visible = true;
                bilgitxt.Text = harftxt.Text + " harfi kelimenin 5. harfidir";
                label4.Visible = false;
                harf5txt.Visible = true;
                puan += 10;
                puantxt.Text = puan.ToString();
            }

            else if (harftxt.Text == harf6txt.Text)
            {
                harf6txt.Visible = true;
                bilgitxt.Text = harftxt.Text + " harfi kelimenin 6. harfidir";
                label3.Visible = false;
                harf6txt.Visible = true;
                puan += 10;
                puantxt.Text = puan.ToString();
            }
            else
            {
                bilgitxt.Text = harftxt.Text +" harfi kelimede yoktur!";
                girilenler[sayac] = harftxt.Text;
                girilenlertxt.Text += girilenler[sayac] + ",";
                hakgg--;
            }
            
            if(hakgg< 0)
            {
                MessageBox.Show("Oyun bitti");
                Environment.Exit(0);
            }
            if(puan == 60)
            {
                MessageBox.Show("Tebrikler oyunu kazandınız");
                Environment.Exit(0);
            }
            
            haktxt.Text = hakgg.ToString();
            harftxt.Clear();
            
            girilenlertxt.Visible = true;
            sayac++;
            

        }
    }
}
