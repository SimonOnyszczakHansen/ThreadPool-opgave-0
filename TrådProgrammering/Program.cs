using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrådProgrammering
{
    internal class ThreadPoolDemo
    {
        public void task1(object obj)
        {
            for (int i = 0; i < 2; i++) { }
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }

        public void task2(object obj) 
        {
            for (int i = 0;i < 2;i++) 
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }
        static void Main(string[] args)
        {
            ThreadPoolDemo tdp = new ThreadPoolDemo();//this creates a new threadpool

            for (int i = 0; i < 2; i++) 
            {
                //This connects the threadpool to the methods
                ThreadPool.QueueUserWorkItem(tdp.task1);
                ThreadPool.QueueUserWorkItem(tdp.task2);
            }


            Console.Read();
        }
    }
}
