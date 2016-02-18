using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OrderInformationTransferManager
{
    [Serializable()]
    class Product
    {
        //Container for product variables.
        
        const string FileName = "SavedProducts.bin";
        public static Product staticProductReference = new Product();
        static int productNameCounter;
        String productName;
        int[] rawMaterialsItemIDArray;
        String[] rawMaterialsCodesArray;
        String[] rawMaterialsDescriptionArray;
        Decimal[] requiredRawMaterialsQuantitiesArray;
        public static List<Product> productsList = new List<Product>();
        public static Boolean productAdded = false;

        public Product()
        {
        }

        public Product(int[] tempRawMaterialsItemIDArrayParam, String[] rawMaterialsCodesListParam, String[] tempRawMaterialsDescriptionArrayParam, Decimal[] requiredRawMaterialsQuantitiesParam)
        {   
            this.productName = "Product " + ++productNameCounter;
            this.rawMaterialsItemIDArray = tempRawMaterialsItemIDArrayParam;
            this.rawMaterialsCodesArray = rawMaterialsCodesListParam;
            this.rawMaterialsDescriptionArray = tempRawMaterialsDescriptionArrayParam;
            this.requiredRawMaterialsQuantitiesArray = requiredRawMaterialsQuantitiesParam;
            productAdded = true;
        }

        public int[] getRawMaterialsItemIDArray()
        {
            return this.rawMaterialsItemIDArray;
        }
        
        public String[] getRawMaterialsCodesArray()
        {
            return this.rawMaterialsCodesArray;
        }

        public String[] getRawMaterialsDescriptionArray()
        {
            return this.rawMaterialsDescriptionArray;
        }

        public Decimal[] getRequiredRawMaterialsQuantitiesArray()
        {
            return this.requiredRawMaterialsQuantitiesArray;
        }

        public String getProductName()
        {
            return this.productName;
        }

        public void setProductName(String productNameParam)
        {
            this.productName = productNameParam;
        }

        public void updateProductsList(Product tempProductInstanceParam)
        {
            productsList.Add(tempProductInstanceParam);
        }

        public void resetProduct()
        {
            productNameCounter = 0;
            rawMaterialsItemIDArray = null;
            rawMaterialsCodesArray = null;
            rawMaterialsDescriptionArray = null;
            requiredRawMaterialsQuantitiesArray = null;
            productsList = new List<Product>();
            productAdded = false;
        }
    }
}
