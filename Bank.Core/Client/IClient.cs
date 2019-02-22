using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bank.Core.Client
{
    public interface IClient<TClientKey,TAccountKey>
    {
        TClientKey Cin { get; set; } 
        string Name { get; set; } 
        IList<int> Accounts { get; set; } 
        IList<Thread> Agents { get; set; }
        IEnumerable GetAllAccounts();
        void CreateAccount(/*IAccount*/);
        void CloseAccount(/*IAccount*/);
        void /*return Account*/ GetAccount(TAccountKey accountNumber);

    }
}
