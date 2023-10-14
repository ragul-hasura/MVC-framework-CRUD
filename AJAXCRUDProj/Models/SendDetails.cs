using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace AJAXCRUDProj.Models
{
    public class SendDetails
    {
        public string InsertData(Employee emp)
        {
            try 
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

                // define INSERT query with parameters
                string query = "INSERT INTO dbo.EmployeeDetails(Name, Age, State, Country)" +
                    " VALUES (" + emp.Name + "," + emp.Age + "," + emp.State + "," + emp.Country + ")";
                                                      

                // create connection and command
                using (SqlConnection cn = new SqlConnection(cs))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    //cmd.Parameters.Add("@EmpId", SqlDbType.VarChar, 50).Value = emp.Name;
                    //cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = emp.EmpId;
                    //cmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = emp.Age;
                    //cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = emp.State;
                    //cmd.Parameters.Add("@Age", SqlDbType.Int).Value = emp.Country;
                    //cmd.Parameters.Add("@Gender", SqlDbType.VarChar, 50).Value = emp.Salary;

                    // open connection, execute INSERT, close connection
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return "Not ok ==>" + ex.ToString();
            }
           
        }
    }
}