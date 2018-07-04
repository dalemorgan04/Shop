<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    <div class="product-details-container">
        <asp:Image ID="ProductImage"  runat="server"/>
        <asp:Label ID="Name"  runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="Description" runat="server"></asp:TextBox>
    </div>
</asp:Content>