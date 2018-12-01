using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5CST465.Objects;
using System.Data;
using System.Data.SqlClient;

namespace Lab5CST465.Repositories
{
    public class CostumeDB : ICostume
    {
        public List<Costume> GetList()
        {
            List<Costume> lit = new List<Costume>();

            //lit = Cand_GetList;
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=master;"))
            {
                using (SqlCommand command = new SqlCommand("Costumes_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Costume cand = new Costume();
                            cand.name = reader["Costume"].ToString();
                            cand.ID = (int)reader["ID"];
                            lit.Add(cand);
                        }
                    }
                }
            }
            return lit;
        }
        public void Insert(Costume cost)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=master;"))
            {
                using (SqlCommand command = new SqlCommand("Costumes_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@Costume", cost.name);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int cost)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=master;"))
            {
                using (SqlCommand command = new SqlCommand("Costumes_Delete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", cost);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
