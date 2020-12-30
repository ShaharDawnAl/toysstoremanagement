using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections;
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507

namespace WindowsFormsApplication1
{
    public class DBSQL:DbAccess
    {
        public DBSQL(string connectionString):base(connectionString)
        { }

        public int GetCustomersNumber() // Count all Customers from DB
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Customers";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public int GetCustomersNextID() // Get the last Customer AI ID from DB
        {
            int result;
            if (GetCustomersNumber() == 0)
                return -1;
            string cmdStr = "SELECT MAX(customer_id) FROM Customers";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public void DeleteCustomer(int id) // Delete Customer by ID
        {
            string cmdStr = "DELETE FROM Customers WHERE customer_id = " +id;
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                base.ExecuteSimpleQuery(command);
            }
        }

        public Customers[] GetCustomerData() // get all Customers data ordered by AI ID, from DB
        {
            DataSet ds = new DataSet();
            ArrayList customer = new ArrayList();
            string cmdStr = "SELECT * FROM Customers ORDER BY customer_id";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMulipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Customers cus = new Customers();
                cus.Ide = (int)tType[0];
                Console.WriteLine(" cus.Ide:" + cus.Ide + "\n");
                cus.Id = (int)tType[1];
                Console.WriteLine(" cus.Id:" + cus.Id + "\n");
                cus.FName = tType[2].ToString();
                Console.WriteLine(" cus.FName :" + cus.FName + "\n");
                cus.LName = tType[3].ToString();
                Console.WriteLine("cus.LName :" + cus.LName + "\n");
                cus.City = tType[4].ToString();
                Console.WriteLine("cus.City :" + cus.City + "\n");
                customer.Add(cus);
            }
            return (Customers[])customer.ToArray(typeof(Customers));
        }

