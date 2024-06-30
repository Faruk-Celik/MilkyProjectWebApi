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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager ( IServiceDal serviceDal )
        {
            _serviceDal = serviceDal;
        }

        public void TDelete ( int id )
        {
            _serviceDal.Delete(id);
        }

        public Service TGetById ( int id )
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetListAll ()
        {
            return _serviceDal.GetListAll();
        }

        public void TInsert ( Service entity )
        {
            _serviceDal.Insert(entity);
        }

        public void TUpdate ( Service entity )
        {
            _serviceDal.Update(entity);
        }
    }
}
