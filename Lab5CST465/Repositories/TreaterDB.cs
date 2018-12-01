using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Lab5CST465.Objects;
using Microsoft.Extensions.Options;

namespace Lab5CST465.Repositories
{
    public class TreaterDB : ITreater
    {
        TreatersSettings _settings;
        public TreaterDB(IOptions<TreatersSettings> settings)
        {
            _settings = settings.Value;
        }
        public List<Treater> GetList()
        {
            List<Treater> lit = new List<Treater>();

            //lit = Cand_GetList;
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=master;"))
            {
                using (SqlCommand command = new SqlCommand("Treaters_GetList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Treater trea = new Treater();
                            trea.Name = reader["Name"].ToString();
                            trea.FavCand = (int)reader["FavoriteCandyID"];
                            trea.Cost = (int)reader["CostumeID"];
                            trea.ID = (int)reader["ID"];

                            lit.Add(trea);
                        }
                    }
                }
            }
            return lit;
        }

        public void Insert(Treater treat)
        {
            using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=master;"))
            {
                using (SqlCommand command = new SqlCommand("Treaters_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@Name", treat.Name);
                    command.Parameters.AddWithValue("@Candy", treat.FavCand);
                    command.Parameters.AddWithValue("@Costume", treat.Cost);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
