using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace Repository
{
    public class ProductRepository: IProductRepository
    {

        public List<Product> Get()
        {//Create a using statement to handle your Connection
            using (SqlConnection sqlConnection = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DefaultConnection"].ToString()))
            {
                
                sqlConnection.Open();
                
                SqlCommand sqlCommand = new SqlCommand("GetProducts", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader data = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    List<Product> products = new List<Product>();
                    while (data.Read())
                    {
                        var product = new Product()
                        {
                            Id = Convert.ToInt32(data["id"]),
                            Name = data["product_name"].ToString(),
                            Description = data["product_description"].ToString(),
                            ImageUrl = data["image_name"].ToString(),
                            RetailPrice = Convert.ToInt32(data["price_rrp"]),
                            SellingPrice = Convert.ToInt32( data["selling_price"] )
                        };
                        products.Add(product);
                    }
                    return products;
                }
                catch (Exception exp)
                {
                    throw (exp);
                }
            }
        }
    }
}
