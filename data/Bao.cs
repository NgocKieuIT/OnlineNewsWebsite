using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_G24.data
{
    public class Bao
    {
        public int id { get; set; }
        public string name { get; set; }
        public string loaitin { get; set; }
        public DateTime ngay { get; set; }
        public string ImageUrl { get; set; }
        public string mota { get; set; }
    }
}