using System;
using System.Collections.Generic;
namespace LedgerExpense;
class Program
{
    static void Main()
    {
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        // INCOME INPUT

        IncomeTransaction income = new IncomeTransaction();

        Console.WriteLine("Enter Income Id:");
        income.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Income Amount:");
        income.Amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Income Description:");
        income.Description = Console.ReadLine();

        Console.WriteLine("Enter Income Source:");
        income.Source = Console.ReadLine();

        income.Date = DateTime.Today;

        incomeLedger.AddEntry(income);

        //NUMBER OF EXPENSE


        Console.WriteLine("\nEnter Number of Expenses:");
        int n = Convert.ToInt32(Console.ReadLine());


        //INPUT FOR THE EXPNESES
        for (int i = 1; i <= n; i++)
        {
            ExpenseTransaction expense = new ExpenseTransaction();

            Console.WriteLine("\nEnter Expense " + i + " Id:");
            expense.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Expense Amount:");
            expense.Amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Expense Description:");
            expense.Description = Console.ReadLine();

            Console.WriteLine("Enter Expense Category:");
            expense.Category = Console.ReadLine();

            expense.Date = DateTime.Today;

            expenseLedger.AddEntry(expense);
        }


        double totalIncome = incomeLedger.CalculateTotal();
        double totalExpense = expenseLedger.CalculateTotal();

        Console.WriteLine("\nTotal Earnings: $" + totalIncome);
        Console.WriteLine("Total Expenditure: $" + totalExpense);
        double remain=(totalIncome - totalExpense);
        if(totalExpense<totalIncome){
        Console.WriteLine("Remaining Balance: $" + remain);
        }
        else
        {
            System.Console.WriteLine("You are in debt of: "+remain);
        }


        //POLYMORPHIC OUTPUT/ITERATIVE OUTPUT

        
        Console.WriteLine("\nTransaction Summary:");

        List<Transaction> allTransactions = new List<Transaction>();

        foreach (IncomeTransaction i in incomeLedger.GetAll())
        {
            allTransactions.Add(i);
        }

        foreach (ExpenseTransaction e in expenseLedger.GetAll())
        {
            allTransactions.Add(e);
        }

        foreach (Transaction t in allTransactions)
        {
            Console.WriteLine(t.GetSummary());
        }
    }
}
