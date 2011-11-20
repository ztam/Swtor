<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Swtor.Presentation.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Content/Styles/Default.min.css" rel="stylesheet" type="text/css" />
    <link href="/Content/Scripts/Jwysiwyg/jquery.wysiwyg.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

<div id="welcomeText" class="item contentBox editable" data-textId="<%=Model.TestText.TextId%>">

    <%=Model.TestText.Content %>

</div>

<div id="welcomeImage" class="item contentBox">

    <img src="/Content/Images/WelcomeImage.jpg" alt="Sith" />

</div>

<div id="textText" class="item contentBox">

    Test text test text

</div>

</asp:Content>

<asp:Content ID="content3" ContentPlaceHolderID="bottomContent" runat="server">
    <script src="/Content/Scripts/Jwysiwyg/jquery.wysiwyg.js" type="text/javascript"></script>
    <script src="/Content/Scripts/jquery.jeditable.js" type="text/javascript"></script>
    <script src="/Content/Scripts/jquery.jeditable.wysiwyg.min.js" type="text/javascript"></script>
</asp:Content>
