<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profil.aspx.cs" Inherits="signIn_signUpProject_SQLite.profil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>PROFİL BİLGİLERİ</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <!-- LINEARICONS -->
    <link rel="stylesheet" href="fonts/linearicons/style.css" />

    <!-- STYLE CSS -->
    <link rel="stylesheet" href="css/style.css" />
</head>
<body>
    <div class="wrapper">
        <div class="inner">

            <form id="form1" runat="server">
                <asp:Image Width="150" ID="myImage" runat="server" /><br />

                <img src="images/image-1.png" alt="" class="image-1" />
                <asp:Image ID="Image1" runat="server" />

                <asp:Label ID="Label1" runat="server" Text="Resim Seç"></asp:Label>
                <asp:FileUpload ID="inputFileControl" runat="server" />

                <div class="form-holder">
                    <span class="lnr lnr-mustache"></span>
                    <asp:TextBox
                        ID="k_ad"
                        class="form-control"
                        placeholder="Adınız"
                        runat="server"></asp:TextBox>
                </div>
                <div class="form-holder">
                    <span class="lnr lnr-bullhorn"></span>
                    <asp:TextBox
                        ID="k_soyad"
                        class="form-control"
                        placeholder="Soyadınız"
                        runat="server"></asp:TextBox>
                </div>
                <div class="form-holder">
                    <span class="lnr lnr-lock"></span>
                    <asp:TextBox
                        ID="k_sifre"
                        class="form-control"
                        placeholder="Şifre"
                        runat="server"></asp:TextBox>
                </div>

                <asp:Button class="btn_kayit" runat="server" Text="Güncelle" OnClick="btn_guncelle_Click" /><br />
                <asp:Button class="btn_kayit" runat="server" Text="Kaydımı Sil" OnClick="btn_sil_Click" BackColor="Red" />
                <asp:Button ID="Button1" class="btn_kayit" runat="server" Text="Çıkış Yap" OnClick="btn_out_Click" />


            </form>
            <img src="images/image-2.png" alt="" class="image-2" />
        </div>
    </div>



    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/main.js"></script>
</body>
</html>
