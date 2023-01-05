using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace signIn_signUpProject_SQLite
{
    public partial class sifre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            k_sifre.Visible = false;
        }

        protected void btn_sifre_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"Data Source =" + Server.MapPath("kayit.db") + "; Version = 3; default timeout=5000; Pooling=True; Max Pool Size=100;";
            SQLiteConnection baglanti = new SQLiteConnection(dosyaYolu);
            baglanti.Open();
            string sifre = "SELECT * FROM DBkayit WHERE KullaniciAdi = '" + k_userName.Text + "'";
            SQLiteCommand komut = new SQLiteCommand(sifre, baglanti);
            SQLiteDataReader dr = komut.ExecuteReader();

            try
            {
                if (dr.Read())
                {
                    k_sifre.Visible = true;
                    k_sifre.Text = "Şifreniz:" + "    " + dr["Sifre"].ToString();
                }
                else
                {
                    k_sifre.Text = null;
                    Response.Write("<script>alert('Kullanıcı Bulunamadı')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}