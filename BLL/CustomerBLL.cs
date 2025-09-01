using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerModuleManager.DAL;
using CustomerModuleWinForms.Models;

namespace CustomerModuleManager.BLL
{
    class CustomerBLL
    {
        CustomerDAL dal = new CustomerDAL();

        public DataTable GetCustomers() => dal.GetAllCustomers();
        public int Add(Customer c) => dal.AddCustomer(c);
        public int Update(Customer c) => dal.UpdateCustomer(c);
        public int Delete(int id) => dal.DeleteCustomer(id);
    }
}
