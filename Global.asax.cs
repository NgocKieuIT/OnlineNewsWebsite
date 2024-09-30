using BTL_G24.aspx;
using BTL_G24.data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI.WebControls.WebParts;

namespace BTL_G24
{
    public class Global : System.Web.HttpApplication
    {
        public const string BAO_LIST = "DSBB";
        public const string USER = "DSUser";
        public List<Bao> createBaolist()
        {
            return new List<Bao>()
            {
                new Bao() {id =1, name ="Thủ tướng yêu cầu chuyển đổi số với tinh thần 'không ai bị bỏ lại phía sau", loaitin="Thời sự",ngay=DateTime.Parse("08-09-2024"), ImageUrl="image1.jpg",mota="Đánh giá chuyển đổi số vẫn còn hiện tượng cát cứ thông tin, co cụm dữ liệu nên Thủ tướng đề nghị các cơ quan làm việc theo tinh thần không để ai bị bỏ lại phía sau." },
                new Bao() {id =2, name ="Chủ tịch nước Tô Lâm bắt đầu thăm Lào", loaitin="Thời sự",ngay=DateTime.Parse("08-09-2024"),  ImageUrl="image2.jpg", mota = "Chủ tịch nước Tô Lâm đến Vientiane sáng nay, bắt đầu chuyến thăm cấp nhà nước Lào. Chuyến thăm diễn ra ngày 11-12/7, theo lời mời của Tổng Bí thư, Chủ tịch nước Lào Thongloun Sisoulith. Đây là chuyến công tác nước ngoài đầu tiên của Chủ tịch nước Tô Lâm kể từ khi giữ cương vị mới." },
                new Bao() {id =3, name ="Thủ tướng: Làm chủ công nghệ để hiện đại hóa vũ khí", loaitin="Thời sự",ngay=DateTime.Parse("01-08-2024"),  ImageUrl="image3.jpg", mota = "Thủ tướng Phạm Minh Chính đề nghị Quân đội đẩy mạnh nghiên cứu, làm chủ khoa học công nghệ để cải tiến, hiện đại hóa vũ khí, trang bị kỹ thuật." },
                new Bao() {id =4, name ="Đề xuất mức phí ôtô đi cao tốc do nhà nước đầu tư", loaitin="Thời sự",ngay=DateTime.Parse("08-07-2024"),  ImageUrl="image4.jpg", mota = "Cục Đường bộ Việt Nam đề xuất mức phí 1.300-1.500 đồng/km đối với ôtô dưới 12 chỗ trên cao tốc đạt chuẩn do nhà nước đầu tư.Cục Đường bộ Việt Nam vừa trình Bộ Giao thông Vận tải dự thảo Nghị định về phí sử dụng đường bộ cao tốc." },
                new Bao() {id =5, name ="Đề xuất 5 phương án kết nối sân bay Tân Sơn Nhất và Long Thành", loaitin="Thời sự",ngay=DateTime.Parse("08-10-2024"),  ImageUrl="image5.jpg", mota = "Bộ Giao thông Vận tải đang lấy ý kiến 5 phương án kết nối giữa sân bay Tân Sơn Nhất và Long Thành, gồm hai phương án đường bộ và ba hướng tuyến đường sắt." },
                new Bao() {id =6, name ="Ninh Bình chuẩn bị làm cao tốc hơn 6.800 tỷ đồng", loaitin="Thời sự",ngay=DateTime.Parse("08-12-2024"),  ImageUrl="image6.jpg", mota = "Hơn 25 km đường thuộc tuyến cao tốc Ninh Bình - Hải Phòng đang hoàn thiện thủ tục đầu tư, dự kiến khởi công cuối năm 2024 và khánh thành sau hai năm." },
                new Bao() {id =7, name ="5 bài học giúp cha mẹ thay đổi cách tương tác với con", loaitin="Đời sống",ngay=DateTime.Parse("08-03-2024"),  ImageUrl="image7.jpg", mota = "Những hành động đơn giản, sự hiện diện hỗ trợ và những điều chỉnh trong cách giao tiếp có thể xây dựng kết nối sâu sắc hơn và thúc đẩy khả năng phục hồi của trẻ.Luôn giữ gương mặt rạng rỡ khi trẻ bước vào phòng. Khi ôm, nên để trẻ buông ra trước. Chơi với trẻ. Hãy là người hỗ trợ, không phải người giải cứu. Trò chuyện trực tiếp, sẵn sàng lắng nghe" },
                new Bao() {id =8, name ="Cách xử lý khi rơi vào thế khó trong giao tiếp", loaitin="Đời sống",ngay=DateTime.Parse("08-02-2024"),  ImageUrl="image8.jpg" , mota = "Sự lúng túng khi rơi vào các tình huống khó xử trong giao tiếp tương tự như chứng lo âu xã hội, đều biểu thị bằng sự lo lắng hoặc căng thẳng. Phải bình tĩnh quan sát đế xử lý tình huống một cách tốt nhất. Nếu bạn không muốn tiếp tục cuộc nói chuyện hãy tìm lý do để thoát khỏi cuộc nói chuyện đó."},
                new Bao() {id =9, name ="Vì sao nhiều người có thói quen đắp chăn khi ngủ?", loaitin="Đời sống",ngay=DateTime.Parse("12-09-2024"),  ImageUrl="image9.jpg", mota = "Chăn giúp ủ ấm khi nhiệt độ cơ thể xuống thấp khi ngủ, tăng mức serotonin và melatonin trong não, mang lại cảm giác thư giãn, dễ ngủ." },
                new Bao() {id =10, name ="Ảnh hưởng sức khỏe khi chế độ ăn thừa muối", loaitin="Đời sống",ngay=DateTime.Parse("02-09-2024"),  ImageUrl="image10.jpg", mota = "Chế độ ăn thừa muối là yếu tố nguy cơ gây nhiều bệnh như tăng huyết áp, loãng xương, suy thận, để phòng tránh cần kết hợp nhiều biện pháp, bao gồm các thực phẩm giảm muối." },
                new Bao() {id =11, name ="Hàng nghìn người trải nghiệm ngôi nhà 'thương gia' của Toshiba", loaitin="Đời sống",ngay=DateTime.Parse("04-09-2024"),  ImageUrl="image11.jpg", mota = "Chương trình diễn ra từ 28/6 đến 2/7 nhân dịp kỷ niệm Ngày Gia đình Việt Nam, với nhiều hoạt động như người dân tham quan, trải nghiệm không gian sống thương gia với các sản phẩm gia dụng cao cấp đến từ Toshiba." },
                new Bao() {id =12, name ="Giới trẻ di chuyển ra sao vào giờ cao điểm?", loaitin="Thể thao",ngay=DateTime.Parse("02-08-2024"),  ImageUrl="image12.jpg", mota = "Người trẻ dần chuộng xe công nghệ để di chuyển nhanh, tiện vào giờ cao điểm thay vì tự lái, phương tiện công cộng." },
                new Bao() {id =13, name ="James Rodriguez phá kỷ lục kiến tạo của Messi ở Copa America",loaitin="Thể thao", ngay=DateTime.Parse("08-03-2024"),  ImageUrl="image13.jpg", mota = "Đá phạt góc cho Lerma ghi bàn hạ Uruguay 1-0 ở bán kết, tiền vệ Colombia James Rodriguez trở thành cầu thủ kiến tạo nhiều nhất trong một kỳ Copa America.Phút 39, từ quả phạt góc bên phải, Rodriguez treo bóng về cột xa để tiền vệ Lerma đánh đầu đập đất tung lưới thủ thành Sergio Rochet, đưa Colombia vào chung kết." },
                new Bao() {id =14, name ="Nunez lên khán đài ẩu đả với CĐV Colombia", loaitin="Thể thao",ngay=DateTime.Parse("08-02-2024"),  ImageUrl="image14.jpg", mota = "Người hâm mộ Uruguay lọt thỏm giữa \"rừng\" áo vàng ở bốn phía khán đài, nhưng không kém phần cuồng nhiệt. Sau khi trọng tài người Mexico César Ramos thổi còi mãn cuộc, một số CĐV của Uruguay đã gây hấn và ném đồ uống về phía Colombia. Điều này châm ngòi cho cuộc xung đột sau đó." },
                new Bao() {id =15, name ="Messi tận hưởng những trận cuối cùng Argentina", loaitin="Thể thao",ngay=DateTime.Parse("12-09-2024"),  ImageUrl="image15.jpg", mota = "Tiền đạo Lionel Messi muốn tận hưởng những lần cuối dự các giải đấu lớn và hạnh phúc khi cùng Argentina đánh bại Canada 2-0 để vào chung kết Copa America 2024." },
                new Bao() {id =16, name ="Chủ tịch Barca muốn mua sao mới của Tây Ban Nha", loaitin="Thể thao",ngay=DateTime.Parse("02-09-2024"),  ImageUrl="image16.jpg", mota = "Chủ tịch Joan Laporta khẳng định Barca đủ tiềm lực tài chính để tuyển mộ Nico Williams, sao trẻ đang thăng hoa và góp công lớn giúp Tây Ban Nha vào bán kết Euro 2024." },
                new Bao() {id =17, name ="Xem bán kết Euro 2024 trên SCTV", loaitin="Thể thao",ngay=DateTime.Parse("04-09-2024"),  ImageUrl="image17.jpg", mota = "SCTV tiếp sóng tất cả trận đấu thuộc khuôn khổ Vòng chung kết Euro 2024, bao gồm các trận bán bán kết, bắt đầu từ rạng sáng 10/7." },
                new Bao() {id =18, name ="Cựu HLV Hà Nội: 'V-League không nên dựa dẫm vào ngoại binh nữa'", loaitin="Thể thao",ngay=DateTime.Parse("02-08-2024"),  ImageUrl="image18.jpg", mota = "Trong cuộc phỏng vấn với tạp chí Qoly trước khi rời Hà Nội FC, HLV Iwamasa Daiki muốn các CLB V-League giảm phụ thuộc vào ngoại binh và hướng tới lối chơi phát huy tốt hơn sức mạnh cầu thủ nội." },
                new Bao() {id =19, name ="Thắng luân lưu Hà Nội FC, Thanh Hóa đoạt Cup Quốc gia 2023-2024", loaitin="Thể thao",ngay=DateTime.Parse("08-03-2024"),  ImageUrl="image19.jpg", mota = "Thanh Hóa giành chiến thắng 9-8 ở loạt luân lưu trước Hà Nội FC trên sân nhà, để lần thứ hai liên tiếp đoạt Cup Quốc gia Casper.Đây là lần thứ hai liên tiếp Thanh Hoá đoạt Cup Quốc gia và đều sau loạt luân lưu. Ở mùa 2023, họ hoà Viettel (nay là Thể Công Viettel) 0-0 sau 90 phút, rồi thắng 5-3 ở loạt đấu 11 m." },
                new Bao() {id =20, name ="Bóng chuyền nữ Việt Nam giành vé dự giải U21 thế giới", loaitin="Thể thao",ngay=DateTime.Parse("08-02-2024"),  ImageUrl="image20.jpg", mota = "Thắng Đài Loan 3-0 ở giải U20 châu Á, đội trẻ bóng chuyền nữ Việt Nam giành vé dự giải vô địch U21 thế giới 2025. Ở trận play-off đầu tiên, Việt Nam thắng Ấn Độ 3-0 để giành quyền vào trận đấu tranh hạng 5 cùng suất dự giải U21 thế giới." },

            };
        }
        public List<User> createUser()
        {
            return new List<User>()
            {
                new User(){ email ="ngockieu169@gmail.com", nameAccount="KieuNgoc", password="Kieungoc169@", maxacnhan="AAA123"},
                new User(){ email ="ngockieu1692003@gmail.com", nameAccount="Admin", password="Kieungoc169@", maxacnhan = "BBB123"},
            };
         }
        protected void Application_Start(object sender, EventArgs e)
        {
            Application[USER] = createUser();
            Application[BAO_LIST] = createBaolist();
            Application["demtruycap"] = 0;

            Application["demdangnhap"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["User"] = new User();
            Session["Search"]= string.Empty;
           

            Application.Lock();
            Application["demtruycap"] = Convert.ToInt32(Application["demtruycap"]) + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["demtruycap"] = Convert.ToInt32(Application["demtruycap"]) - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}