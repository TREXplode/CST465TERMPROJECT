using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Models;
using Midterm.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Midterm.Repositories
{
    public class TestQuestionBDRepository : ITestRepository
    {
        private TestSettings _Settings;
        public TestQuestionBDRepository(IOptions<TestSettings> testconfig)
        {
            _Settings = testconfig.Value;
            _Settings.DatabaseConfigFile = "JSON/appsettings.json";
        }
        public string GetConnectionString()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(_Settings.DatabaseConfigFile, optional: false, reloadOnChange: true)
            .AddJsonFile("/JSON/Midterm.json", optional: false, reloadOnChange: true);


            var configuration = builder.Build();

            return configuration.GetConnectionString("Midterm");

        }
        public TestQuestion Get(int id)
        {
            TestQuestion question = null;
            string Qtype;
            //List<TestQuestion> questlist = new List<TestQuestion>();
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("QuestGet", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            Qtype = (string)reader["QType"];
                            if (Qtype == "TrueFalseQuestion")
                            {
                                question = new TrueFalseQuestion();
                                question.ID = (int)reader["ID"];
                                question.Question = (string)reader["Question"];
                                //questlist.Append(question);
                            }
                            else if (Qtype == "ShortAnswerQuestion")
                            {
                                question = new ShortQuestion();
                                question.ID = (int)reader["ID"];
                                question.Question = (string)reader["Question"];
                                //questlist.Append(question);
                            }
                            else if (Qtype == "LongAnswerQuesiton")
                            {
                                question = new LongQuestion();
                                question.ID = (int)reader["ID"];
                                question.Question = (string)reader["Question"];
                                //questlist.Append(question);
                            }
                            else if (Qtype == "MultipleChoiceQuestion")
                            {
                                question = new MultipleChoiceQuestion();
                                question.ID = (int)reader["ID"];
                                question.Question = (string)reader["Question"];
                                //question.Choice = (string[])reader["Choice"];
                                //questlist.Append(question);
                            }
                        }
                    }
                }
            }
                    return question;
        }
        public string GetAnswer(TestQuestion question)
        {
            return question.Answer;
        }
        public List<TestQuestion> GetList()
        {
            string Qtype;
            List<TestQuestion> questlist = new List<TestQuestion>();
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("QuestList_Get", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@ID", ID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Qtype = (string)reader["QType"];
                            if (Qtype == "TrueFalseQuestion")
                            {
                                TrueFalseQuestion question = new TrueFalseQuestion();
                                question.ID = (int)reader["ID"];
                                question.Question = (string)reader["Question"];
                                questlist.Append(question);
                            }
                            else if (Qtype == "ShortAnswerQuestion")
                            {
                                ShortQuestion question = new ShortQuestion();
                                question.ID = (int)reader["ID"];
                                question.Question = (string)reader["Question"];
                                questlist.Append(question);
                            }
                            else if (Qtype == "LongAnswerQuesiton")
                            {
                                LongQuestion question = new LongQuestion();
                                question.ID = (int)reader["ID"];
                                question.Question = (string)reader["Question"];
                                questlist.Append(question);
                            }
                            else if (Qtype == "MultipleChoiceQuestion")
                            {
                                MultipleChoiceQuestion question = new MultipleChoiceQuestion();
                                question.ID = (int)reader["ID"];
                                question.Question = (string)reader["Question"];
                                question.Choice = (string[])reader["Choice"];
                                questlist.Append(question);
                            }
                        }
                        return questlist;
                    }
                }
            }
        }
        public void SaveAnswer(TestQuestion question)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("Store_Answers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@Answer", question.Answer);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
