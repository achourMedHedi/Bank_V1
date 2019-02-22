using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Core.Bank
{
    public static class BankExtension
    {
        static void SaveFile(this IBank bank, string path) { }
        static IBank LoadFile(this IBank bank , string path) { return bank; }
        static void AddClients(this IBank bank /* second parameter of type Client  */) { }
        static /*client*/ void GetClient<TClientKey>(this IBank bank, TClientKey cin) where TClientKey : IComparable<TClientKey> , IEquatable<TClientKey> { }

    }
}
