using System;
using System.Collections.Generic;
using System.Linq;
using ClassDemo2DLambdaLinq.model;

namespace ClassDemo2DLambdaLinq
{
    public class LambdaWorker
    {

        // definerer type af metode referencen
        delegate int AddType(int x, int y);
     
        // erklærer en variable Sum der kan pege på en metode
        private AddType Sum = null;


        // prædefineret delegate metoder Action = returværdien er void hhv Func = har en returværdi
        private Action<string> stringMetode;
        private Func<int, int, int> talMetode;


        public LambdaWorker()
        {
        }

        public void StartLambda()
        {

            // tildeles en metode - som lambda udtryk
            Sum = (x, y) => x + y; 

            int res = Sum(5, 8);

            Console.WriteLine(res);

            Sum = EnAndenMetode;

            res = Sum(5, 8);

            Console.WriteLine(res);


            stringMetode = (s) =>
            {
                Console.WriteLine("Dette er en tekst " + s);
            };
            talMetode = (x, y) => x + y;

            stringMetode("Peter");

            int res2 = talMetode(4, 9);
            Console.WriteLine("Talmetode = " + res2);


        }

        private int EnAndenMetode(int i, int j)
        {
            return (i + j) * 2;
        }




        public void StartLinq()
        {
            List<Bil> biler = new List<Bil>(MockDataFactory.GetBiler);

            



        }

    }
}