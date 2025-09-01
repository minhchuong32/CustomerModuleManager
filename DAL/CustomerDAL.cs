using CustomerModuleWinForms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerModuleManager.DAL
{
    class CustomerDAL
    {

        // select all customer 
        public DataTable GetAllCustomers()
        {
            return DbHelper.ExecuteQuery("SELECT * FROM Customer");
        }

        // insert customer 
        public int AddCustomer(Customer c)
        {
            string sql = "INSERT INTO Customer(FullName, Phone, Email, Gender, BirthDate, Address) " +
                         "VALUES(@FullName,@Phone,@Email,@Gender,@BirthDate,@Address)";
            SqlParameter[] pars = {
                new SqlParameter("@FullName", c.FullName),
                new SqlParameter("@Phone", c.Phone),
                new SqlParameter("@Email", c.Email),
                new SqlParameter("@Gender", c.Gender),
                new SqlParameter("@BirthDate", c.BirthDate),
                new SqlParameter("@Address", c.Address)
            };
            return DbHelper.ExecuteNonQuery(sql, pars);
        }

        // update customer
        public int UpdateCustomer(Customer c)
        {
            string sql = "UPDATE Customer SET FullName=@FullName, Phone=@Phone, Email=@Email, Gender=@Gender, BirthDate=@BirthDate, Address=@Address WHERE CustomerID=@ID";
            SqlParameter[] pars = {
                new SqlParameter("@FullName", c.FullName),
                new SqlParameter("@Phone", c.Phone),
                new SqlParameter("@Email", c.Email),
                new SqlParameter("@Gender", c.Gender),
                new SqlParameter("@BirthDate", c.BirthDate),
                new SqlParameter("@Address", c.Address),
                new SqlParameter("@ID", c.CustomerID)
            };
            return DbHelper.ExecuteNonQuery(sql, pars);
        }

        // delete customer 
        public int DeleteCustomer(int id)
        {
            string sql = "DELETE FROM Customer WHERE CustomerID=@ID";
            SqlParameter[] pars = { new SqlParameter("@ID", id) };
            return DbHelper.ExecuteNonQuery(sql, pars);
        }

    }
}
