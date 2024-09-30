<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanLy.aspx.cs" Inherits="BTL_G24.aspx.QuanLy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý cửa hàng</title>
    <link rel="stylesheet" href="../assest/font/font-awesome-pro-v6-6.2.0/css/all.min.css" />
    <link href="../styles/QuanLy.css" rel="stylesheet"/>
</head>
<body>
    <header class="header">
        <button class="menu-icon-btn">
            <div class="menu-icon">
                <i class="fa-regular fa-bars"></i>
            </div>
        </button>
    </header>
    <div class="container">
        <aside class="sidebar open">
            <div class="top-sidebar">
                <a href="#" class="channel-logo"><img src="../assest/img/logo_home.jpg" class="header-logo-img"/></a>
            </div>
            <div class="middle-sidebar">
                <ul class="sidebar-list">
                    <li class="sidebar-list-item tab-content">
                        <a href="#" class="sidebar-link">
                            <div class="sidebar-icon"><i class="fa-regular fa-newspaper"></i></div>
                            <div class="hidden-sidebar">Bài Báo</div>
                        </a>
                    </li>
                    <li class="sidebar-list-item tab-content"">
                        <a href="HomePage.aspx" class="sidebar-link">
                            <div class="sidebar-icon"><i class="fa-thin fa-circle-chevron-left"></i></div>
                            <div class="hidden-sidebar">Trang chủ</div>
                        </a>
                    </li>
                    <li class="sidebar-list-item tab-content">
                        <a href="SignInSignUp.aspx" class="sidebar-link">
                            <div class="sidebar-icon"><i class="fa-light fa-arrow-right-from-bracket"></i></div>
                            <div class="hidden-sidebar">Đăng xuất</div>
                        </a>
                    </li>
                     <li class="sidebar-list-item tab-content"">
                         <a href="Danhsach.aspx" class="sidebar-link">
                             <div class="sidebar-icon"><i class="fa-thin fa-circle-chevron-left"></i></div>
                             <div class="hidden-sidebar">Danh sách User</div>
                         </a>
                     </li>
                 </ul>
            </div>
        </aside>
        <main class=" content">
        <div class="admin-control">
            <div class="admin-control-center">
                <div class="form-search">
                    <span class="search-btn"><i class="fa-light fa-magnifying-glass"></i></span>
                    <input id="form-search-product" type="text" class="form-search-input" placeholder="Tìm kiếm " />
                </div>
            </div>
            <div class="admin-control-right">
                <button class="btn-control-large" id="btn-cancel-product"><i class="fa-light fa-rotate-right"></i> Làm mới</button>
                <button class="btn-control-large" id="btn-add-product"><i class="fa-light fa-plus"></i> Thêm bài mới</button>                  
            </div>
        </div>

        <div class="section product-all">
            <div id="show-product">
                <% List<BTL_G24.data.Bao> bao= Application.Get(BTL_G24.Global.BAO_LIST) as List<BTL_G24.data.Bao>; %> 
                <% foreach (BTL_G24.data.Bao b in bao)
                    { %>
                    <div class="list">
                        <div class="list-left">
                            <img  src="..\assest\img\<%= b.ImageUrl%>" alt="" />
                            <div class="list-info">
                                <h4><%=b.name %></h4>
                                <p class="list-note"><%=b.mota %></p>
                                <span class="list-category"><%=b.loaitin %></span>
                            </div>
                        </div>
                        <div class="list-right">
                            <div class="list-ngay">
                            <span class="list-current-ngay"><%=b.ngay %></span>                   
                            </div>
                            <div class="list-control">
                            <div class="list-tool">
                                <button class="btn-edit" onclick="Sua()" ><i class="fa-light fa-pen-to-square"></i></button>
                                <button class="btn-delete" onclick="Xoa(<%= b.id %>)"><i class="fa-regular fa-trash"></i></button>
                            </div>                       
                            </div>
                        </div> 
                    </div>
                <%} %>
            </div>
        </div>
        </main>

        <div class="modal add-product">
        <div class="modal-container">
            <h3 class="modal-container-title add-product-e">THÊM BÀI BÁO MỚI</h3>
            <h3 class="modal-container-title edit-product-e">CHỈNH SỬA BÀI BÁO</h3>
            <button class="modal-close product-form"><i class="fa-regular fa-xmark"></i></button>
            <form class="add-product-form" runat="server">
            <div class="modal-content">
                <div class="modal-content-left">
                    <img src="../assest/img/blank-image.png" alt="" class="upload-image-preview" id="img" runat="server"/>
                    <div class="form-group file">
                        <label for="up-hinh-anh" class="form-label-file"><i class="fa-regular fa-cloud-arrow-up"></i>Chọn hình ảnh</label>
                        <input accept="image/jpeg, image/png, image/jpg" id="up-hinh-anh" name="up-hinh-anh" type="file" class="form-control" onchange="uploadImage(this)" />
                    </div>
                </div>
                <div class="modal-content-right">
                    <div class="form-group">
                        <label for="tenbao" class="form-label">Tiêu đề</label>
                        <input id="tenbao" name="tenbao" type="text" placeholder="Nhập tiêu đề báo" class="form-control" runat="server"/>
                        <span class="form-message"></span>
                    </div>
                    <div class="form-group">
                        <label for="category" class="form-label">Chọn loại tin</label>
                        <select name="category" id="chonloai" runat="server">
                            <option>Thời sự</option>
                            <option>Thể thao</option>
                            <option>Đời sống</option>
                            <option>Du lịch</option>
                            <option>Giáo dục</option>
                            <option>Kinh tế</option>
                            <option>Giải trí</option>
                        </select>
                        <span class="form-message"></span>
                    </div>
                    <div class="form-group">
                        <label for="mota" class="form-label">Mô tả</label>
                        <textarea class="product-desc" id="mota" placeholder="Nhập nội dung bài báo" runat="server"></textarea>
                        <span class="form-message"></span>
                    </div>
                    <asp:Button runat="server" class="form-submit btn-add-product-form add-product-e" ID="addproductbutton" Onclick="btnSubmit_Click" Text ="THÊM BÁO MỚI" />
                    <asp:Button runat="server" class="form-submit btn-update-product-form edit-product-e" ID="btnupdateproduct" Onclick="btnUpdate_Click" Text ="LƯU THAY ĐỔI" />
                </div>
            </div>
          </form> 
        </div>
    </div>
 </div>
</body>
    <script src="../script/QuanLy.js"></script>
</html>
