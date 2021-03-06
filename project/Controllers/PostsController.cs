﻿using project.DAL;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace project.Controllers
{
    public class PostsController : BaseApiController
    {
            PostRepository _postRepository = new PostRepository();
        public IEnumerable<PostModel> Get()
        {
            var helper = new UrlHelper(Request);
            return _postRepository.GetAll()
                .Select(post => ModelFactory.Create(post));
        }

        public HttpResponseMessage Post([FromBody] PostModel model)
        {
            var helper = new UrlHelper(Request);
            var post = ModelFactory.Parse(model);
            _postRepository.Add(post);
            return Request.CreateResponse(
                HttpStatusCode.Created
                , ModelFactory.Create(post));
        }
    }
}
