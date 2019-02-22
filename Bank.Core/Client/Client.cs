using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bank.Core.Client
{
    class Client<TClientKey , TAccountKey> : IClient<TClientKey , TAccountKey> , IEquatable<IClient<TClientKey,TAccountKey>> ,IComparable<IClient<TClientKey, TAccountKey>>
        where TAccountKey : IEquatable<TAccountKey> , IComparable<TAccountKey>
        where TClientKey : IEquatable<TClientKey> , IComparable<TClientKey>
    {
        public TClientKey Cin { get; set ; } 
        public string Name { get ; set ; }
        public IList<int> Accounts { get ; set ; }
        public IList<Thread> Agents { get ; set ; }

        public Client() { }
        public Client(TClientKey cin, string name ) { Cin = cin; Name = name; Accounts = new List<int>();   }

        public void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public void CreateAccount()
        {
            throw new NotImplementedException();
        }

        public void GetAccount(TAccountKey accountNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public bool Equals(IClient<TClientKey, TAccountKey> other)
        {
            return Cin.Equals(other.Cin);
        }

        public int CompareTo(IClient<TClientKey, TAccountKey> other)
        {
            return Cin.CompareTo(other.Cin);
        }
    }
}
