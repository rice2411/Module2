using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ReadJSonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteJSon wj = new WriteJSon(@"D:\CodeGym\Module2\Baitap\BaiTap\ReadJSonFile\data", @"db.json", @"output1db.json", @"output2db.json");
            wj.Start();
        }
    }
}
