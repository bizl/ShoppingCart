using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Cart.Api
{
    public class TransactionService : ITransactionService
    {
        private Loader _loader;
        readonly string _pathToRepository; 
       
        public TransactionService(string pathToRepository)
        {
            _loader = new Loader();
            _pathToRepository = pathToRepository; 
        }
        public Transactions GetBasket(Guid transactionNumber)
        {
           List<Transactions> transactions=  _loader.Load(File.ReadAllLines(_pathToRepository));

            return transactions.FirstOrDefault(t => t.TransactionNumber == transactionNumber.ToString()); 
        }

        public  List<Transactions> GetBaskets(int domain ) 
        {
            List<Transactions> transactions = _loader.Load(File.ReadAllLines(_pathToRepository));

            return transactions.Where(t => t.Domain == domain).OrderBy(c=> c.CreatedDateTime).ToList();
        }
    }
}
