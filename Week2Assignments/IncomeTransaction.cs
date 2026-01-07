using System;

namespace LedgerExpense;

public class IncomeTransaction : Transaction
{
    public string?Source { get; set; }

    public override string GetSummary()
    {
        return "Income | Source: " + Source + " | Amount: $" + Amount;
    }
}

