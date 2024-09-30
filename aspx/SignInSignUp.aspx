 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignInSignUp.aspx.cs" Inherits="BTL_G24.aspx.SignInSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../styles/SignInSignUp.css" rel="stylesheet" />
</head>
<body>
    <form runat="server" >
      <div class="main">
          <div class="container">
          <div class="logo">
              <img src="../../assest/img/logo.png" alt="Logo"/>
          </div>
          <div class="form_action" runat="server">

              <div class="login">
                  <h2>Đăng nhập</h2>
                  <input type="text" runat="server" placeholder="Nhập email" id="login_account" class="login_account" name="login_account" />
                  <input type="password" placeholder="Nhập mật khẩu" id="login_password" class="login_password" name="login_password" />
                  <div style="display:flex;width: 100%; height: 25px; margin-top:5px">
                  <input type="checkbox" id="showPassword" onclick="togglePassword()" style="width:30px"/> 
                    <p style="color: black; padding:0 ">Hiển thị mật khẩu</p>
                  </div>
                  <p class="login_password" id="p1" runat="server"></p>
                  <asp:Button runat="server" id="btnDangnhap" CssClass="Button"  Text="Đăng nhập"  OnClick="SignIn" />
                  <p id="KTdangnhap" runat="server"></p>
                  <p class="form-info">Chưa có tài khoản? <a href="#" id="switch_to_register">Đăng ký</a></p>
              </div>

              <div class="register">
                  <h2>Đăng ký</h2>
                  <input type="text" placeholder="Tên đăng nhập" id="register_account" class="register_account" name="register_account" />
                  <input type="email" placeholder="Email" id="register_email" class="register_email" name="register_email" />
                  <input type="password" placeholder="Mật khẩu" id="register_password" class="register_password" name="register_password" />
                  <input type="text" placeholder="Mã xác nhận" id="xacnhan" class="xacnhan" name="xacnhan" />
                  <p class="register_password"></p>
                  <asp:Button runat="server" id="btnDangky" CssClass="Button"  Text="Đăng ký" OnClick="SignUp" />
                  <p id="KTDangky" runat="server"></p>
                  <p class="form-info">Đã có tài khoản? <a href="#" id="switch_to_login">Đăng nhập</a></p>
              </div>

          </div>
      </div>
  </div>
  </form>
  <script src="../script/SignInSignUp.js"></script>  
</body>
</html>
