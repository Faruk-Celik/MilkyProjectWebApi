using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhyUsController : ControllerBase
    {
        private readonly IWhyUsService _whyusService;

        public WhyUsController ( IWhyUsService whyusService )
        {
            _whyusService = whyusService;
        }
        [HttpGet]
        public IActionResult GetWhyUsList ()
        {
            var values = _whyusService.TGetListAll();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult CreateWhyus ( WhyUs whyUs )
        {
            _whyusService.TInsert(whyUs);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult Delete ( int id )
        {
            _whyusService.TDelete(id);
            return Ok("Başarıyla Silindi");
        }
        [HttpGet("GetWhyUs")]
        public IActionResult GetWhyUs ( int id )
        {
            var values = _whyusService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdaateWhyUs ( WhyUs whyUs )
        {
            _whyusService.TUpdate(whyUs);
            return Ok("Başarıyla Güncellendi");
        }
    }
}
