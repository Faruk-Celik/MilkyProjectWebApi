using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Concrete
{
    public class WhyUsManager : IWhyUsService
    {
        private readonly IWhyUsDal _WhyUsDal;

        public WhyUsManager ( IWhyUsDal whyUsDal )
        {
            _WhyUsDal = whyUsDal;
        }

        public void TDelete ( int id )
        {
            _WhyUsDal.Delete(id);
        }

        public WhyUs TGetById ( int id )
        {
            return _WhyUsDal.GetById(id);
        }

        public List<WhyUs> TGetListAll ()
        {
            return _WhyUsDal.GetListAll();
        }

        public void TInsert ( WhyUs entity )
        {
            _WhyUsDal.Insert(entity);
        }

        public void TUpdate ( WhyUs entity )
        {
            _WhyUsDal.Update(entity);
        }
    }
}
