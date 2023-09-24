/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgmt
{
    internal class ProductManagement
    {
        static ProductsDbEntities db;

        public ProductManagement()
        {
            db = new ProductsDbEntities();
        }
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
        }

        public Product RetrieveProduct(int id)
        {
            if (IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p => p.Equals(id));
                return product;
            }
            else
            {
                return null;
            }

        }
        public void DeleteProduct(int id)
        {

        }

        public void Updateproduct(int id)
        {

        }

        public void IsExistProduct(int id)
        {
            var pro = db.Products.SingleOrDefault(p => p.id == id);

        }
    }
}
*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgmt
{
    public class ProductManagement
    {
        static ProductsDbEntities db;

        public ProductManagement()
        {
            db = new ProductsDbEntities();
        }

        public Product AddProduct(Product product)
        {
            db.Products.Add(product);
            return product;
        }

        public Product RetrieveProduct(int id)
        {
            if (IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p => p.Equals(id));
                return product;
            }
            else
            {
                return null;
            }
        }
        public void DeleteProduct(int id)
        {
            if (IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p => p.Equals(id));
                db.Products.Remove(product);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("No Such Product exist");
            }
        }
        public void UpdateProduct(int id)
        {
            if (IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p => p.Equals(id));
                Console.WriteLine("Enter  New Name");
                product.Name = Console.ReadLine();
                Console.WriteLine("Enter New Name");
                product.Price = double.Parse(Console.ReadLine());
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("No Such Product exist");
            }
        }
        public bool IsExistProduct(int id)
        {
            var pro = db.Products.SingleOrDefault(p => p.id == id);
            if (pro == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}*/

using ProductMgmt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgnt
{
    public class ProductManagement
    {
        static ProductsDbEntities db;
        public ProductManagement()
        {
            db = new ProductsDbEntities();
        }
        public Product AddProduct(Product product)
        {
            db.Products.Add(product);
            return product;

        }
        public Product RetrieveProduct(int id)
        {
            if (IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p => p.Equals(id));
                return product;
            }
            else
            {
                return null;
            }

        }

        public void DeleteProduct(int id)
        {
            if (IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p => p.id==id);
                db.Products.Remove(product);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("No such Product exist!");
            }

        }
        public Product UpdateProduct(int id)
        {

            Product product = null;
            if (IsExistProduct(id))
            {
                product = db.Products.SingleOrDefault(p => p.id==id);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("No such Product exist!");
            }
            return product;
        }

        public bool IsExistProduct(int id)
        {
            var pro = db.Products.SingleOrDefault(p => p.id == id);
            if (pro == null)
            { return false; }
            else
            {
                return true;
            }

        }
    }
}