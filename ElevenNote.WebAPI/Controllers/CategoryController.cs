using ElevenNote.Models;
using ElevenNote.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote.WebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        public IHttpActionResult Get()
        {
            CategoryService categoryService = CreateCategoryService();
            var categories = categoryService.GetCategory();
            return Ok(categories);
        }

        public IHttpActionResult Post(CategoryCreate category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoryService = CreateCategoryService();

            if (!categoryService.CreateCategory(category))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            CategoryService categoryService = CreateCategoryService();
            var category = categoryService.GetCategoryById(id);
            return Ok(category);
        }

        public IHttpActionResult Put (CategoryEdit category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoryService = CreateCategoryService();

            if (!categoryService.UpdateCategory(category))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var categoryService = CreateCategoryService();

            if (!categoryService.DeleteCategory(id))
                return InternalServerError();

            return Ok();
        }

        private CategoryService CreateCategoryService()
        {
            var categoryService = new CategoryService();
            return categoryService;
        }
    }
}
