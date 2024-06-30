using Microsoft.EntityFrameworkCore;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Reporsitories;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(MilkyContext context) : base(context)
        {

        }

        public List<Product> GetProductsWithCategory ()
        {
            var context = new MilkyContext();
            var values = context.Products.Include(x => x.Category).Select(y => new Product
            {
                NewPrice = y.NewPrice,
                OldPrice = y.OldPrice,
                ProductId = y.ProductId,
                ProductImageUrl = y.ProductImageUrl,
                ProductName = y.ProductName,
                Status = y.Status,
                Category = new Category { CategoryName = y.Category.CategoryName }


            }).ToList();
            
            return values;
        }
    }
}
