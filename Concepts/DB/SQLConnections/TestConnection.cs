using Concepts.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.DB.SQLConnections
{
    //https://dotnettutorials.net/lesson/ado-net-sqldatareader/#:~:text=The%20ADO.NET%20SqlDataReader%20class%20in%20C%23%20is%20used%20to,and%20read%20the%20previous%20record.
    public class TestConnection
    {
        public void Exec()
        {
            ScenarioTwo();
        }

        private void ScenarioOne()
        {
            var students = GetDummyValues();
            PrintStudents(students);
        }

        private void ScenarioTwo()
        {
            var students = GetStudentsFromDB();
            PrintStudents(students);
        }

        private List<Student> GetStudentsFromDB()
        {
            List<Student> students = new List<Student>();
            try
            {
                // string connectionString = configuration.GetConnectionString("DefaultConnection");
                //string ConString = @"data source=.; database=StudentDB; integrated security=SSPI";
                //string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                string connectionString = $"Server=DESKTOP-HGLUSKV\\SQLEXPRESS02;Database=Student;Trusted_Connection=True;MultipleActiveResultSets=true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Creating the command object
                    SqlCommand cmd = new SqlCommand("select * from student", connection);
                    // Opening Connection  
                    connection.Open();
                    // Executing the SQL query  
                    SqlDataReader sdr = cmd.ExecuteReader();

                    //Reading Data from Reader will give runtime error as the connection is closed
                    while (sdr.Read())
                    {
                        Student student = new Student();
                        student.Id = Convert.ToInt32(sdr["ID"].ToString());
                        student.FirstName = sdr["FirstName"].ToString();
                        student.LastName = sdr["LastName"].ToString();
                        student.Department = sdr["Department"].ToString();

                        students.Add(student);
                    }
                    // Closing the Connection  
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return students;
        }

        private List<Student> GetDummyValues()
        {
            Student student1 = new Student() { FirstName = " Vinith", LastName = "Ravi" };
            Student student2 = new Student() { FirstName = " Vishnu" };
            Student student3 = new Student() { FirstName = " Vivek" };
            //students.Add(student1);
            //students.Add(student2);
            //students.Add(student3);
            //List<Student> students = new List<Student>() { student1, student2, student3};
            //return students;
            return new List<Student>() { student1, student2, student3 };
        }

        private void PrintStudents(List<Student> students)
        {

            foreach (Student student in students)
            {
                Console.WriteLine($"Id : {student.Id}");
                Console.WriteLine($"FirstName : {student.FirstName}");
                Console.WriteLine($"LastName : {student.LastName}");
                Console.WriteLine($"Department : {student.Department}");
            }
        }
    }
}
