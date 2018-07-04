using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services.Products;

public partial class _Default : Page
{
    private IProductService productService;

    protected override void OnInit(EventArgs e)
    {
        this.productService = new ProductService();
    }
    protected override void OnLoadComplete(EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ListProducts();
        }
    }

    private void ListProducts()
    {
        var products = this.productService.GetProducts();
        ProductsList.DataSource = products;
        ProductsList.DataBind();
    }


    protected void ProductImage_OnClick(object sender, ImageClickEventArgs e)
    {
        //Response.Redirect("Details.aspx?id=5");
        ImageButton btn = (ImageButton)sender;
        string id = btn.CommandArgument;
        Response.Redirect("Details.aspx?id=" + id);
    }
}