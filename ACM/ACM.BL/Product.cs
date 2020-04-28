using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId) //Overloaded constructor
        {
            productId = productId;
        }
        public decimal? CurrentPrice { get; set; } //nullable type for distinguishing not set and 0. 0 - is valid price. no price - no valid
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        //public string ProductName { get; set; }
        private string _productName;

        public string ProductName
        {
            get
            {
                //return StringHandler.InsertSpaces(_productName);
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }
        /*string InsertSpaces(string source)
        {}
        */
        public string Log() => $"{ProductId}: {ProductName} Details: {ProductDescription} Status: {EntityState.ToString()}";

        /*public override string ToString()
        {
            return ProductName;
        }The same as below*/
        public override string ToString() => ProductName;
        /* //Retrieve one product
         public Product Retrieve(int productId)
         {
             return new Product();
         }
         //Saves current product
         public bool Save()
         {
             return true;
         }*/
        //Validates the product data
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
