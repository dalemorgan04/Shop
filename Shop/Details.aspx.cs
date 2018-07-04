using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services.Products;

public partial class Details : Page
{
    private IProductService productService;
    protected void Page_Load(object sender, EventArgs e)
    {
        string query = Request.QueryString["id"];
        if (query != null)
        {
            Response.Write("Worked");
        }
        else
        {
            Response.Write("Didn't work");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("Works!");
    }
}