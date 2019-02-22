using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bank.Core.Bank
{
    public class Bank : IBank
    {
        public string Name { get; set ; }
        public string SwiftCode { get; set  ; }
        public IList Clients { get ; set  ; }
        private Queue TransactionQueue { get; set; }
        private readonly object TransactionLock = new object(); 

        public void AddAgents(int agents = 1 )
        {
            throw new NotImplementedException();
        }

        public void AddTransaction()
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public void RemoveAgents(int agents = 1 )
        {
            throw new NotImplementedException();
        }
    }
}
