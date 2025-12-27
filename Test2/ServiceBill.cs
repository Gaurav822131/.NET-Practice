using System;

namespace MediSureClinic
{
    public class BillService
    {
        public static PatientBill? LastBill { get; set; }
        public static bool HasLastBill { get; set; }

        public static void CreateNewBill()
        {
            PatientBill bill = new PatientBill();

            Console.Write("Enter Bill Id: ");
            bill.BillID = Console.ReadLine();
           
            Console.Write("Enter Patient Name: ");
            bill.PatientName = Console.ReadLine();

            Console.Write("Is the patient insured? (Y/N): ");
            string?ins = Console.ReadLine();
            if (ins == "Y" || ins == "y")
                bill.Insurance = true;
            else if (ins == "N" || ins == "n")
                bill.Insurance = false;
            else
            {
                Console.WriteLine("Invalid insurance input.");
                return;
            }

            Console.Write("Enter Consultation Fee: ");
            if (!double.TryParse(Console.ReadLine(), out double c) || c <= 0)
                return;
            bill.ConsultationFee = c;

            Console.Write("Enter Lab Charges: ");
            if (!double.TryParse(Console.ReadLine(), out double l) || l < 0)
                return;
            bill.LabCharges = l;

            Console.Write("Enter Medicine Charges: ");
            if (!double.TryParse(Console.ReadLine(), out double m) || m < 0)
                return;
            bill.MedicineCharges = m;

            // Calculating the bill based on the given inputs
            bill.TotalAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;
            bill.DiscountedAmount = bill.Insurance ? bill.TotalAmount * 0.10 : 0;
            bill.FinalPayable = bill.TotalAmount - bill.DiscountedAmount;

            LastBill = bill;
            HasLastBill = true;

            Console.WriteLine();
            Console.WriteLine("Bill created successfully.");
            Console.WriteLine($"Gross Amount: {bill.TotalAmount}");
            Console.WriteLine($"Discount Amount: {bill.DiscountedAmount:F2}");
            Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
            Console.WriteLine("------------------------------------------------------------");
        }

//this class will be used to view the bill which is generated or to print that bill
        public static void ViewLastBill()
        {
            if (!HasLastBill || LastBill == null)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

            PatientBill bill = LastBill;

            Console.WriteLine("\n----------- Last Bill -----------");
            Console.WriteLine($"BillId: {bill.BillID}");
            Console.WriteLine($"Patient: {bill.PatientName}");
            Console.WriteLine($"Insured: {(bill.Insurance ? "Yes" : "No")}");
            Console.WriteLine($"Consultation Fee: {bill.ConsultationFee:F2}");
            Console.WriteLine($"Lab Charges: {bill.LabCharges:F2}");
            Console.WriteLine($"Medicine Charges: {bill.MedicineCharges:F2}");
            Console.WriteLine($"Gross Amount: {bill.TotalAmount:F2}");
            Console.WriteLine($"Discount Amount: {bill.DiscountedAmount:F2}");
            Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------------------------------------------------------------");
        }

//Class for clearing the last billl generated
        public static void ClearLastBill()
        {
            LastBill = null;
            HasLastBill = false;
            Console.WriteLine("Last bill cleared.");
        }
    }
}
