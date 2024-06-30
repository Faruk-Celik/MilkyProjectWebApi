using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressController : ControllerBase
    {
        private readonly IAdressService _addresService;

        public AdressController ( IAdressService addresService )
        {
            _addresService = addresService;
        }
        [HttpGet]
        public IActionResult AdressList ()
        {
            var values = _addresService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAdress ( Adress adress )
        {
            _addresService.TInsert(adress);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteAdress ( int id )
        {
            _addresService.TDelete(id);
            return Ok("Başarıyla Silindi");
        }
        [HttpGet("GetAdress")]
        public IActionResult GetAdress ( int id )
        {
            var values = _addresService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateAdress ( Adress adress )
        {
            _addresService.TUpdate(adress);
            return Ok("Başarıyla Güncellendi");
        }
    }
}
