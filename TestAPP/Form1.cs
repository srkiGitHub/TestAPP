using System;
using System.Windows.Forms;

namespace TestAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonvideo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            openFileDialog1.FileName = "";
// ReSharper disable LocalizableElement
            openFileDialog1.Filter = "avi files (*.avi)|*.avi";
// ReSharper restore LocalizableElement
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void buttonpic_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.ShowDialog();
            textBox2.Text = openFileDialog1.FileName;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (!check_tboxes()) return;
            var tst = new Test(textBox1.Text, textBox2.Text, textBox3.Text);
            tst.ShowDialog();
        }

        private bool check_tboxes()
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("unesite path do video datoteke !");
                textBox1.Focus();
                return false;
            }

            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("unesite path do slike !");
                textBox2.Focus();
                return false;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("unesite text !");
                textBox3.Focus();
                return false;
            }

            return true;
        }
    }
}
