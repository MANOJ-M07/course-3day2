/*using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgmt
{
    [TestFixture]
    public class ProductManagementTest
    {
        ProductManagement productMgr;
        [Test]
        public void Setup()
        {
            productMgr = new ProductManagement();
        }

        [Test]
        public void AddProductTest()
        {
            var product = new Product()
            {
                Name="Washing Machine",
                Price = 42000
            };
            var result = productMgr.AddProduct(product);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Equals(product));
        }
    }
}
*/
/*using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgmt
{
    [TestFixture]
    public class ProductManagementTest
    {
        ProductManagement productMgr;
        [SetUp]
        public void SetUp()
        {
            productMgr = new ProductManagement();
        }

        [Test]
        public void AddProductTest()
        {
            var product = new Product()
            {
                Name = "Washing Machine",
                Price = 42000
            };
            var result = productMgr.AddProduct(product);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Equals(product));
        }


        [Test]
        public void DeleteProductTest()
        {
            var product = new Product()
            {
                id= 1,
                Name = "I-Phone",
                Price = 142000
            };
            var result = productMgr.AddProduct(product);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Equals(product));

        }
    }
}*/
using NUnit.Framework;
using ProductMgmt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgnt
{
    [TestFixture]
    public class ProductManagementTest
    {
        ProductManagement productMgr;
        [SetUp]
        public void Setup()
        {
            productMgr = new ProductManagement();
        }
        [Test]
        public void AddProductTest()
        {
            var product = new Product()
            {
                Name = "Washing Machine",
                Price = 42000
            };
            var result = productMgr.AddProduct(product);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Equals(product));

        }

        [Test]
        public void UpdateProductTest()
        {
            var product = new Product()
            {
                id = 1,
                Name = "I-Phone",
                Price = 142000
            };
            var result = productMgr.UpdateProduct(1);
            Assert.IsNotNull(result);
            

        }

    }
}