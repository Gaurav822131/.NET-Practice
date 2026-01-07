using System;
using System.Collections.Generic;

namespace LedgerExpense;



public class Ledger<T> where T : Transaction
{
    private List<T> transactions = new List<T>();

    public void AddEntry(T entry)
    {
        transactions.Add(entry);
    }

    public double CalculateTotal()
    {
        double total = 0;
        for (int i = 0; i < transactions.Count; i++)
        {
            total = total + transactions[i].Amount;
        }
        return total;
    }

    public List<T> GetAll()
    {
        return transactions;
    }
}



