using System;

namespace LedgerExpense;

public class ExpenseTransaction : Transaction
{
    public string?Category { get; set; }

    public override string GetSummary()
    {
        return "Expense | Category: " + Category + " | Amount: $" + Amount;
    }
}

