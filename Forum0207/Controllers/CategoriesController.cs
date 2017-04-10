using Forum0207.Models;
using Forum0207.Repository;
using Forum0207.Repository.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Forum0207.Controllers
{
    public class CategoriesController : ApiController
    {
        ICategoryRepository _Repository;

        public CategoriesController()
        {
            //ForumRepository could be injected if desired
            _Repository = new CategoryRepository();
        }

        // GET api/Categories
        public HttpResponseMessage Get()
        {
            var custs = _Repository.GetCategories();
            if (custs == null) throw new HttpResponseException(HttpStatusCode.NotFound);
            return Request.CreateResponse<IEnumerable<Category>>(HttpStatusCode.OK, custs);
        }

        // GET api/Categories/5
        public HttpResponseMessage Get(int id)
        {
            var cust = _Repository.GetCategory(id);
            if (cust == null) throw new HttpResponseException(HttpStatusCode.NotFound);
            return Request.CreateResponse<Category>(HttpStatusCode.OK, cust);
        }

        //// POST api/Categories
        //public HttpResponseMessage Post([FromBody]Category category)
        //{
        //    var newCategory = _Repository.InsertCustomer(category);
        //    if (newCategory != null)
        //    {
        //        return new HttpResponseMessage(HttpStatusCode.Created);
        //    }
        //    throw new HttpResponseException(HttpStatusCode.Conflict);
        //}

        //// PUT api/Categories/5
        //public HttpResponseMessage Put(int id, [FromBody]Category category)
        //{
        //    var status = _Repository.UpdateCustomer(category);
        //    if (status) return new HttpResponseMessage(HttpStatusCode.OK);
        //    throw new HttpResponseException(HttpStatusCode.NotFound);
        //}

        //// DELETE api/Categories/5
        //public HttpResponseMessage Delete(int id)
        //{
        //    var status = _Repository.DeleteCustomer(id);
        //    if (status) return new HttpResponseMessage(HttpStatusCode.OK);
        //    throw new HttpResponseException(HttpStatusCode.NotFound);
        //}
    }
}
