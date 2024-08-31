using Assign07_2.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign07_2.Models
{
    public class Product
    {
        public string ProductCode { get; set; }
        public int ProductCategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public ProductCategory ProductCategory { get; set; }


        #region Methods
        /// <summary>
        /// Override object class ToString() Method
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{ProductCode.Trim(), -30}\t{ProductCategory.ProductCategoryID, -30}\t{ProductCategory.ProductCategoryName.Trim(), -30}\t\t{ProductName.Trim(),-30}\t{UnitPrice, -30:c}\t{Quantity, -30}";


        public object CloneProduct()
        {
            return new Product()
            {
                ProductCode = this.ProductCode,
                ProductCategoryID = this.ProductCategoryID,
                ProductName = this.ProductName,
                UnitPrice = this.UnitPrice,
                Quantity = this.Quantity,
                ProductCategory = this.ProductCategory
            };
        }

        #endregion
    }
}
