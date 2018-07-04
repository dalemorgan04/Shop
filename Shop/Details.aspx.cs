using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services.Products;

public partial class Details : Page
{
    private IProductService productService;

    protected override void OnInit(EventArgs e)
    {
        this.productService = new ProductService();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = Request.QueryString["id"];
        if (query != null)
        {
            if (!Page.IsPostBack)
            {
                ListProduct(Convert.ToInt32(query));
            }
        }
    }

    private void ListProduct(int id)
    {
        var product = this.productService.GetProducts(id);
        Name.Text = product.Name;
        Description.Text = product.Description;
        ProductImage.ImageUrl = product.ImageUrl;
        this.DataBind();
    }
}