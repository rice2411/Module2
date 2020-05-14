using System;
using System.IO;
namespace TryCatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = $"[Error]{DateTime.Now.ToLocalTime().ToString("dd_MM_yyyy")}.txt";
            string path = $@"D:\CodeGym\Module2\Baitap\BaiTap\TryCatchDemo\File\{fileName}";
            try
            {
                Console.Write("a= ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b= ");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(DivideByZeroException e)
            {
              /*  Console.WriteLine($"{e.GetType().Name}: {e.Message}, at time: {DateTime.Now.ToLocalTime().ToString("hh:mm:ssss/dd/MM/yyyy")}");*/
              using(StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{e.GetType().Name}: {e.Message} at time: {DateTime.Now.ToLocalTime().ToString("hh:mm:ssss/dd/MM/yyyy")}");
                };
            }
            catch (OverflowException e)
            {
          /*      Console.WriteLine($"{e.GetType().Name}: {e.Message}, at time: {DateTime.Now.ToLocalTime().ToString("hh:mm:ssss/dd/MM/yyyy")}");*/
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{e.GetType().Name}: {e.Message} at time: {DateTime.Now.ToLocalTime().ToString("hh:mm:ssss/dd/MM/yyyy")}");
                };

            }
            catch (FormatException e)
            {
              /*  Console.WriteLine($"{e.GetType().Name}: {e.Message}, at time: {DateTime.Now.ToLocalTime().ToString("hh:mm:ssss/dd/MM/yyyy")}");*/
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{e.GetType().Name}: {e.Message} at time: {DateTime.Now.ToLocalTime().ToString("hh:mm:ssss/dd/MM/yyyy")}");
                };
            }
            catch (Exception e)
            {
            /*    Console.WriteLine($"{e.GetType().Name}: {e.Message}, at time: {DateTime.Now.ToLocalTime().ToString("hh:mm:ssss/dd/MM/yyyy")}");*/
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{e.GetType().Name}: {e.Message} at time: {DateTime.Now.ToLocalTime().ToString("hh:mm:ssss/dd/MM/yyyy")}");
                };
            }
            finally
            {
                Console.WriteLine("Hello wordp2");
                Console.WriteLine("hello word");
            }
        }
    }
}
