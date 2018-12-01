using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab5CST465.Objects;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Lab5CST465.Repositories
{
    public class TreaterJsonRep : ITreater
    {
        TreatersSettings _settings;
        public TreaterJsonRep(IOptions<TreatersSettings> mysettings)
        {
            _settings = mysettings.Value;
        }

        public List<Treater> GetList()
        {
            List<Treater> lit = null;

            // JsonSerializer serializer = new JsonSerializer();

            // serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamReader sr = new StreamReader(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Treaters.json")))
            {
                string filedata = sr.ReadToEnd();
                lit = JsonConvert.DeserializeObject<List<Treater>>(filedata);
            }
            if(lit == null)
            {
                lit = new List<Treater>();
            }
            return lit;
        }

        public void Insert(Treater treater)
        {
            List<Treater> list = GetList();
            if (list.Count() != 0)
                treater.ID = list.Max(C => C.ID) + 1;
            else treater.ID = 1;
            list.Add(treater);
            using (StreamWriter sw = new StreamWriter(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Treaters.json")))
            {
                string filedata = JsonConvert.SerializeObject(list);
                sw.Write(filedata);
            }
        }
    }
}
