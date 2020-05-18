using Newtonsoft.Json;
using PraticeReadJSonFile.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace PraticeReadJSonFile.Service
{
    class JSonService
    {
        private string input;
        private string output;
        private Payload payload;
        private Result result;
        public JSonService(string input, string output)
        {
            this.input = input;
            this.output = output;
        }
        public void ReadJSon()
        {
            payload = new Payload()
            {
                Students = new List<Student>()
            };
            using(StreamReader sr = File.OpenText(this.input))
            {
                var obj = sr.ReadToEnd();
                payload = JsonConvert.DeserializeObject<Payload>(obj);
              
            }
        }
        public void WriteJSon()
        {
            ProcessData();
            using (StreamWriter sw = File.CreateText(this.output))
            {
                var data = JsonConvert.SerializeObject(result.results.Values);

                sw.Write(data);
            }
        }
        public void ProcessData()
        {
            result = new Result()
            {
                results = new SortedList<double,Response>()
            };
            foreach(var item in payload.Students)
            {
                var res = new Response()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Gender =bool.Parse(item.Gender) ? "Nam" :"Nữ",
                    Level = item.Level,
                    AverageScore = item.Average(),
                    Rank = item.Rank()

                };
                 
                 result.results.Add(res.AverageScore,res);
            }
           
        }
    }
}
