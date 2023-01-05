using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace signIn_signUpProject_SQLite
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_giris_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"Data Source =" + Server.MapPath("kayit.db") + "; Version = 3; default timeout=5000; Pooling=True; Max Pool Size=100;";
            SQLiteConnection baglanti = new SQLiteConnection(dosyaYolu);
            baglanti.Open();
            string sorgu = "SELECT * FROM DBkayit WHERE KullaniciAdi = '" + k_userName.Text + "' And Sifre = '" + k_sifre.Text + "'";
            SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
            SQLiteDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                string authAd = dr["Ad"].ToString();
                string authSoyad = dr["Soyad"].ToString();
                string authSifre = dr["Sifre"].ToString();
                string authUserName = dr["KullaniciAdi"].ToString();
                string authResim = dr["ProfilResim"].ToString();

                Session["authAd"] = authAd;
                Session["authSoyad"] = authSoyad;
                Session["authSifre"] = authSifre;
                Session["authUserName"] = authUserName;
                Session["authResim"] = authResim;

                baglanti.Close();
                Response.Redirect("profil.aspx");
            }
            else
            {
                Response.Write("<script>alert('Kullanıcı Adı veya Şifre Hatalı')</script>");
            }
        }

    }
}