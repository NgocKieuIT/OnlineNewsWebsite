using BTL_G24.data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_G24.MasterPages
{
    public partial class Page : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = Session["User"] as User;
            if (!IsPostBack)
            {
                if (user.nameAccount!=null)
                {
                    if (user.email=="ngockieu1692003@gmail.com")
                    {
                        admin.Style["display"] = "block";
                    }
                    btnSignUp.Text = user.nameAccount;
                    btnSignIn.Text = "Đăng xuất";
                }
            }
        }
        protected void SearchInfor(object sender, EventArgs e)
        {
            string searchValue = inputSearch.Text;

            // Lưu giá trị tìm kiếm vào Session
            Session["Search"] = searchValue;
            Response.Redirect("SearchPage.aspx");
        }
        protected void signUp(object sender, EventArgs e)
        {
            if (btnSignUp.Text == "Đăng Ký")
            {
                Response.Redirect("SignInSignUp.aspx?name=DangKy");
            }
        }

        protected void signIn(object sender, EventArgs e)
        {
            if (btnSignIn.Text == "Đăng Nhập")
            {
                Response.Redirect("SignInSignUp.aspx?name=DangNhap");
            }
            else
            {
                //dang xuat
                Session["User"] = new User();
                if (Session["UserLoggedIn"] != null)
                {
                    Application.Lock();
                    Application["demdangnhap"] = Convert.ToInt32(Application["demdangnhap"]) - 1;
                    Application.UnLock();
                }
                Response.Redirect("HomePage.aspx");

            }
        }
    }
}