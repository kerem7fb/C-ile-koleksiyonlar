using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace koleksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void listele() 
        {
            listBox1.Items.Clear();
            foreach (var list in liste)
            {
                listBox1.Items.Add(list);
            }
        }
        ArrayList liste = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            liste.Add(textBox1.Text);
            listele();
            textBox1.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int seçilen = listBox1.SelectedIndex;
            liste.Insert(seçilen, textBox1.Text);
            listele();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            liste.Remove(textBox1.Text);
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int seçilen = listBox1.SelectedIndex;
            liste.RemoveAt(seçilen);
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int seçilen = listBox1.SelectedIndex;
            liste[seçilen] = textBox1.Text;
            listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (liste.Contains(textBox1.Text))
            {
                label2.Text = "Aranan Değer Bulundu";
            }
            else
            {
                label2.Text = "Aranan Değer Bulunamadı";
            }
        }
    }
}
