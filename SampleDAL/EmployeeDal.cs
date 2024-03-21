using SampleModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDAL
{
    public class EmployeeDal
    {

        string connectionString = $"Server=DESKTOP-HGLUSKV\\SQLEXPRESS02;Database=VinithDB;Trusted_Connection=True;MultipleActiveResultSets=true";

        public List<Employee> GetEmployees(int employeeId = 0)
        {
            List<Employee> employees = new List<Employee>();
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Creating the command object
                    SqlCommand cmd = new SqlCommand("ReadEmployee", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (employeeId > 0)
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", employeeId));
                    }

                    // Opening Connection  
                    connection.Open();
                    // Executing the SQL query  
                    SqlDataReader sdr = cmd.ExecuteReader();

                    //Reading Data from Reader will give runtime error as the connection is closed
                    while (sdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = Convert.ToInt32(sdr["Id"].ToString());
                        employee.Name = sdr["Name"].ToString();
                        employee.DOB = Convert.ToDateTime(sdr["DateOfBirth"].ToString());
                        employee.Address = sdr["Address"].ToString();
                        employee.Gender = sdr["Gender"].ToString();
                        employees.Add(employee);
                    }
                    // Closing the Connection  
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return employees;
        }
        public bool DeleteEmployee(int? employeeId)
        {
            bool isDeleted = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Creating the command object
                    SqlCommand cmd = new SqlCommand("DeleteEmployee", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", employeeId));

                    // Opening Connection  
                    connection.Open();
                    // Executing the SQL query  
                    //     Executes a Transact-SQL statement against the connection and returns the number
                    //     of rows affected.
                    int k = cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        isDeleted = true;
                    }
                    // Closing the Connection  
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return isDeleted;

        }
        public int AddEmployee(Employee employee)
        {
            //TODO: GetEmployeeIdfrom DB after insert....
            int employeeId = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Creating the command object
                    SqlCommand cmd = new SqlCommand("CreateEmployee", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Gender", employee.Gender));
                    cmd.Parameters.Add(new SqlParameter("@Name", employee.Name));
                    cmd.Parameters.Add(new SqlParameter("@DateOfBirth", employee.DOB));
                    cmd.Parameters.Add(new SqlParameter("@Address", employee.Address));

                    // Opening Connection  
                    connection.Open();
                    // Executing the SQL query  
                    int k = cmd.ExecuteNonQuery();
                    //if (k != 0)
                    //{
                    //    lblmsg.Text = "Record Inserted Succesfully into the Database";
                    //    lblmsg.ForeColor = System.Drawing.Color.CornflowerBlue;
                    //}
                    // Closing the Connection  
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return employeeId;
        }
        public bool UpdateEmployee(Employee employee)
        {
            bool isUpdated = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Creating the command object
                    SqlCommand cmd = new SqlCommand("UpdateEmployee", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Gender", employee.Gender));
                    cmd.Parameters.Add(new SqlParameter("@Name", employee.Name));
                    cmd.Parameters.Add(new SqlParameter("@DOB", employee.DOB));
                    cmd.Parameters.Add(new SqlParameter("@Address", employee.Address));
                    cmd.Parameters.Add(new SqlParameter("@Id", employee.Id));

                    // Opening Connection  
                    connection.Open();
                    // Executing the SQL query  
                    int k = cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        isUpdated = true;
                    }
                    // Closing the Connection  
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return isUpdated;
        }

    }
}
