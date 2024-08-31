using Assign07_2.Models;
using Assign07_2.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign07_2
{
    internal class ProductList: List<Product>
    {
        #region Methods
        /// <summary>
        /// Gets student data from the ProductDB and adds it into the product list
        /// </summary>
        public void Fill()
        {
            List<Product> products = ProductDB.GetProducts();
            foreach (Product product in products)
                base.Add(product);
        }
        /// <summary>
        /// Saves the updated student data into the directory
        /// </summary>
       // public void Save() => ProductDB.Products(this);
        #endregion
    }
}
