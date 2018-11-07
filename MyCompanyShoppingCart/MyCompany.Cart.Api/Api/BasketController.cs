using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyCompany.Cart.Api.Api
{
   public class BasketController : ApiController
    {
        [Route("v1/saga")]
        public IHttpActionResult Get()
        {
            var feeds = new string[] { "foo", "bar" };

            return Ok(feeds);
        }
    }

}
