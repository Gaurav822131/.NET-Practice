using System;

namespace QuickMart
{
    public class TransactionService
    {
        public static SaleTransaction? LastTransaction;
        public static bool HasLastTransaction = false;

        // 1. CREATE NEW TRANSACTION


        public static void CreateNewTransaction()
        {
            SaleTransaction transaction = new SaleTransaction();

            Console.Write("Enter Invoice No: ");
            transaction.InvoiceNo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(transaction.InvoiceNo))
            {
                Console.WriteLine("Invoice No cannot be null.");
                return;
            }

            Console.Write("Enter Customer Name: ");
            transaction.CustomerName = Console.ReadLine();
            //using conditional to check for edge cases and to check for invalid inputs 

            if (!IsAlphabetical(transaction.CustomerName))
            {
                Console.WriteLine("Customer name can contain only alphabets.");
                return;
            }

            Console.Write("Enter Item Name: ");
            transaction.ItemName = Console.ReadLine();

            if (!IsAlphabetical(transaction.ItemName))
            {
                Console.WriteLine("Item name can contain only alphabets.");
                return;
            }

            Console.Write("Enter Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int qty) || qty <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero.");
                return;
            }
            transaction.Quantity = qty;

            Console.Write("Enter Purchase Amount (total): ");
            if (!double.TryParse(Console.ReadLine(), out double purchase) || purchase <= 0)
            {
                Console.WriteLine("Purchase amount must be greater than zero.");
                return;
            }
            transaction.PurchaseAmount = purchase;

            Console.Write("Enter Selling Amount (total): ");
            if (!double.TryParse(Console.ReadLine(), out double selling) || selling < 0)
            {
                Console.WriteLine("Selling amount cannot be negative.");
                return;
            }
            transaction.SellingAmount = selling;

            // PROFIT OR LOSS LOGIC
            if (transaction.SellingAmount > transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "PROFIT";
                transaction.ProfitOrLossAmount =transaction.SellingAmount - transaction.PurchaseAmount;
            }
            else if (transaction.SellingAmount < transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "LOSS";
                transaction.ProfitOrLossAmount = transaction.PurchaseAmount - transaction.SellingAmount;
            }
            else
            {
                transaction.ProfitOrLossStatus = "BREAK-EVEN";
                transaction.ProfitOrLossAmount = 0;
            }

            transaction.ProfitMarginPercent =(transaction.ProfitOrLossAmount / transaction.PurchaseAmount) * 100;

            LastTransaction = transaction;
            HasLastTransaction = true;

            Console.WriteLine();
            Console.WriteLine("Transaction saved successfully.");
            Console.WriteLine($"Status: {transaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {transaction.ProfitOrLossAmount}");
            Console.WriteLine($"Profit Margin (%): {transaction.ProfitMarginPercent}");
        }

        // 2. VIEW LAST TRANSACTION
        public static void ViewLastTransaction()
        {
            if (!HasLastTransaction || LastTransaction == null)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            Console.WriteLine("\nLast Transaction:");
            Console.WriteLine($"InvoiceNo: {LastTransaction.InvoiceNo}");
            Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
            Console.WriteLine($"Item: {LastTransaction.ItemName}");
            Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
            Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount}");
            Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount}");
            Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount}");
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent}");
        }

        // 3. RECALCULATE PROFIT OR LOSS
        public static void RecalculateProfitLoss()
        {
            if (!HasLastTransaction || LastTransaction == null)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            if (LastTransaction.SellingAmount > LastTransaction.PurchaseAmount)
            {
                LastTransaction.ProfitOrLossStatus = "PROFIT";
                LastTransaction.ProfitOrLossAmount =
                    LastTransaction.SellingAmount - LastTransaction.PurchaseAmount;
            }
            else if (LastTransaction.SellingAmount < LastTransaction.PurchaseAmount)
            {
                LastTransaction.ProfitOrLossStatus = "LOSS";
                LastTransaction.ProfitOrLossAmount =
                    LastTransaction.PurchaseAmount - LastTransaction.SellingAmount;
            }
            else
            {
                LastTransaction.ProfitOrLossStatus = "BREAK-EVEN";
                LastTransaction.ProfitOrLossAmount = 0;
            }

            LastTransaction.ProfitMarginPercent =
                (LastTransaction.ProfitOrLossAmount / LastTransaction.PurchaseAmount) * 100;

            Console.WriteLine("\nRecalculated Profit/Loss:");
            Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount}");
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent}");
        }

//Mthod to check for null or white spaces and in customer name to check for that the name does not contain numerical value
        private static bool IsAlphabetical(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            foreach (char ch in value)
            {
                if (!char.IsLetter(ch) && ch != ' ')
                    return false;
            }
            return true;
        }
    }
}
