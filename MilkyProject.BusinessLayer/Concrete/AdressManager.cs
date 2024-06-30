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
    public class AdressManager : IAdressService
    {
        private readonly IAdressDal _adressDal;

        public AdressManager ( IAdressDal adressDal )
        {
            _adressDal = adressDal;
        }

        public void TDelete ( int id )
        {
            _adressDal.Delete(id);
        }

        public Adress TGetById ( int id )
        {
            return _adressDal.GetById(id);
        }

        public List<Adress> TGetListAll ()
        {
            return _adressDal.GetListAll();
        }

        public void TInsert ( Adress entity )
        {
            _adressDal.Insert(entity);
        }

        public void TUpdate ( Adress entity )
        {
            _adressDal.Update(entity);
        }
    }
}
