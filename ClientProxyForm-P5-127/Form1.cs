using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxyForm_P5_127
{
    public partial class Form1 : Form
    {
        ServiceReference2.MatematikaClient obj = new ServiceReference2.MatematikaClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHasil_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBox1.Text);
            int angka2 = Convert.ToInt32(textBox2.Text);

            double hasilTambah = obj.Tambah(angka1, angka2);
            double hasilKurang = obj.Kurang(angka1, angka2);
            double hasilkali = obj.Kali(angka1, angka2);
            double hasilBagi = obj.Bagi(angka1, angka2);

            label3.Text = hasilTambah.ToString();
            label4.Text = hasilKurang.ToString();
            label5.Text = hasilkali.ToString();
            label6.Text = hasilBagi.ToString();
        }

        private void labelPengurangan_Click(object sender, EventArgs e)
        {

        }
    }
}
