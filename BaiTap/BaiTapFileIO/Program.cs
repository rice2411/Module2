using System;
using System.IO;
namespace BaiTapFileIO
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string pathInput = @"D:\CodeGym\Module2\Baitap\BaiTap\BaiTapFileIO\File\InputData.txt";
            string pathOutput= @"D:\CodeGym\Module2\Baitap\BaiTap\BaiTapFileIO\File\OutputData.txt";
            IOFile ioFile = new IOFile();
            ioFile.ReadFile(pathInput);
            ioFile.WriteFile( pathOutput);
         
        }
        
    }
}
