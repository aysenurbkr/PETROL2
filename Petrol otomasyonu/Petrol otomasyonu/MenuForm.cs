using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetrolOtomasyon
{
    public partial class MenuForm : Form
    {
        // SQL Bağlantısı için bir sınıf tanımlıyoruz
        SqlConnection bgl = new SqlConnection("Server=localhost;Database=petrol_otomasyonu;Trusted_Connection=True;");

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
            MessageBox.Show("Hoş Geldiniz! İşlem yapmak için bir seçenek seçiniz.");
        }

        // Çalışanlar ve Çalışma Saatleri
        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT ad AS [Ad], soyad AS [Soyad], pozisyon AS [pozisyon] , maas AS [maas] , mesai_saati_baslangic AS [Mesai_baslangic], mesai_saati_bitis AS [Mesai Bitiş] ,sube_id[sube_id] FROM personeller", bgl);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; // Verileri DataGridView'e aktarıyoruz
        }

        // Maaş ve Mesai Hesaplama
        private void btnMaasMesai_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT ad AS [Ad], soyad AS [Soyad], (maas + mesaai * 10) AS [Toplam Maaş] FROM personeller", bgl);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; // Verileri DataGridView'e aktarıyoruz
        }

        // Fiş Bilgileri
        private void btnFisBilgileri_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT fis_tarihi AS [Fiş Tarihi], plaka AS [Plaka], personel_ad AS [İşlem Yapan Kişi] FROM satislar", bgl);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; // Verileri DataGridView'e aktarıyoruz
        }

        // Depo Sorgusu (Kalan Yakıt)
        private void btnDepoSorgusu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT depo_id AS [depo_id] ,  sube_id AS [sube_id] , yakit_turu AS [Yakıt Türü], miktar_litre AS [Miktar (Litre)] FROM depo", bgl);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; // Verileri DataGridView'e aktarıyoruz
        }

        // Toplam Satış Bilgisi
        private void btnToplamSatis_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(tutar) AS [Toplam Satış] FROM satislar", bgl);
            if (bgl.State == ConnectionState.Closed)
                bgl.Open();
            object toplamSatis = cmd.ExecuteScalar(); // Toplam satış tutarını alıyoruz
            MessageBox.Show("Toplam Satış: " + toplamSatis.ToString() + " TL");
        }
    }
}
