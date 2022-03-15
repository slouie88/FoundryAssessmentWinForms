using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FoundryAssessmentWinForms.Data
{
    public class EmployeesDAL
    {
        // Create the connection to the database.
        SqlConnection con = new SqlConnection(Properties.Settings.Default.connString);
        DataTable dt = new DataTable();

        ///<summary>
        /// Read all employees from the Employees table into a data table to be bound into a data grid view.
        ///</summary>
        public DataTable Read()
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();

                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand("select * from Employees", con);
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                sqlDA.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        ///<summary>
        /// Read an employee by their Id from the Employees table into a data table to be bound into a data grid view.
        ///</summary>
        public DataTable Read(int Id)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();

                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand("select * from Employees where id= " + Id + "", con);
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                sqlDA.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }

        ///<summary>
        /// Add a new employee to the Employees table.
        /// </summary>
        public void Add(string name)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"INSERT Employees (name) VALUES ('{name}')", con);
                sqlDA.InsertCommand = command;
                sqlDA.InsertCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        ///<summary>
        /// Delete an employee from the Employees table.
        ///</summary>
        public void Delete(Guid Id)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"DELETE FROM Employees WHERE id = '{Id}'", con);
                sqlDA.DeleteCommand = command;
                sqlDA.DeleteCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        ///<summary>
        /// Update an employee's name in the Employees table.
        /// </summary>
        public void Update(Guid Id, string newName)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"UPDATE Employees SET name = '{newName}' WHERE id = '{Id}'", con);
                sqlDA.UpdateCommand = command;
                sqlDA.UpdateCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
    }
}
