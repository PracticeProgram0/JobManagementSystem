using JobPotal.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JobPotal.DataBase_Work
{
    public class DBWork
    {
        public readonly string Conn = " Data Source=Hp;Initial Catalog=JobPotel;Integrated Security=True";
        public bool AddOrUpdateNewJob(string query)
        {
            using (SqlConnection sqlConnection=new SqlConnection(Conn))
            {
                sqlConnection.Open();
                SqlCommand cmd =new SqlCommand(query, sqlConnection);
                int result=cmd.ExecuteNonQuery();
                if (result > 0) 
                    return true;
            }
            return false;   
        }

        public List<ViewAllJobs> SelectJobs(string query)
        {
            var data = new List<ViewAllJobs>();
            using (SqlConnection sqlConnection = new SqlConnection(Conn))
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    data.Add(new ViewAllJobs()
                    {
                        JobId = Convert.ToInt32(result["JobId"]),
                        JobTitle = result["JobTitle"].ToString(),
                        CompanyName = result["CompanyName"].ToString(),
                        Location = result["Location"].ToString(),
                        SalaryRange = result["SalaryRange"].ToString(),
                        JobType = result["JobType"].ToString(),
                        JobDescription = result["JobDescription"].ToString(),
                        PostDate = result["PostDate"].ToString(),
                        FinalDate = result["FinalDate"].ToString()
                    });
                }
            }
            return data;
        }

        public ViewAllJobs SelectJobByID(string query)
        {
            var data = new ViewAllJobs();
            using (SqlConnection sqlConnection = new SqlConnection(Conn))
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    data = new ViewAllJobs()
                    {
                        JobId = Convert.ToInt32(result["JobId"]),
                        JobTitle = result["JobTitle"].ToString(),
                        JobDescription = result["JobDescription"].ToString(),
                        PostDate = result["PostDate"].ToString(),
                        FinalDate = result["FinalDate"].ToString(),
                        JobType = result["JobType"].ToString(),
                        CompanyName = result["CompanyName"].ToString(),
                        Education = result["Education"].ToString(),
                        Skills = result["Skills"].ToString(),
                        SalaryRange = result["SalaryRange"].ToString(),
                        Location = result["Location"].ToString()
                    };

                }
            }
            return data;
        }
        public bool DeleteJob(string id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Conn))
            {
                var query = $"delete from Jobs where Jobid = {id}";
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                var result = cmd.ExecuteNonQuery();
                if (result > 0) return true;
            }
            return false;
        }

        
    }
}