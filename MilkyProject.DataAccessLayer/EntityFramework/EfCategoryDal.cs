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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal

    {
        public EfCategoryDal(MilkyContext context) : base(context)
        {

        }
        public int GetCategoryCount ()
        {
            var context = new MilkyContext();
            var categorycount = context.Categories.Count();
            return categorycount;
        }
    }
}
