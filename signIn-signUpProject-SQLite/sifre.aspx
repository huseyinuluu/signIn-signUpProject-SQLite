<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sifre.aspx.cs" Inherits="signIn_signUpProject_SQLite.sifre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giriş</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="images/icons/favicon.ico" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/animate/animate.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="css/util.css" />
    <link rel="stylesheet" type="text/css" href="css/main.css" />
</head>
<body>
    <div class="limiter">
        <div class="container-login100">
            <div class="wrap-login100">
                <div class="login100-pic js-tilt">
                    <img src="images/img-01.png" alt="IMG" />
                </div>

                <form id="form1" class="login100-form validate-form" runat="server">
                    <span class="login100-form-title">Şifreni Mi Unuttun Bakayım Sen
                    </span>

                    <div class="wrap-input100 validate-input" data-validate="ex@abc.xyz">
                        <asp:TextBox ID="k_userName" class="input100" type="text" placeholder="Kullanıcı Adı" runat="server"></asp:TextBox>
                        <span class="focus-input100"></span>
                        <span class="symbol-input100">
                            <i class="fa fa-user" aria-hidden="true"></i>
                        </span>
                    </div>

                    <div class="wrap-input100 validate-input" data-validate="Password is required">
                        <asp:TextBox ID="k_sifre" class="input100" name="pass" placeholder="Şifre" runat="server" ForeColor="Red"></asp:TextBox>
                        <span class="focus-input100"></span>
                        
                    </div>

                    <div class="container-login100-form-btn">
                        <asp:Button ID="btn_sifre" class="login100-form-btn" runat="server" Text="Şifremi Hatırlat" OnClick="btn_sifre_Click" />
                    </div>

                    <div class="text-center p-t-12">

                        <a href="giris.aspx" class="txt2">Giriş Sayfasına Git
                            <i class="fa fa-long-arrow-right m-l-5" aria-hidden="true"></i>
                                </a><br />
                    </div>

                    <div class="text-center p-t-136">
                    </div>
                </form>
            </div>
        </div>
    </div>
    <!--===============================================================================================-->
    <script src="vendor/jquery/jquery-3.2.1.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/bootstrap/js/popper.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/select2/select2.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/tilt/tilt.jquery.min.js"></script>
    <script>
        $('.js-tilt').tilt({
            scale: 1.1
        })
    </script>
    <!--===============================================================================================-->
    <script src="js/main.js"></script>

</body>
</html>

