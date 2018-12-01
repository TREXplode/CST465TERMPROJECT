using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Models;
using Newtonsoft.Json;

namespace Midterm.Repositories
{
    public class TestQuestionDB : IQuestion
    {

        public TestQuestionDB()
        {
            
        }

        public List<TestQuestion> GetList()
        {
            List<TestQuestion> tlist = null;
            using (StreamReader sr = new StreamReader(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Midterm.json")))
            {
                string filedata = sr.ReadToEnd();
                tlist = JsonConvert.DeserializeObject<List<TestQuestion>>(filedata);
                List<TestQuestion> temp = new List<TestQuestion>();
                foreach(TestQuestion quest in tlist)
                {
                    if(quest.type == "MultipleChoiceQuestion")
                    {
                        TestQuestion q = new MultipleChoiceQuestion();
                        q.id = quest.id;
                        q.question = quest.question;
                        q.choices = quest.choices;
                        q.type = quest.type;
                        q.answer = quest.answer;
                        temp.Add(q);
                    }
                    else if(quest.type == "LongAnswerQuestion")
                    {
                        TestQuestion q = new LongQuestion();
                        q.id = quest.id;
                        q.question = quest.question;
                        q.choices = quest.choices;
                        q.type = quest.type;
                        q.answer = quest.answer;
                        temp.Add(q);
                    }
                    else if(quest.type == "ShortAnswerQuestion")
                    {
                        TestQuestion q = new ShortQuestion();
                        q.id = quest.id;
                        q.question = quest.question;
                        q.choices = quest.choices;
                        q.type = quest.type;
                        q.answer = quest.answer;
                        temp.Add(q);
                    }
                    else if (quest.type == "TrueFalseQuestion")
                    {
                        TestQuestion q = new TrueFalseQuestion();
                        q.id = quest.id;
                        q.question = quest.question;
                        q.choices = quest.choices;
                        q.type = quest.type;
                        q.answer = quest.answer;
                        temp.Add(q);
                    }
                }
                tlist = temp;
            }
            if (tlist == null)
            {
                tlist = new List<TestQuestion>();
            }
            return tlist;
        }

        public void SaveAnswers(List<TestQuestion> test)
        {
            List<TestQuestion> thetest = GetList();
            for(int i = 0; i < thetest.Count; i++)
            {
                if(thetest[i].id == test[i].id)
                {
                    thetest[i].answer = test[i].answer;
                }
            }
            using (StreamWriter sw = new StreamWriter(System.IO.Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Midterm.json")))
            {
                string filedata = JsonConvert.SerializeObject(thetest);
                sw.Write(filedata);
            }
        }
    }
}
