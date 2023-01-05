using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace signIn_signUpProject_SQLite
{
    public partial class profil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string kullaniciID = (string)Session["authUserName"];

            string dosyaYolu = @"Data Source =" + Server.MapPath("kayit.db") + "; Version = 3; default timeout=5000; Pooling=True; Max Pool Size=100;";
            using (SQLiteConnection baglanti = new SQLiteConnection(dosyaYolu))
            {
                baglanti.Open();
                string sorgu = "SELECT ProfilResim FROM DBkayit WHERE KullaniciAdi = '" +
                kullaniciID + "'";
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciID);

                using (SQLiteDataReader oku = komut.ExecuteReader())
                {
                    if (oku.Read())
                    {
                        if (oku["ProfilResim"] != DBNull.Value)
                        {
                            byte[] resimDosyasi = (byte[])oku["ProfilResim"];
                            string base64String = Convert.ToBase64String(resimDosyasi, 0, resimDosyasi.Length);
                            myImage.ImageUrl = "data:image/jpg;base64," + base64String;
                        }
                        else
                        {
                            myImage.ImageUrl = "";
                        }
                    }
                }
            }

            if ((string)Session["authUserName"] == null)
            {
                Response.Redirect("giris.aspx");
            }

            if (!IsPostBack)
            {
                k_ad.Text = (string)Session["authAd"];
                k_soyad.Text = (string)Session["authSoyad"];
                k_sifre.Text = (string)Session["authSifre"];
            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            string kullaniciID = (string)Session["authUserName"];
            string authResim = (string)Session["authResim"];

            string dosyaYolu = @"Data Source =" + Server.MapPath("kayit.db") + "; Version = 3; default timeout=5000; Pooling=True; Max Pool Size=100;";
            SQLiteConnection baglanti = new SQLiteConnection(dosyaYolu);
            baglanti.Open();

            try
            {
                if (inputFileControl.HasFile)
                {

                    string sorgu = "UPDATE DBkayit SET Ad = @ad, ProfilResim = @resim, Soyad = @soyad, Sifre = @sifre WHERE KullaniciAdi = @kullaniciAdi";
                    SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);

                    SQLiteParameter paramAd = new SQLiteParameter("@ad", DbType.String);
                    paramAd.Value = k_ad.Text.Trim();
                    komut.Parameters.Add(paramAd);

                    byte[] resimDosyasi = inputFileControl.FileBytes;
                    SQLiteParameter paramResim = new SQLiteParameter("@resim", DbType.Binary);
                    paramResim.Value = resimDosyasi;
                    komut.Parameters.Add(paramResim);
                    SQLiteParameter paramSoyad = new SQLiteParameter("@soyad", DbType.String);
                    paramSoyad.Value = k_soyad.Text.Trim();
                    komut.Parameters.Add(paramSoyad);
                    SQLiteParameter paramSifre = new SQLiteParameter("@sifre", DbType.String);
                    paramSifre.Value = k_sifre.Text.Trim();
                    komut.Parameters.Add(paramSifre);

                    SQLiteParameter paramKullaniciAdi = new SQLiteParameter("@kullaniciAdi", DbType.String);
                    paramKullaniciAdi.Value = kullaniciID;
                    komut.Parameters.Add(paramKullaniciAdi);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    Session.Abandon();
                    HttpCookie cookie = new HttpCookie("ASP.NET_SessionId", "");
                    cookie.Expires = DateTime.Now.AddYears(-1);
                    Response.Cookies.Add(cookie);

                    Response.Write("<script>alert('Kayıt Başarıyla Güncellendi !');window.location.href = 'giris.aspx'</script>");

                    //Response.Redirect("giris.aspx");
                }

                else
                {
                    string resimYok = "UPDATE DBkayit SET Ad = '" +
                    k_ad.Text.Trim() + "' , Soyad = '" +
                    k_soyad.Text.Trim() + "', Sifre = '" +
                    k_sifre.Text.Trim() + "' WHERE KullaniciAdi = '" +
                    kullaniciID + "'";
                    SQLiteCommand komut = new SQLiteCommand(resimYok, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Session.Abandon();
                    HttpCookie cookie = new HttpCookie("ASP.NET_SessionId", "");
                    cookie.Expires = DateTime.Now.AddYears(-1);
                    Response.Cookies.Add(cookie);

                    Response.Write("<script>alert('Kayıt Başarıyla Güncellendi !');window.location.href = 'giris.aspx'</script>");

                    //Response.Redirect("giris.aspx");
                }
            }

            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            string kullaniciID = (string)Session["authUserName"];

            string dosyaYolu = @"Data Source =" + Server.MapPath("kayit.db") + "; Version = 3; default timeout=5000; Pooling=True; Max Pool Size=100;";
            SQLiteConnection baglanti = new SQLiteConnection(dosyaYolu);
            string sil = "DELETE FROM DBkayit WHERE KullaniciAdi = '" + kullaniciID + "'";
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand(sil, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Session.Abandon();
                HttpCookie cookie = new HttpCookie("ASP.NET_SessionId", "");
                cookie.Expires = DateTime.Now.AddYears(-1);
                Response.Cookies.Add(cookie);


                Response.Write("<script>alert('Kayıt Başarıyla Silindi !');window.location.href = 'giris.aspx'</script>");


                //Response.Redirect("giris.aspx");
            }

            catch (Exception ex)
            {
                Response.Write(ex);
            }

        }

        protected void btn_out_Click(object sender, EventArgs e)
        {
            string kullaniciID = (string)Session["authUserName"];
            Session.Abandon();
            HttpCookie cookie = new HttpCookie("ASP.NET_SessionId", "");
            cookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie);
            Response.AddHeader("REFRESH", "0.1;URL=giris.aspx");
        }
    }
}