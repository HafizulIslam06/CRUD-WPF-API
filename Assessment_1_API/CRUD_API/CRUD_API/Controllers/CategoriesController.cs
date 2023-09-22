using CRUD_API.Context;
using CRUD_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;

        public CategoriesController(CRUDContext CRUDContext)
        {
            _CRUDContext= CRUDContext;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _CRUDContext.Categories;
        }

        [HttpGet("{id}", Name = "Get")]
        public Category Get(int id) 
        {
            return _CRUDContext.Categories.SingleOrDefault(x=>x.CategoryId == id);
        }

        [HttpPost]
        public void Post([FromBody] Category category) 
        {
            _CRUDContext.Categories.Add(category);
            _CRUDContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category category) 
        {
            category.CategoryId = id;
            _CRUDContext.Categories.Update(category);
            _CRUDContext.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item= _CRUDContext.Categories.FirstOrDefault(x=>x.CategoryId == id);
            if (item != null)
            {
                _CRUDContext.Categories.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
