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
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager ( ITeamDal teamDal )
        {
            _teamDal = teamDal;
        }

        public void TDelete ( int id )
        {
            _teamDal.Delete(id);
        }

        public Team TGetById ( int id )
        {
            return _teamDal.GetById(id);
        }

        public List<Team> TGetListAll ()
        {
            return _teamDal.GetListAll();
        }

        public void TInsert ( Team entity )
        {
            _teamDal.Insert(entity);
        }

        public void TUpdate ( Team entity )
        {
            _teamDal.Update(entity);
        }
    }
}
