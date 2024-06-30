using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController ( IAboutService aboutService )
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList ()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout ( About about )
        {
            _aboutService.TInsert(about);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteAbout ( int id )
        {
            _aboutService.TDelete(id);
            return Ok("Başarıyla Silindi");
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout ( int id )
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateAbout ( About about )
        {
            _aboutService.TUpdate(about);
            return Ok("Başarıyla Güncellendi");

        }
    }
}
