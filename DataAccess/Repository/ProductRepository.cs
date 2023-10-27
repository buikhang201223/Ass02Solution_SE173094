using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();
        public Product GetProductByID(int ProductID) => ProductDAO.Instance.GetProductByID(ProductID);
        public void InsertProduct(Product Product) => ProductDAO.Instance.AddNew(Product);
        public void DeleteProduct(int ProductID) => ProductDAO.Instance.Remove(ProductID);
        public void UpdateProduct(Product Product) => ProductDAO.Instance.Update(Product);
        public List<Product> GetProductByUnitPriceAndUnitInStock(int a, int b) => ProductDAO.Instance.Filter(a, b);
        
    }
}
