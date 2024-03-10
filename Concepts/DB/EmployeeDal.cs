using Concepts.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.DB
{
    public class EmployeeDal
    {

        string connectionString = $"Server=DESKTOP-HGLUSKV\\SQLEXPRESS02;Database=VinithDB;Trusted_Connection=True;MultipleActiveResultSets=true";

        public List<Employee> GetEmployees(string genderType = "Male")
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Creating the command object
                    SqlCommand cmd = new SqlCommand("ReadEmployee", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Gender", genderType));

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
                        employee.Age = Convert.ToInt32(sdr["Age"].ToString());
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
                    cmd.Parameters.Add(new SqlParameter("@Age", employee.Age));
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

    }
}
