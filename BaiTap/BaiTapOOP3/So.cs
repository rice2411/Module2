using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BaiTapOOP3
{
    class So
    {
        public string GiaTri { get; set; }
        public string HCS { get; set; }

        public double ConVert(string GiaTri, string HCS)
        {
            double result = 0;
         
            switch(HCS)
            {
                case "2":
                case "8":
                  for(int i =0;i < GiaTri.Length;i++)
                    {
                        string val = GiaTri[i].ToString().ToLower();
                        result += Double.Parse(val) * Math.Pow(Double.Parse(HCS), GiaTri.Length - 1 - i);
                    }
                
                    return result;
                    break;
                case "16":
                    for (int i = 0; i < GiaTri.Length; i++)
                    {
                        string val = GiaTri[i].ToString().ToLower();
                        switch (val)
                        {
                            case "a":
                                val = "10";
                                break;
                            case "b":
                                val = "11";
                                break;
                            case "c":
                                val = "12";
                                break;
                            case "d":
                                val = "13";
                                break;
                            case "e":
                                val = "14";
                                break;
                            case "f":
                                val = "15";
                                break;
                        }
                        result += Double.Parse(val) * Math.Pow(Double.Parse(HCS), GiaTri.Length - 1 - i);
                    }
                
                    return result;
                    break;
            }
            return result;
        }
     
    }
}
