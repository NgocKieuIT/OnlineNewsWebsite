<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Danhsach.aspx.cs" Inherits="BTL_G24.aspx.Danhsach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <table border="1">
    <tr>
        <th>Email</th>
        <th>Tên tài khoản</th>
        <th>Mật khẩu</th>
        <th>Mã xác nhận</th>
    </tr>
        <% 
            List<BTL_G24.data.User> users = Application.Get(BTL_G24.Global.USER) as List<BTL_G24.data.User>; 
            if(users != null)
            {
                foreach(BTL_G24.data.User b in users) { %>
                    <tr>
                        <td><%= b.email %></td>
                        <td><%= b.nameAccount %></td>
                        <td><%= b.password %></td>
                        <td><%= b.maxacnhan %></td>
                    </tr>
                <% }
            }
        %>
    </table>
</body>
</html>
