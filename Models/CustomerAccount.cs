using System;

namespace CustomerModuleWinForms.Models
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public int CustomerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime MemberSince { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Notes { get; set; }
    }
}
