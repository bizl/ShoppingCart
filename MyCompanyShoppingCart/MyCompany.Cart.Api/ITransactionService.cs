using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Cart.Api
{
    public interface ITransactionService
    {
        Transactions GetBasket(Guid transactionNumber);
        List<Transactions> GetBaskets(int domain);
    }
}
