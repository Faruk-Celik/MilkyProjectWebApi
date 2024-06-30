using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController ( ITeamService teamService )
        {
            _teamService = teamService;
        }
        [HttpGet]
        public IActionResult GetListTeam ()
        {
            var values = _teamService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateService ( Team team )
        {
            _teamService.TInsert(team);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteTeam ( int id )
        {
            _teamService.TDelete(id);
            return Ok("Başarıyla Sİlindi");
        }
        [HttpGet("GetTeam")]
        public IActionResult GetTeam ( int id )
        {
            var values = _teamService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult Update ( Team team )
        {
            _teamService.TUpdate(team);
            return Ok("Başarıyla Güncellendi");

        }
    }
}
