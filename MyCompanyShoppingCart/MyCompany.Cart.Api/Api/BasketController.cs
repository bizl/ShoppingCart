using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyCompany.Cart.Api.Api
{
   public class BasketController : ApiController
    {
        ITransactionService _transactionService;

        // Inject services into controller with repo path 
        public BasketController()
        {
            _transactionService = new TransactionService(ConfigurationManager.AppSettings["BasketsRepo"]);
         }

        [Route("v1/saga/baskets/{basket}")]
        public IHttpActionResult Get(string basket)
        {
            Guid basketId; 
             if(!Guid.TryParse(basket, out basketId))
            {
                throw  new InvalidOperationException(" A valid basket number is required"); 
            }

            return Ok(_transactionService.GetBasket(basketId )) ;
        }

        [Route("v1/saga/baskets")]
        public IHttpActionResult Get(int domain )
        { 
            return Ok(_transactionService.GetBaskets(domain));
        }
    }

}
