using System;

namespace ClassDemo2DLambdaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            LambdaWorker worker = new LambdaWorker();
            //worker.StartLambda();

            worker.StartLinq();

            Console.ReadLine();
        }
    }
}
