using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AJAXCRUDProj.Models
{
    public class EmployeeDB
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public List<Employee> ListAll()
        {
            List<Employee> list = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetEmployeeDetails", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Employee
                    {
                        EmpId = Convert.ToInt32(reader["EmpId"]),
                        Name = reader["Name"].ToString(),
                        Age = Convert.ToInt32(reader["Age"]),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString(),
                        Salary = Convert.ToDecimal(reader["Salary"])
                    });

                }

                return list;

            }
        }

    }
}