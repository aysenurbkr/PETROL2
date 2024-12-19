using System.Windows.Forms;
using System;

namespace PetrolOtomasyon
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnCalisanlar;
        private Button btnMaasMesai;
        private Button btnFisBilgileri;
        private Button btnDepoSorgusu;
        private Button btnToplamSatis;
        private DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCalisanlar = new System.Windows.Forms.Button();
            this.btnMaasMesai = new System.Windows.Forms.Button();
            this.btnFisBilgileri = new System.Windows.Forms.Button();
            this.btnDepoSorgusu = new System.Windows.Forms.Button();
            this.btnToplamSatis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalisanlar
            // 
            this.btnCalisanlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalisanlar.Location = new System.Drawing.Point(27, 13);
            this.btnCalisanlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalisanlar.Name = "btnCalisanlar";
            this.btnCalisanlar.Size = new System.Drawing.Size(160, 37);
            this.btnCalisanlar.TabIndex = 0;
            this.btnCalisanlar.Text = "Çalışanlar";
            this.btnCalisanlar.UseVisualStyleBackColor = false;
            this.btnCalisanlar.Click += new System.EventHandler(this.btnCalisanlar_Click);
            // 
            // btnMaasMesai
            // 
            this.btnMaasMesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMaasMesai.Location = new System.Drawing.Point(27, 70);
            this.btnMaasMesai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaasMesai.Name = "btnMaasMesai";
            this.btnMaasMesai.Size = new System.Drawing.Size(160, 37);
            this.btnMaasMesai.TabIndex = 1;
            this.btnMaasMesai.Text = "Maaş ve Mesai";
            this.btnMaasMesai.UseVisualStyleBackColor = false;
            this.btnMaasMesai.Click += new System.EventHandler(this.btnMaasMesai_Click);
            // 
            // btnFisBilgileri
            // 
            this.btnFisBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFisBilgileri.Location = new System.Drawing.Point(27, 130);
            this.btnFisBilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFisBilgileri.Name = "btnFisBilgileri";
            this.btnFisBilgileri.Size = new System.Drawing.Size(160, 37);
            this.btnFisBilgileri.TabIndex = 2;
            this.btnFisBilgileri.Text = "Fiş Bilgileri";
            this.btnFisBilgileri.UseVisualStyleBackColor = false;
            this.btnFisBilgileri.Click += new System.EventHandler(this.btnFisBilgileri_Click);
            // 
            // btnDepoSorgusu
            // 
            this.btnDepoSorgusu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDepoSorgusu.Location = new System.Drawing.Point(27, 189);
            this.btnDepoSorgusu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDepoSorgusu.Name = "btnDepoSorgusu";
            this.btnDepoSorgusu.Size = new System.Drawing.Size(160, 37);
            this.btnDepoSorgusu.TabIndex = 3;
            this.btnDepoSorgusu.Text = "Depo Sorgusu";
            this.btnDepoSorgusu.UseVisualStyleBackColor = false;
            this.btnDepoSorgusu.Click += new System.EventHandler(this.btnDepoSorgusu_Click);
            // 
            // btnToplamSatis
            // 
            this.btnToplamSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnToplamSatis.Location = new System.Drawing.Point(27, 249);
            this.btnToplamSatis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToplamSatis.Name = "btnToplamSatis";
            this.btnToplamSatis.Size = new System.Drawing.Size(160, 37);
            this.btnToplamSatis.TabIndex = 4;
            this.btnToplamSatis.Text = "Toplam Satış";
            this.btnToplamSatis.UseVisualStyleBackColor = false;
            this.btnToplamSatis.Click += new System.EventHandler(this.btnToplamSatis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(907, 369);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(27, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pompa Ekle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(27, 363);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Personel Ekle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(27, 421);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Yakıt Talepleri";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1258, 492);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalisanlar);
            this.Controls.Add(this.btnMaasMesai);
            this.Controls.Add(this.btnFisBilgileri);
            this.Controls.Add(this.btnDepoSorgusu);
            this.Controls.Add(this.btnToplamSatis);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuForm";
            this.Text = "Petrol Otomasyon - Menü";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private Button button1;
        private Button button2;
        private Button button3;
    }
}
