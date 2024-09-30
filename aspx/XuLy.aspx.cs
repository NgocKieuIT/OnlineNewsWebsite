using BTL_G24.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_G24.aspx
{
    public partial class XuLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            List<Bao> baolist = Application[Global.BAO_LIST] as List<Bao>;
            if (baolist != null)
            {
                Bao itemToRemove = baolist.FirstOrDefault(ci => ci.id == id);
                if (itemToRemove != null)
                {
                    baolist.Remove(itemToRemove);
                    Application[Global.BAO_LIST] = baolist;
                    Response.Write("<script>alert('Đã xóa thành công!');</script>");
                }
                Response.Redirect("../aspx/QuanLy.aspx");
            }
        }
    }
}