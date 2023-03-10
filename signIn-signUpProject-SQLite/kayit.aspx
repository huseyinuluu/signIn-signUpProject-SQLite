<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kayit.aspx.cs" Inherits="signIn_signUpProject_SQLite.kayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Kayıt OL</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <!-- LINEARICONS -->
    <link rel="stylesheet" href="fonts/linearicons/style.css" />

    <!-- STYLE CSS -->
    <link rel="stylesheet" href="css/style.css" />
</head>
<body>
    <div class="wrapper">
        <div class="inner">
            <img src="images/image-1.png" alt="" class="image-1" />
            <form id="form1" runat="server">
                <h3>Hesap Oluştur</h3>

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
                    <span class="lnr lnr-user"></span>
                    <asp:TextBox
                        ID="k_userName"
                        class="form-control"
                        placeholder="Kullanıcı Adı"
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

                <asp:Button class="btn_kayit" runat="server" Text="Kayıt OL" OnClick="btn_kayit_Click" />

            </form>
            <img src="images/image-2.png" alt="" class="image-2" />
        </div>
    </div>

    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/main.js"></script>
</body>
</html>
