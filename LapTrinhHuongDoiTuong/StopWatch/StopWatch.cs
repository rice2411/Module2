using System;
using System.Text;

namespace Datetime
{
    class Stopwatch
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            int[] arr = new int[10000000];
            int sum = 0;
            Random r = new Random();
            for(int i =0; i< 10000000; i++)
            {
                arr[i] = r.Next(0,10000000);
            }
            stopWatch sw = new stopWatch();
            Console.WriteLine(sw.getstartTime());
            sw.start();
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            sw.stop();
            Console.WriteLine(sum);
            Console.WriteLine("Times span: {0} miliseconds", sw.getElapsedTime());
         

        }
        
        public class stopWatch
        {   
                private int startTime;
                private int endTime;
                public stopWatch()
            {
            }
               public void construct()
            {
                int msec = DateTime.Now.Millisecond;
                this.startTime = msec;
             
            }
               public int getstartTime()
            {
               return this.startTime;

            }
               public int getendTime()
            {
                return this.endTime;
            }
            public void start()
            {
                int msec = DateTime.Now.Millisecond;
                this.startTime = msec;
          
            }
            public void stop()
            {
                int msec = DateTime.Now.Millisecond;
                this.endTime = msec;
              
            }
            public float getElapsedTime()
            {
                var dto = this.endTime - this.startTime;
              
                return dto;
            }
        }
        
       
    }
}
