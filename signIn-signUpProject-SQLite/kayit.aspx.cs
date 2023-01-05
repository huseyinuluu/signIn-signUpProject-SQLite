using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace signIn_signUpProject_SQLite
{
    public partial class kayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"Data Source =" + Server.MapPath("kayit.db") + "; Version = 3; default timeout=5000; Pooling=True; Max Pool Size=100;";
            SQLiteConnection baglanti = new SQLiteConnection(dosyaYolu);
            string ekle = "INSERT INTO DBkayit(Ad,Soyad,KullaniciAdi,Sifre) VALUES" + "('" +
                k_ad.Text.Trim() + "','" + k_soyad.Text.Trim() + "','" +
                k_userName.Text.Trim() + "' , '" + k_sifre.Text.Trim() + "' )";

            try
            {
                if (string.IsNullOrWhiteSpace(k_userName.Text) || string.IsNullOrWhiteSpace(k_sifre.Text) ||
                    string.IsNullOrWhiteSpace(k_ad.Text) || string.IsNullOrWhiteSpace(k_soyad.Text))
                {
                    Response.Write("<script>alert('Tüm Alanları Doldurunuz')</script>");
                }
                else
                {
                    baglanti.Open();
                    SQLiteCommand komut = new SQLiteCommand(ekle, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    Response.Write("<script>alert('Kayıt Başarılı !');window.location.href = 'giris.aspx'</script>");

                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Kullanıcı Mevcut')</script>");
            }
        }

    }
}