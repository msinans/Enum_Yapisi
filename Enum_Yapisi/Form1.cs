using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_Yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum sehirler { O, Adana, Adıyaman, Afyon, Ağrı, Amasya, Ankara, Antalya, Artvin, Aydın }
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);
            sehirler s;
            s = (sehirler)plaka;
            label1.Text = s.ToString();
            if (plaka <= 0 || plaka >= 10)
            {
                label1.Text = "Hatalı Plaka Girdiniz!";
            }

        }
        enum aylar { X, Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık }
        private void button2_Click(object sender, EventArgs e)
        {
            int ayno;
            ayno = Convert.ToInt32(textBox2.Text);
            aylar ay = (aylar)ayno;
            label2.Text = ay.ToString();
            if (label2.Text == "Haziran" || label2.Text == "Temmuz" || label2.Text == "Ağustos")
            {
                label3.Text = "Yaz Mevsimi";
            }
        }
    }
}
