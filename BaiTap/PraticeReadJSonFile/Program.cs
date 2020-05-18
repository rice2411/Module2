using PraticeReadJSonFile.Service;
using System;


namespace PraticeReadJSonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"D:\CodeGym\Module2\Baitap\BaiTap\PraticeReadJSonFile\data\inputjson.json";
            string output = @"D:\CodeGym\Module2\Baitap\BaiTap\PraticeReadJSonFile\data\outputjson.json";
            JSonService jss = new JSonService(input, output);
            jss.ReadJSon();
            jss.WriteJSon();
        }
    }
}
