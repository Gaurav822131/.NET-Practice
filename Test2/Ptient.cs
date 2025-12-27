using System;
namespace MediSureClinic
{
    /// <summary>
    /// Initializing  class with given
    /// the given entities and their data types. 
    /// </summary>
    public class PatientBill
    {
        public string? BillID { get; set; }
        public string? PatientName { get; set; }
        public bool Insurance { get; set; }

        public double ConsultationFee { get; set; }
        public double LabCharges { get; set; }
        public double MedicineCharges { get; set; }

        public double TotalAmount { get; set; }
        public double DiscountedAmount { get; set; }
        public double FinalPayable { get; set; }
    }
}


