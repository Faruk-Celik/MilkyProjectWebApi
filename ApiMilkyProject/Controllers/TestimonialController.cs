using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;

        public TestimonialController ( ITestimonialService testimonialService )
        {
            _TestimonialService = testimonialService;
        }


        [HttpGet]
        public IActionResult GetTestimonialList ()
        {
            var values = _TestimonialService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTestimonial ( Testimonial testimonial )
        {
            _TestimonialService.TInsert(testimonial);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial ( int id )
        {
            _TestimonialService.TDelete(id);
            return Ok("Başarıyla Kaydedildi");
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial ( int id )
        {
            var values = _TestimonialService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial ( Testimonial testimonial )
        {
            _TestimonialService.TUpdate(testimonial);
            return Ok("Başarıyla Güncellendi");
        }



    }
}
