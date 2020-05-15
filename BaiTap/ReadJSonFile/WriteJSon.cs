using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ReadJSonFile
{
    class WriteJSon
    {
        public int totalofmath { get; set; }
        public int totalofchem { get; set; }
        public int totalofphy { get; set; }
        public string MulOfMath { get; set; }
        public string MulOfChem { get; set; }
        public string MulOfPhy { get; set; }
        public string src { get; set; }
        public string inpath { get; set; }
        public string outpath1 { get; set; }
        public string outpath2 { get; set; }
        public WriteJSon(string src, string inpath ,string outpath1, string outpath2)
        {
            this.src = src;
            this.inpath = inpath;
            this.outpath1 = outpath1;
            this.outpath2 = outpath2;
        }
        public void Start()
        {
            ReadDataJSon();
            WriteDataJSOn();
            
        }
        public void WriteDataJSOn()
        {
            PayLoadToTal newdata = new PayLoadToTal()
            {
                TotalOfMath = totalofmath,
                TotalOfChem = totalofchem,
                TotalOfPhy = totalofphy
            };
            PayLoadMul newdata2 = new PayLoadMul()
            {
                MulofMath = MulOfMath,
                MulofChem = MulOfChem,
                MulOfPhy = MulOfPhy
            };
            using (StreamWriter sw = File.CreateText($@"{src}\{outpath1}"))
            {
                var obj = JsonConvert.SerializeObject((object)newdata);
                sw.WriteLine(obj);

            }
            using (StreamWriter sw = File.CreateText($@"{src}\{outpath2}"))
            {
                var obj = JsonConvert.SerializeObject((object)newdata2);
                sw.WriteLine(obj);

            }
        }
        public void ReadDataJSon()
        {
            using (StreamReader sr = File.OpenText($@"{src}\{inpath}"))
            {
                var json = sr.ReadToEnd();
                var data = JsonConvert.DeserializeObject<PayLoad>(json);
                foreach (var maths in data.Maths)
                {
                    totalofmath = maths.ToTal();
                    MulOfMath = maths.Multiple();
                    Console.WriteLine(maths.ToString());
                }
                foreach (var chemistries in data.Chemistries)
                {
                    totalofchem = chemistries.ToTal();
                    MulOfChem = chemistries.Multiple();
                    Console.WriteLine(chemistries.ToString());
                }
                foreach (var physicals in data.Physicals)
                {
                    totalofphy = physicals.ToTal();
                    MulOfPhy = physicals.Multiple();
                    Console.WriteLine(physicals.ToString());
                }

            }
        }
    }
}
