using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakKayitSqlile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnKullaniciGiris_Click(object sender, EventArgs e)
        {
            if(txtKullanici.Text=="Yonetici" && txtKullaniciSifre.Text=="yonetici123")//kullanici adı ve sifre kontrolü dogru ise ikinci forma geçer.
            {
                SatisEkrani satis = new SatisEkrani();
                satis.Show();
                this.Hide();
            }
        }      
    }
}
