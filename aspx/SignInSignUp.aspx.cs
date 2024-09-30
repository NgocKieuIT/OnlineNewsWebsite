using BTL_G24.data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_G24.aspx
{
    public partial class SignInSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SignIn(object sender, EventArgs e)
        {
            List<User> userlist = Application[Global.USER] as List<User>;
            
            if (IsPostBack)
            {
                foreach (User user in userlist)
                {
                    if (user.email != Request.Form.Get("login_account"))
                    {
                        KTdangnhap.InnerHtml = "Tài Khoản hoặc Mật Khẩu Không Chính Xác";

                    }
                    else
                    {
                        if (user.password != Request.Form.Get("login_password"))
                        {
                            KTdangnhap.InnerHtml = "Tài Khoản hoặc Mật Khẩu Không Chính Xác";
                        }
                        else
                        {
                            Session["User"] = user;

                            Session["UserLoggedIn"] = true;
                            Application.Lock();
                            Application["demdangnhap"] = Convert.ToInt32(Application["demdangnhap"]) + 1;
                            Application.UnLock();

                            KTdangnhap.InnerHtml = "";
                            Response.Redirect("HomePage.aspx");
                            break;
                        }
                    }
                }
            }
        }

        protected void SignUp(object sender, EventArgs e)
        {
            List<User> userlist = Application[Global.USER] as List<User>;
            int kt = 0;
            if (IsPostBack)
            {
                foreach (User user in userlist)
                {
                    if (user.email == Request.Form.Get("register_email"))
                    {
                        KTDangky.InnerHtml = "Email đã tồn tai vui lòng chọn email khác";
                        kt = 1;
                    }
                }
                if (kt == 0)
                {
                    User newUser = new User();
                    newUser.email = Request.Form.Get("register_email");
                    newUser.nameAccount= Request.Form.Get("register_account");
                    newUser.password= Request.Form.Get("register_password");
                    newUser.maxacnhan= Request.Form.Get("xacnhan");
                    if (newUser.email!=""&& newUser.nameAccount!=""&& newUser.password!="")
                    {
                        KTDangky.InnerHtml = "";
                        userlist.Add(newUser);
                        Session["User"] = newUser;
                        Response.Redirect("HomePage.aspx");
                    }
                    else
                    {
                        KTDangky.InnerHtml = "Vui lòng nhập đúng dữ liệu";
                    }
                }
            }
        }
    }
}
