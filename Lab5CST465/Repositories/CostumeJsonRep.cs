using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Lab5CST465.Objects;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Lab5CST465.Repositories
{
    public class CostumeJsonRep : ICostume
    {
        TreatersSettings _settings;
        public CostumeJsonRep(IOptions<TreatersSettings> mysettings)
        {
            _settings = mysettings.Value;
        }
        public void Delete(int cost)
        {
            if (_settings.AllowCandyDelete)
            {
                List<Costume> list = GetList();
                foreach (var can in list)
                {
                    if (can.ID == cost)
                        list.Remove(can);
                }
                if (list.Count() != 0)
                {
                    using (StreamWriter sw = new StreamWriter(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Costume.json")))
                    {
                        string filedata = JsonConvert.SerializeObject(list);
                        sw.Write(filedata);
                    }
                }
                else
                {
                    throw new Exception("Cannot Delete From empty list");
                }
            }
            else
            {
                throw new Exception("Deleting candy not allowed\n");
            }
        }

        public List<Costume> GetList()
        {
            List<Costume> lit = null;

            // JsonSerializer serializer = new JsonSerializer();

            // serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamReader sr = new StreamReader(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Costume.json")))
            {
                string filedata = sr.ReadToEnd();
                lit = JsonConvert.DeserializeObject<List<Costume>>(filedata);
            }
            if (lit == null)
            {
                lit = new List<Costume>();
            }
            return lit;
        }

        public void Insert(Costume cand)
        {
            List<Costume> list = GetList();
            if (list.Count() != 0)
                cand.ID = list.Max(C => C.ID) + 1;
            else cand.ID = 1;
            list.Add(cand);
            using (StreamWriter sw = new StreamWriter(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Costume.json")))
            {
                string filedata = JsonConvert.SerializeObject(list);
                sw.Write(filedata);
            }
        }
    }
}
