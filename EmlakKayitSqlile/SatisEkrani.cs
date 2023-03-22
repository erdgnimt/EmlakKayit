using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmlakKayitSqlile
{
    public partial class SatisEkrani : Form
    {
        public SatisEkrani()
        {
            InitializeComponent();
        }        
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=site;Integrated Security=True"); //sql baglantımızı oluşturduk.

        public void verilerigoster()//select form ile verilerimizin sql veritabanından çekilip okunmasını ve listwieve de görüntülüenmesini sağladık.
        {
            listView1.Items.Clear();//alt alta sürekli verilerin gelmemesi için listeyi temizliyoruz.
            baglanti.Open();//veritabanı baglantımızı açtık.
            SqlCommand tablogoster = new SqlCommand("Select*from liste", baglanti);//tabloyu seç.
            SqlDataReader tablooku = tablogoster.ExecuteReader();//veri oku.

            while (tablooku.Read())//tablodaki satırları okuyana kadar listeye ekleyecek.
            {
                //veritabanında okuduğumuz ve tablooku nesnesine atadığımız verileri burada lisviewa aktarıyoruz. tablo columnlarını buraya yazıyoruz isimler çok önmeli aksi halde hata alınır. 
                ListViewItem listeekle = new ListViewItem(tablooku["id"].ToString());
                listeekle.SubItems.Add(tablooku["site"].ToString());
                listeekle.SubItems.Add(tablooku["durum"].ToString());
                listeekle.SubItems.Add(tablooku["oda"].ToString());
                listeekle.SubItems.Add(tablooku["metrekare"].ToString());
                listeekle.SubItems.Add(tablooku["fiyat"].ToString());
                listeekle.SubItems.Add(tablooku["blok"].ToString());
                listeekle.SubItems.Add(tablooku["adsoyad"].ToString());
                listeekle.SubItems.Add(tablooku["telefon"].ToString());
                listeekle.SubItems.Add(tablooku["notlar"].ToString());
                listView1.Items.Add(listeekle);//listeekle nesnesinde tuttuğumuz verileri lisviewe ekledik ve ekrana yazdık.
            }
            baglanti.Close();//veritabanı baglantımızı kapadık.
        }
        public void verikaydet()//listeye yeni veri ekleme..
        {
            baglanti.Open();
            string kayiteklemesorgusu = "insert into liste(id,site,durum,oda,metrekare,fiyat,blok,adsoyad,telefon,notlar) values (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";//burada ilk bölüme veritabanındaki tablo columnları yazılır ve karşı bölüme takma isimler yazılır.
            SqlCommand kayitekle = new SqlCommand(kayiteklemesorgusu, baglanti);//kayıtekleme ile ilgili sql komutu.
            kayitekle.Parameters.AddWithValue("@a", txtsira.Text);//ilgili yerler ile eşleştirilir.
            kayitekle.Parameters.AddWithValue("@b", comboBox1.Text);
            kayitekle.Parameters.AddWithValue("@c", comboBox2.Text);
            kayitekle.Parameters.AddWithValue("@d", comboBox3.Text);
            kayitekle.Parameters.AddWithValue("@e", txtmetre.Text);
            kayitekle.Parameters.AddWithValue("@f", txtfiyat.Text);
            kayitekle.Parameters.AddWithValue("@g", blokcmbx.Text);
            kayitekle.Parameters.AddWithValue("@h", txtadsoyad.Text);
            kayitekle.Parameters.AddWithValue("@i", txttelefon.Text);
            kayitekle.Parameters.AddWithValue("@j", txtnot.Text);
            kayitekle.ExecuteNonQuery();
            baglanti.Close();

        }
        int kisino = 0;
        private void verisil()
        {
            baglanti.Open();
            string silmesorgusu = $"delete from liste where id={kisino}";
            SqlCommand silmekomut = new SqlCommand(silmesorgusu, baglanti);
            silmekomut.ExecuteNonQuery();
            baglanti.Close();            
        }

        private void guncelle()
        {
            baglanti.Open();
            string guncellemesorgu = $"update liste set id=@a,site=@b,durum=@c,oda=@d,metrekare=@e,fiyat=@f,blok=@g,adsoyad=@h,telefon=@i,notlar=@j where id={kisino}";
            SqlCommand guncelle = new SqlCommand(guncellemesorgu, baglanti);
            guncelle.Parameters.AddWithValue("@a", txtsira.Text);
            guncelle.Parameters.AddWithValue("@b", comboBox1.Text);
            guncelle.Parameters.AddWithValue("@c", comboBox2.Text);
            guncelle.Parameters.AddWithValue("@d", comboBox3.Text);
            guncelle.Parameters.AddWithValue("@e", txtmetre.Text);
            guncelle.Parameters.AddWithValue("@f", txtfiyat.Text);
            guncelle.Parameters.AddWithValue("@g", blokcmbx.Text);
            guncelle.Parameters.AddWithValue("@h", txtadsoyad.Text);
            guncelle.Parameters.AddWithValue("@i", txttelefon.Text);
            guncelle.Parameters.AddWithValue("@j", txtnot.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }
        private void bttnGrntle_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            verikaydet();
            verilerigoster();
        }

        private void bttnSil_Click(object sender, EventArgs e)
        {
            verisil();
            verilerigoster();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)//listviewdan mouse ile veri seçildiğinde verilerin ilgili bölümlere yazılmasını sağladık.
        {
            kisino = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            txtsira.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtmetre.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtfiyat.Text = listView1.SelectedItems[0].SubItems[5].Text;
            blokcmbx.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtadsoyad.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txttelefon.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtnot.Text = listView1.SelectedItems[0].SubItems[9].Text;
        }
        private void bttnDuzelt_Click(object sender, EventArgs e)
        {
            guncelle();
            verilerigoster();
        }

        private void SatisEkrani_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Sıra", 30);
            listView1.Columns.Add("Site", 60);
            listView1.Columns.Add("Durum", 60);
            listView1.Columns.Add("Oda", 60);
            listView1.Columns.Add("Metrekare", 80);
            listView1.Columns.Add("Fiyat", 60);
            listView1.Columns.Add("Blok", 50);
            listView1.Columns.Add("Ad Soyad", 90);
            listView1.Columns.Add("Telefon", 90);
            listView1.Columns.Add("Notlar", 90);
            listView1.Width = 670;
            listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;//listview columnları sıraladık.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsira.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            txtmetre.Clear();
            txtfiyat.Clear();
            blokcmbx.Text = "";
            txtadsoyad.Clear();
            txttelefon.Clear();
            txtnot.Clear();
            listView1.Items.Clear();

        }      
    }
}
