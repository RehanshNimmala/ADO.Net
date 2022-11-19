using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsAndDataBinding
{
    public class ConnectToNW
    {
        NorthwindClass nWDataClass= new NorthwindClass();
        public string LastError { get; set; }

        public DataTable GetCustomersData()
        {
            try
            {
                string selectQuery = "$@ Select CustomerID,CompantName, ContactName, ContactTitle, City from customers where CustomerID like'A%'" +
                    "order by CompanyName";
                DataTable customersTable = nWDataClass.NWCustomersQuery(selectQuery);
                return customersTable;
            }
            catch(Exception ex)
            {
                LastError= ex.Message;
                return null;
            }//end catch
        }//end GetCustomersData

        public DataTable GetOrdersData(string CustomerID)
        {
            string sqlQuery = "$@select c.customerID, c.CompanyName, o.orderID. productName, s.CompanyName as 'Supplier', od.UnitPrice, Quantity" +
                " from Customers c join orders o on (o.CustomerID=c.CustomerID) join[OrderDetails] od on (o.OrderID=od.OrderID)" +
                "join products p on (p.ProductID-od.ProductID)" +
                "join Suppliers s on (SupplierID=p.ProductID)" +
                "where c.CustomerID=@customerID ";

            SqlParameter param1 = new SqlParameter("@CustomerID", SqlDbType.NChar);//The SqlDBType must be what dta type for the column is.
            param1.Value=CustomerID;
            try
            {
                return nWDataClass.JoinQuery(sqlQuery, CommandType.Text, param1);

            }
            catch(Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
    }
}
