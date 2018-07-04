<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Products</h1>
    </div>

    <div class="product-list">
        <asp:DataList ID="ProductsList" runat="server" CellPadding="4" ForeColor="#333333">
            <ItemTemplate>
                
                <div class="card" style="width: 18rem;">
                    <asp:ImageButton ID="ProductImage"  runat="server" ImageUrl= <%# Eval("ImageUrl") %> OnClick="ProductImage_OnClick" CommandArgument=<%# Eval("Id") %>/>
                   
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Name") %></h5>
                        <p class="price"><%# Eval("RetailPrice") %></p>
                    </div>
                </div>

            </ItemTemplate>
        </asp:DataList>
    </div>
    
    
    
</asp:Content>

<%--<--OnClick="ProductImage_OnClick"-->--%>