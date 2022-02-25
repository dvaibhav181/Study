using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MultipleAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            var finalresult = StartAsyncOperation();//.GetAwaiter().GetResult();
            Task.Delay(10000);
            s.Stop();
            TimeSpan ts = s.Elapsed;
            var myarr = new Array[1,2,3,4];

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
        }

        private static async Task<string> StartAsyncOperation()
        {
            try {
             //await OperationAsync1();
            //Console.WriteLine("6000");
             //await OperationAsync2();
             //Console.WriteLine("5000");
             await OperationAsync3();
             Console.WriteLine("3000");
             return "Rascala..";
            }
            catch(Exception ex){
                throw ex;
            }
          
        }

        private static async Task OperationAsync3()
        {
            await Task.Delay(1000);
            
        }

        private static async Task OperationAsync2()
        {
            
            await Task.Delay(5000);
            
        }

        private static async Task OperationAsync1()
        {
            //Console.WriteLine("1");
            await Task.Delay(6000);
            // Console.WriteLine("2");
            
        }
    }
}
