using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kurs
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public gg ss = new gg();

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;//имя файла записывается в переменную filename
                string fileText = File.ReadAllText(filename,Encoding.GetEncoding(1251));//в переменную fileText считывается текст
                ss.s = fileText;
                richTextBox1.Text = ss.s;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            ss.ks = richTextBox2.Text;//в строку ks записывается слово
            ss.s = richTextBox1.Text;//в строку s записывается текст
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = ss.s.Length;//длина текста
            richTextBox1.SelectionBackColor = Color.FromArgb(255, 255, 255);//подсветка текста
            int a = 0;
            if (ss.ks=="")
            {
                MessageBox.Show("Введите слово", "", MessageBoxButtons.OK); return;
            }
            int n = ss.s.Length - ss.ks.Length+1;
            ss.s=ss.s.ToLower();
            ss.ks=ss.ks.ToLower();
            for (int i=0; i<n;i++)
            {
                string p = ss.s.Substring(i, ss.ks.Length);
                if (p==ss.ks)
                {
                    a++;
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = ss.ks.Length;
                    richTextBox1.SelectionBackColor = Color.FromArgb(110, 210, 130);//подсвечиваем совпадения
                }
            }
            label1.Visible = true;
            if (a>0)
                label1.Text = "Найдено совпадений " + a;
            else
                label1.Text = "Совпадений не найдено";
        }
    }

}