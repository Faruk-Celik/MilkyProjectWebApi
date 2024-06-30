using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController ( IContactService contactService )
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult GetContactList ()
        {
            var values = _contactService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact ( Contact contact )
        {
            _contactService.TInsert(contact);
            return Ok("Başarıyla Kayıt Edildi");
        }
        [HttpDelete]
        public IActionResult DeleteContact ( int id )
        {
            _contactService.TDelete(id);
            return Ok("Başarıyla Silindi");
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact ( int id )
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateContact ( Contact contact )
        {
            _contactService.TUpdate(contact);
            return Ok("Başarıyla Güncellendi");
        }


    }
}
