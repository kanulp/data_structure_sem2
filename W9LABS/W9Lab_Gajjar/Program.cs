using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9Lab_Gajjar
{
    class Program
    {
        static void Main(string[] args)
        {
             TransactionFacade transactionFacade = TransactionFacade.getInstance();

            //credit 1000$
            transactionFacade.Credit(1000);

            //Debit 200$
            transactionFacade.Debit(200);

            Console.ReadKey();
        }
    }
}
