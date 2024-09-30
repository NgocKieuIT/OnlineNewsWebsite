<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Page.Master" AutoEventWireup="true"CodeBehind="HomePage.aspx.cs" Inherits="BTL_G24.aspx.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>DetailPage</title>
    <link href="../styles/detail.css" rel="stylesheet"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <main class="main-wrapper">
    <div class="container" id="trangchitiet">
        <% List<BTL_G24.data.Bao> bao= Application.Get(BTL_G24.Global.BAO_LIST) as List<BTL_G24.data.Bao>; %>
        <%int idchon = int.Parse(Request.QueryString["id"]); %>
             <% foreach (BTL_G24.data.Bao b in bao) {%>
                    <% if (b.id == idchon)
                     {%>
         <div class="sidebar-1">
                        <div class="header-content">
                            <div class="category"><h2><%=b.loaitin %></h2></div>
                            <div class="date"><%=b.ngay %></div>
                        </div>
                        <div><h3 class="title-detail"><%=b.name %></h3></div>
                        <div class="image-left">
                            <picture>
                                 <img class="anhl" src="..\assest\img\<%= b.ImageUrl%>" title="<%=b.name%>">
                            </picture>
                            <figcaption>
                                <p class="Image"><i><%=b.name%></i></p>
                            </figcaption>
                        </div>
                        <div class="mota"><%=b.mota%></div>
         </div>
                            <%}%>
             <%}%> 
        <div class="sidebar-2">
       <img class="anhr" src="..\assest\img\bao.jpg">
        </div>
      </div>   
    </main>
</asp:Content>
