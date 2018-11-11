using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yetki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanı1.accdb");
        public string yetki;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                bool kontrol = false;
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = con;
                komut.CommandText = "Select * from kullanıcılar Where k_adi='" + KullaniciAdi.Text + "' and k_sifre='" + sfr.Text + "' ";
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    yetki = oku["yetki"].ToString();
                    kontrol = true;
                }
                con.Close();
                if (kontrol == true)
                {
                    Form2 an = new Form2();
                    an.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lütfen Gerekli Bilgileri Doğru Giriniz.", "Ebubekir Yazılım");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
