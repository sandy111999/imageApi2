using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Classlibraraydata;

namespace Webimageapi.Controllers
{
    public class ImageController : ApiController
    {
        public IEnumerable<image_tbl> Get()
        {
            using (android7Entities entities = new android7Entities())
            {
               return entities.image_tbl.ToList();
            }
        }
    }
}
