using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5CST465.Objects;
using Lab5CST465;
using System.Data;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;

namespace Lab5CST465.Repositories
{
    public class CandyDB : ICandy
    {
        public List<Candy> GetList()
        {
            List<Candy> lit = new List<Candy>();

            //lit = Cand_GetList;
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=master;"))
            {
                using (SqlCommand command = new SqlCommand("Candy_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Candy cand = new Candy();
                            cand.name = reader["ProductName"].ToString();
                            cand.ID = (int)reader["ID"];
                            lit.Add(cand);
                        }
                    }
                } 
            }
            return lit;
        }
        public void Insert(Candy cand)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=master;"))
            {
                using (SqlCommand command = new SqlCommand("Candy_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@ProductName", cand.name);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int cand)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=master;"))
            {
                using (SqlCommand command = new SqlCommand("Candy_Delete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", cand);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
