using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Assign07_2.Models.DataLayer
{
    public static class ProductDB
    {
        public static List<Product> GetProducts()
        {
            // create the list
            List<Product> products = new List<Product>();

            string selectStatement =
                "SELECT * " +
                "FROM Products ";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(
               CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            while (reader.Read() != false)
            {
                products.Add
                    (new Product 
                    {
                        ProductCode = ((string)reader["ProductCode"]).Trim(),
                        ProductCategoryID = (Int32)reader["ProductCategoryID"],
                        ProductName = ((string)reader["ProductName"]).Trim(),
                        UnitPrice = (decimal)reader["UnitPrice"],
                        Quantity = (int)reader["OnHandQuantity"],
                    });
            }
            return products;
        }
        public static ProductCategory GetProductCategory(int productCategoryID)
        {
            ProductCategory productCategory = null; // default return value
            string selectStatement = "SELECT ProductCategoryID, ProductCategoryName "
                                   + "FROM ProductCategories "
                                   + "WHERE ProductCategoryID = @productCategoryID";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@productCategoryID", productCategoryID);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                productCategory = new ProductCategory()
                {
                    ProductCategoryID = (int)reader["ProductCategoryID"],
                    ProductCategoryName= reader["ProductCategoryName"].ToString()
                };
            }
            return productCategory;
        }
        public static void AddProduct(Product product)
        {
            string insertStatement =
                "INSERT Products (ProductCode, ProductCategoryID, ProductName, UnitPrice, OnHandQuantity) " +
                "VALUES (@ProductCode, @ProductCategoryID, @ProductName, @UnitPrice, @OnHandQuantity)";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            command.Parameters.AddWithValue("@ProductCategoryID", AddProductCategory(product.ProductCategory));
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@OnHandQuantity", product.Quantity);
            connection.Open();
            int count = command.ExecuteNonQuery();
        }

        public static int AddProductCategory(ProductCategory productCategory)
        {
            string insertStatement =
                "INSERT ProductCategories (ProductCategoryName) " +
                "VALUES (@ProductCategoryName)";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@ProductCategoryName", productCategory.ProductCategoryName);
            connection.Open();
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {
                // get newly created categoryID from database
                command.CommandText = "SELECT IDENT_CURRENT('ProductCategories') "
                                    + "FROM ProductCategories";
                productCategory.ProductCategoryID = Convert.ToInt32(command.ExecuteScalar());
                return productCategory.ProductCategoryID;
            }
            return -1;

            
        }
        public static bool UpdateProduct(Product oldProduct,Product newProduct)
        {
            UpdateProductCategory(oldProduct, newProduct);
            string updateStatement =
              "UPDATE Products SET " +
                "ProductCode = @NewProductCode, " +
                "ProductName = @NewProductName, " +
                "UnitPrice = @NewUnitPrice, " +
                "OnHandQuantity = @NewOnHandQuantity " +
              "WHERE ProductCode = @oldProductCode " +
                "AND ProductName = @OldProductName " +
                "AND UnitPrice = @OldUnitPrice " +
                "AND OnHandQuantity = @OldOnHandQuantity ";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(updateStatement, connection);
            command.Parameters.AddWithValue("@NewProductCode", newProduct.ProductCode);
            command.Parameters.AddWithValue("@NewProductName", newProduct.ProductName);
            command.Parameters.AddWithValue("@NewUnitPrice", newProduct.UnitPrice);
            command.Parameters.AddWithValue("@NewOnHandQuantity", newProduct.Quantity);
            command.Parameters.AddWithValue("@oldProductCode", oldProduct.ProductCode);
            command.Parameters.AddWithValue("@OldProductName", oldProduct.ProductName);
            command.Parameters.AddWithValue("@OldUnitPrice", oldProduct.UnitPrice);
            command.Parameters.AddWithValue("@OldOnHandQuantity", oldProduct.Quantity);
            connection.Open();
            int count = command.ExecuteNonQuery();

            return (count > 0);
        }

        public static bool UpdateProductCategory(Product oldProduct, Product newProduct)
        {
            string updateStatement =
              "UPDATE ProductCategories SET " +
                "ProductCategoryName = @NewProductCategoryName " +
                "WHERE ProductCategoryName = @OldProductCategoryName "; 

            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(updateStatement, connection);
            command.Parameters.AddWithValue("@NewProductCategoryName", newProduct.ProductCategory.ProductCategoryName);
            command.Parameters.AddWithValue("@OldProductCategoryName", newProduct.ProductCategory.ProductCategoryName);
            connection.Open();
            int count = command.ExecuteNonQuery();

            return (count > 0);
        }


        public static bool DeleteProduct(Product product)
        {
            string deleteStatement =
              "DELETE FROM Products " +
              "WHERE ProductCode = @ProductCode " +
                "AND ProductName = @ProductName " +
                "AND ProductCategoryID = @ProductCategoryID " +
                "AND UnitPrice = @UnitPrice " +
                "AND OnHandQuantity = @OnHandQuantity ";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("@ProductCode ", product.ProductCode);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@ProductCategoryID", product.ProductCategoryID);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@OnHandQuantity", product.Quantity);
            connection.Open();
            int count = command.ExecuteNonQuery();

            return (count > 0);
        }
    }
}
