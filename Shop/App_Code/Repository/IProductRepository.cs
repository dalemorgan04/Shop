using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace Repository
{
    public interface IProductRepository
    {
        List<Product> Get();
    }
}
