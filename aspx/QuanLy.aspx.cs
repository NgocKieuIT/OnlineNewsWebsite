using BTL_G24.data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_G24.aspx
{
    public partial class QuanLy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            List<Bao> baolist = Application[Global.BAO_LIST] as List<Bao>;
            if (baolist == null)
            {
                baolist = new List<Bao>();
            }
            string TieuDe = Request.Form["tenbao"];
            string Loai = Request.Form["chonloai"];
            string MoTa = Request.Form["mota"];
            int ID = baolist.Count + 1;
            DateTime Ngay = DateTime.Now;
            string fileName = Request.Form["up-hinh-anh"];
            if (!string.IsNullOrEmpty(TieuDe) && !string.IsNullOrEmpty(Loai) && !string.IsNullOrEmpty(MoTa))
            {
                Bao bao = new Bao()
                {
                    id = ID,
                    name = TieuDe,
                    loaitin = Loai,
                    ngay = Ngay,
                    ImageUrl = fileName,
                    mota = MoTa,
                };
                // Lấy danh sách từ Application
                baolist.Add(bao);

                // Cập nhật lại Application
                Application[Global.BAO_LIST] = baolist;
                Response.Redirect("../aspx/QuanLy.aspx");
            }
            else
            {
                Response.Redirect("../aspx/QuanLy.aspx");
            }

        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            /*int idsua = Convert.ToInt32(Request.QueryString["id"]);
            List<Bao> baolist = Application[Global.BAO_LIST] as List<Bao>;
            if (baolist == null)
            {
                baolist = new List<Bao>();
            }
            string TieuDe = Request.Form["tenbao"];
            string Loai = Request.Form["chonloai"];
            string MoTa = Request.Form["mota"];
            DateTime Ngay = DateTime.Now;
            string fileName = Request.Form["up-hinh-anh"];
            if (!string.IsNullOrEmpty(TieuDe) && !string.IsNullOrEmpty(Loai) && !string.IsNullOrEmpty(MoTa))
            {
                Bao bao = new Bao()
                {
                    id = idsua,
                    name = TieuDe,
                    loaitin = Loai,
                    ngay = Ngay,
                    ImageUrl = fileName,
                    mota = MoTa,
                };
                // Lấy danh sách từ Application
                baolist.Add(bao);

                // Cập nhật lại Application
                Application[Global.BAO_LIST] = baolist;
                Response.Redirect("../aspx/QuanLy.aspx");
            }
            else
            {
                Response.Redirect("../aspx/QuanLy.aspx");
            }*/
        }
    }
}