        public void InsertCustomer(Customers Item) // Insert Customer to DB
        {
            string cmdStr = "INSERT INTO [Customers] (customer_id, customer_ide, customer_fname, customer_lname, customer_city) VALUES (@Id, @Ide, @FName, @LName, @City)";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                if (Item.Id == -1)
                {
                    command.Parameters.AddWithValue("@id", GetCustomersNextID() + 1);
                }    
                command.Parameters.AddWithValue("@Ide", Item.Ide);
                command.Parameters.AddWithValue("@FName", Item.FName);
                command.Parameters.AddWithValue("@LName", Item.LName);
                command.Parameters.AddWithValue("@City", Item.City);
                base.ExecuteSimpleQuery(command);
            }

        }

        public int ReturntCustomers(int ide) // Count all Customers with the given Customer ID from DB
        {
            int count=0;
            string cmdStr = "SELECT COUNT (*) FROM [Customers] WHERE customer_ide=@ide ";
            
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@ide", ide);

                count = ExecuteScalarIntQuery(command);
            }

            return count;
        }

        public int GetSuppliersNumber() // Count all Suppliers from DB
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Suppliers";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public int GetSuppliersNextID() // Get the last Supplier AI ID from DB
        {
            int result;
            if (GetSuppliersNumber() == 0)
                return -1;
            string cmdStr = "SELECT MAX(supplier_id) FROM Suppliers";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public void DeleteSupplier(int id) // Delete Supplier by ID
        {
            string cmdStr = "DELETE FROM Suppliers WHERE supplier_id = " + id;
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                base.ExecuteSimpleQuery(command);
            }
        }

        public Suppliers[] GetSupplierData() // get all Suppliers data ordered by ID, from DB
        {
            DataSet ds = new DataSet();
            ArrayList supplier = new ArrayList();
            string cmdStr = "SELECT * FROM Suppliers ORDER BY supplier_id";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMulipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Suppliers sup = new Suppliers();
                sup.Id = (int)tType[0];
                Console.WriteLine(" sup.Id:" + sup.Id + "\n");
                sup.SName = tType[1].ToString();
                Console.WriteLine(" sup.SName :" + sup.SName + "\n");
                supplier.Add(sup);
            }
            return (Suppliers[])supplier.ToArray(typeof(Suppliers));
        }

        public void InsertSupplier(Suppliers Item) // Insert Supplier to DB
        {
            string cmdStr = "INSERT INTO [Suppliers] (supplier_id, supplier_name) VALUES (@Id, @SName)";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                if (Item.Id == -1)
                {
                    command.Parameters.AddWithValue("@id", GetSuppliersNextID() + 1);
                }
                command.Parameters.AddWithValue("@SName", Item.SName);
                base.ExecuteSimpleQuery(command);
            }

        }

        public int ReturntSuppliers(string sname) // Count all Suppliers with the given Supplier name from DB
        {
            int count = 0;
            string cmdStr = "SELECT COUNT (*) FROM [Suppliers] WHERE supplier_name=@sname ";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@sname", sname);

                count = ExecuteScalarIntQuery(command);
            }

            return count;
        }

        public int GetProductsNumber() // Count all Products from DB
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Products";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public int GetProductsNextID() // Get the last Product AI ID from DB
        {
            int result;
            if (GetProductsNumber() == 0)
                return -1;
            string cmdStr = "SELECT MAX(product_id) FROM Products";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public void DeleteProduct(int id) // Delete Product by ID
        {
            string cmdStr = "DELETE FROM Products WHERE product_id = " + id;
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                base.ExecuteSimpleQuery(command);
            }
        }

        public Products[] GetProductData() // get all Products data ordered by ID, from DB
        {
            DataSet ds = new DataSet();
            ArrayList product = new ArrayList();
            string cmdStr = "SELECT * FROM Products ORDER BY product_id";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMulipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Products pro = new Products();
                pro.Id = (int)tType[0];
                Console.WriteLine(" pro.Id:" + pro.Id + "\n");
                pro.PName = tType[1].ToString();
                Console.WriteLine(" pro.PName :" + pro.PName + "\n");
                pro.SName = tType[2].ToString();
                Console.WriteLine(" pro.SName :" + pro.SName + "\n");
                product.Add(pro);
            }
            return (Products[])product.ToArray(typeof(Products));
        }

        public void InsertProduct(Products Item) // Insert Product to DB
        {
            string cmdStr = "INSERT INTO [Products] (product_id, product_name, product_sname) VALUES (@Id, @PName, @SName)";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                if (Item.Id == -1)
                {
                    command.Parameters.AddWithValue("@id", GetProductsNextID() + 1);
                }
                command.Parameters.AddWithValue("@PName", Item.PName);
                command.Parameters.AddWithValue("@SName", Item.SName);
                base.ExecuteSimpleQuery(command);
            }

        }

        public int ReturntProducts(string pname) // Count all Products with the given Product name from DB
        {
            int count = 0;
            string cmdStr = "SELECT COUNT (*) FROM [Products] WHERE product_name=@pname ";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@pname", pname);

                count = ExecuteScalarIntQuery(command);
            }

            return count;
        }

        // Orders
        public int GetOrdersNumber() // Count all Orders from DB
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Orders";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public int GetOrdersNextID() // Get the last Order AI ID from DB
        {
            int result;
            if (GetOrdersNumber() == 0)
                return -1;
            string cmdStr = "SELECT MAX(order_id) FROM Orders";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public void DeleteOrder(int id) // Delete Order by ID
        {
            string cmdStr = "DELETE FROM Orders WHERE order_id = " + id;
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                base.ExecuteSimpleQuery(command);
            }
        }

        public Orders[] GetOrderData() // get all Orders data ordered by ID, from DB
        {
            DataSet ds = new DataSet();
            ArrayList order = new ArrayList();
            string cmdStr = "SELECT * FROM Orders ORDER BY order_id";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMulipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Orders ord = new Orders();
                ord.Id = (int)tType[0];
                Console.WriteLine(" ord.Id:" + ord.Id + "\n");
                ord.CId = (int)tType[1];
                Console.WriteLine(" ord.CId:" + ord.CId + "\n");
                ord.PName = tType[2].ToString();
                Console.WriteLine(" ord.PName :" + ord.PName + "\n");
                ord.SName = tType[3].ToString();
                Console.WriteLine(" ord.SName :" + ord.SName + "\n");
                ord.CCity = tType[4].ToString();
                Console.WriteLine(" ord.CCity :" + ord.CCity + "\n");
                order.Add(ord);
            }
            return (Orders[])order.ToArray(typeof(Orders));
        }

        public void InsertOrder(Orders Item) // Insert Order to DB
        {
            string cmdStr = "INSERT INTO [Orders] (order_id, order_cid, order_pname, order_sname, order_ccity) VALUES (@Id, @Cid, @PName, @SName, @CCity)";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                if (Item.Id == -1)
                {
                    command.Parameters.AddWithValue("@Id", GetOrdersNextID() + 1);
                }
                command.Parameters.AddWithValue("@Cid", Item.CId);
                command.Parameters.AddWithValue("@PName", Item.PName);
                command.Parameters.AddWithValue("@SName", Item.SName);
                command.Parameters.AddWithValue("@CCity", Item.CCity);
                base.ExecuteSimpleQuery(command);
            }
        }

        public int ReturntOrders(string pname) // Count all Order with the given Order Product name from DB
        {
            int count = 0;
            string cmdStr = "SELECT COUNT (*) FROM [Orders] WHERE order_pname=@pname ";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@pname", pname);

                count = ExecuteScalarIntQuery(command);
            }

            return count;
        }

        public string GetSupplierByPName(string pname) // Get the Product Supplier name by product name from DB
        {
            string result;
            string cmdStr = "SELECT product_sname FROM Products WHERE product_name = @pname";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@pname", pname);

                result = ExecuteStringQuery(command);
            }

            return result;
        }

        public string GetCityByCID(int cid) // Get the City of the customer by Customer ID from DB
        {
            string result;
            string cmdStr = "SELECT customer_city FROM Customers WHERE customer_ide = @cid";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@cid", cid);

                result = ExecuteStringQuery(command);
            }

            return result;
        }

        public int GetSearchOrdersNumber(int cid) // Count all orders made by given Customer ID from DB
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Orders WHERE order_cid = @cid";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@cid", cid);
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public Orders[] GetSearchOrderData(int cid) // Get all orders made by given Customer ID from DB
        {
            DataSet ds = new DataSet();
            ArrayList order = new ArrayList();
            string cmdStr = "SELECT * FROM Orders WHERE order_cid = @cid ORDER BY order_id";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@cid", cid);
                ds = GetMulipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Orders ord = new Orders();
                ord.Id = (int)tType[0];
                Console.WriteLine(" ord.Id:" + ord.Id + "\n");
                ord.CId = (int)tType[1];
                Console.WriteLine(" ord.CId:" + ord.CId + "\n");
                ord.PName = tType[2].ToString();
                Console.WriteLine(" ord.PName :" + ord.PName + "\n");
                ord.SName = tType[3].ToString();
                Console.WriteLine(" ord.SName :" + ord.SName + "\n");
                ord.CCity = tType[4].ToString();
                Console.WriteLine(" ord.CCity :" + ord.CCity + "\n");
                order.Add(ord);
            }
            return (Orders[])order.ToArray(typeof(Orders));
        }

        public int GetSearchSuppliersNumber(string sname) // Count all Products supplied by given Supplier name from DB
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Products WHERE product_sname = @sname";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@sname", sname);
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        public Products[] GetSearchSupplierData(string sname) // Get all Products supplied by given Supplier name from DB
        {
            DataSet ds = new DataSet();
            ArrayList product = new ArrayList();
            string cmdStr = "SELECT * FROM Products WHERE product_sname = @sname ORDER BY product_id";

            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@sname", sname);
                ds = GetMulipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)
            {
                Products pro = new Products();
                pro.Id = (int)tType[0];
                Console.WriteLine(" pro.Id:" + pro.Id + "\n");
                pro.PName = tType[1].ToString();
                Console.WriteLine(" pro.PName :" + pro.PName + "\n");
                pro.SName = tType[2].ToString();
                Console.WriteLine(" pro.SName :" + pro.SName + "\n");
                product.Add(pro);
            }
            return (Products[])product.ToArray(typeof(Products));
        }
    }
}
