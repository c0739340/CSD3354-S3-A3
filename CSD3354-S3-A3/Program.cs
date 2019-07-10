using System;

namespace CSD3354_S3_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataProcessing dataProcessing = new DataProcessing();
            dataProcessing.processData();
        }
    }

    public class DataProcessing
    {
        public void processData()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        
    }
}
