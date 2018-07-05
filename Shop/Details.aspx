<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        
    <h1 class="mt-5">Details</h1>
    <div class="dropdown-divider border-pink"></div>
    
    <div class=" d-flex align-content-stretch justify-content-between">
        <asp:Image ID="ProductImage"  runat="server"/>
        <div class="card p-5 d-flex flex-column">
            <asp:Label ID="Name"  runat="server" CssClass="h3"></asp:Label>
            <asp:Panel ID="Description" runat="server"></asp:Panel>
        </div>
    </div>
    
    <a runat="server" href="~/Default">Back</a>
</asp:Content>