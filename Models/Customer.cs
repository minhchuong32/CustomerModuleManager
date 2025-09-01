using System;

namespace CustomerModuleWinForms.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string MemberLevel { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public int LoyaltyPoints { get; set; }
    }
}
