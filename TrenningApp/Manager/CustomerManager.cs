using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrenningApp.Entity;
using TrenningApp.Properties;

namespace TrenningApp.Manager
{
    internal class CustomerManager
    {
        public IEnumerable<Customer> GetCustomers(string connectionString)
        {
            IList<Customer> returnListOfCustomers = new List<Customer>();

            using (SqlConnection myConn = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCmd = new SqlCommand("select * from dbo.Customers", myConn))
                {
                    myConn.Open();

                    var sqlDataReader = sqlCmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Customer newCustomer = new Customer();

                        newCustomer.Id = int.Parse(sqlDataReader["Id"].ToString());
                        newCustomer.Name = sqlDataReader["FirstName"].ToString();

                        returnListOfCustomers.Add(newCustomer);
                    }

                    myConn.Close();
                }
            }

            return returnListOfCustomers;
        }
    }
}
