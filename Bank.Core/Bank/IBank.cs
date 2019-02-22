using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bank.Core.Bank
{
    public interface IBank
    {
        string Name { get; set; } 
        string SwiftCode { get; set; } 
        IList Clients { get; set; }
        IEnumerable GetAllTransactions();
        IEnumerable GetAllAccounts();
        void AddTransaction(); // TODO : add transaction in parameter 
        void AddAgents(int agents);
        void RemoveAgents(int agents); 
    }
}
