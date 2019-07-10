using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

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
            string path = "C:/C#ClassStuff/July10ReadData/CSD3354-S3-A3/CSD3354-S3-A3/DataContainer.txt";
            Queue dataQueue = new Queue();
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    dataQueue.Enqueue(s);

                }
            }

            Stack dataStack = getDataInStack(dataQueue);
            LinkedList<String> dataList = getDataLinkedList(dataStack);

            Console.WriteLine("Printing Data from LinkedList before sorting");
            foreach (string str in dataList)
            {
                Console.WriteLine(str);

            }
            var orderedList = new List<String>();
            orderedList.AddRange(dataList);
            orderedList.Sort();

            Console.WriteLine("Printing Data from LinkedList after sorting");
            foreach (string str in orderedList)
            {
                Console.WriteLine(str);

            }

            Console.ReadKey();
        }

        public Stack getDataInStack(Queue dataQueue)
        {
            Stack dataStack = new Stack();
            Console.WriteLine("Printing Data from Queue(FIFO) and entering in stack");
            foreach (Object obj in dataQueue)
            {

                dataStack.Push(obj);
                Console.WriteLine(obj);

            }
            return dataStack;
        }

        public LinkedList<string> getDataLinkedList(Stack dataStack)
        {
            LinkedList<String> dataList = new LinkedList<String>();
            Console.WriteLine("Printing Data from Stack(LIFO) and entering in LinkedList");
            foreach (string str in dataStack)
            {
                dataList.AddLast(str);
                Console.WriteLine(str);
               
            }
            return dataList;
}
    }

}
