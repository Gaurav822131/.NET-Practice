using System;

namespace LedgerExpense;
//ABSTRACT CLASS TRNSACTION
public abstract class Transaction : IReportable
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public double Amount { get; set; }
    public string ? Description { get; set; }

    public abstract string GetSummary();
}
