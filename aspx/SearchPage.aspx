<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Page.Master" AutoEventWireup="true"CodeBehind="HomePage.aspx.cs" Inherits="BTL_G24.aspx.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>SearchPage</title>
    <link href="../styles/main.css" rel="stylesheet"/>
    <link href="../styles/home_responsive.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
 <main class="main-wrapper">
    <div class="container" id="trangtimkiem">
        <div class="home-title-block" id="home-title">
            <h2 class="home-title">Khám phá tin tức của chúng tôi</h2>
        </div>
        <div class="home-bao" id="home-bao">
            <% List<BTL_G24.data.Bao> bao= Application.Get(BTL_G24.Global.BAO_LIST) as List<BTL_G24.data.Bao>; %>
            <% string t= Session["Search"] as string ?? string.Empty;%>
            
            <% foreach(BTL_G24.data.Bao b in bao) { %> 
                 <% if (b.name.IndexOf(t, StringComparison.OrdinalIgnoreCase) >= 0)
                     {%>
            <div class="col-bao">
            <article class="card-bao" >
                <div class="card-header">
                    <a href="Detail.aspx?id=<% =b.id %>" title="Xem báo" <%= b.name %>" class="card-image-link">
                    <img class="card-image" src="..\assest\img\<%= b.ImageUrl%>" title="<%=b.name%>"
                            alt="<%=b.name%>" />
                    </a>
                </div>
                <div class="bao-info">
                    <div class="card-content">
                        <div class="card-title">
                            <a href="Detail.aspx?id=<% =b.id %>" title="Xem báo" <%= b.name %>" class="card-title-link">
                                <%=b.name %>
                            </a>
                        </div>
                    </div>
                </div>
            </article>
            </div>
                  <%}%>
        <%}%>
        </div>
    </div>
</main>
</asp:Content>
