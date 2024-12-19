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
using PetrolOtomasyon;

namespace Petrol_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlbağlantisi bgl = new sqlbağlantisi();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // SQL sorgusuyla kullanıcıyı kontrol ediyoruz
            SqlCommand Giris = new SqlCommand("select * from kullanicilar where ad=@k1 and sifre=@k2 and rol=@k3", bgl.baglanti());
            Giris.Parameters.AddWithValue("@k1", kullanıcı.Text);
            Giris.Parameters.AddWithValue("@k2", Şifre.Text);
            Giris.Parameters.AddWithValue("@k3", comboBox1.Text);

            SqlDataReader dr = Giris.ExecuteReader();
            if (dr.Read())
            {
                string rol = dr["rol"].ToString(); // Kullanıcının rolünü alıyoruz

                // Role göre farklı form açıyoruz
                if (rol == "Şube Yönetici")
                {
                    MenuForm m = new MenuForm(); // Genel Yönetici için Menu formunu açıyoruz
                    m.Show();
                    this.Hide();

                }
                else if (rol == "Genel Yönetici")
                {
                    YoneticiFormu y = new YoneticiFormu(); // Şube Yöneticisi için farklı form
                    y.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tanımlanmamış rol!"); // Eğer tanımlı olmayan bir rol gelirse
                }

                this.Hide(); // Mevcut formu gizliyoruz
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
