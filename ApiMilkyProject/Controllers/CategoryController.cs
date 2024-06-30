using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController ( ICategoryService categoryService )
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult CategoryList ()
        {
            var values =_categoryService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory (Category category )
        {
            _categoryService.TInsert(category);
            return Ok("Category Added Successfully");
        }
        [HttpDelete]
        public IActionResult DeleteCategory ( int id )
        {
            _categoryService.TDelete(id);
            return Ok("Category Deleted Successfully");
        }
        [HttpPut]
        public IActionResult UpdateCategory ( Category category )
        {
            _categoryService.TUpdate(category);
            return Ok("Category Updated Successfully");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory ( int id )
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }

    }
}
