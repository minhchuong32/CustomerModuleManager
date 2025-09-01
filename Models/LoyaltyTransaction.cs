using System;

namespace CustomerModuleWinForms.Models
{
    public class LoyaltyTransaction
    {
        public int TransactionID { get; set; }
        public int CustomerID { get; set; }
        public int? InvoiceID { get; set; }
        public int PointsEarned { get; set; }
        public int PointsUsed { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Notes { get; set; }
    }
}
