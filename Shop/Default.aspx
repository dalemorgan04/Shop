<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1 class="mt-5">Products</h1>
    <div class="dropdown-divider border-pink"></div>

    <div class="d-flex align-content-stretch justify-content-between flex-wrap">
        <asp:Repeater ID="ProductsList" runat="server">
            <ItemTemplate>
                
                <div class="card mt-5" style="width: 18rem;">
                    <asp:ImageButton ID="ProductImage"  runat="server" ImageUrl= <%# Eval("ImageUrl") %> OnClick="ProductImage_OnClick" CommandArgument=<%# Eval("Id") %>/>
                   
                    <div class="card-body d-flex flex-column justify-content-end">
                        <div class="card-title"><%# Eval("Name") %></div>
                        <div class="container">
                            
                            <div class="row">
                                <div class="col-sm price">£<%# Eval("RetailPrice") %></div>
                                <div class="col-sm">RRP £<%# Eval("RetailPrice") %></div>
                            </div>
                        </div>
                    </div>
                </div>
                
            </ItemTemplate>
        </asp:Repeater>
    </div>
    
</asp:Content>